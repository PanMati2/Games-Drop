using System;
using System.Threading.Tasks;
using AutoMapper;
using GamesDrop.Contracts.Requests;
using GamesDrop.Contracts.Responses;
using GamesDrop.Dtos;
using GamesDrop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesDrop.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public AuthController(IUserService userService, IMapper mapper, IJwtService jwtService,
            ICartService cartService)
        {
            _userService = userService;
            _mapper = mapper;
            _jwtService = jwtService;
            _cartService = cartService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var userDto = await _userService.GetUserDtoByCredentialsAsync(request.Email, request.Password);

            if (userDto == null)
                return BadRequest(new ErrorsResponse("login or password are wrong"));

            var response = _mapper.Map<LoginResponse>(userDto);
            response.AccessToken = _jwtService.GetNewAccessToken(userDto, Guid.NewGuid());

            return Ok(response);
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var emailTaken = await _userService.UserExistsByEmail(request.Email);

            if (emailTaken)
                return BadRequest(new ErrorsResponse("email is already taken"));

            var newUserDto = _mapper.Map<UserDto>(request);

            var registerResult = await _userService.CreateUserAsync(newUserDto, request.Password);

            await _cartService.CreateCartAsync(newUserDto.Id);

            return registerResult.Succeeded
                ? NoContent()
                : BadRequest(new ErrorsResponse(registerResult.Errors));
        }
    }
}
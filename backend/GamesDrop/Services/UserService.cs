using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesDrop.Data.Entities;
using GamesDrop.Dtos;
using GamesDrop.Results;
using GamesDrop.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace GamesDrop.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<bool> UserExistsByEmail(string email)
        {
            return await _userManager.FindByEmailAsync(email) != null;
        }

        public async Task<ServiceResult> CreateUserAsync(UserDto user, string password)
        {
            var newUser = _mapper.Map<User>(user);

            var result = await _userManager.CreateAsync(newUser, password);
            await _userManager.AddToRoleAsync(newUser, "User");
            user.Id = newUser.Id;

            return result.Succeeded
                ? ServiceResult.Success()
                : ServiceResult.Failure(result.Errors.Select(x => x.Description));
        }

        public async Task<UserDto> GetUserDtoByCredentialsAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
                return null;

            var validPassword = await _userManager.CheckPasswordAsync(user, password);

            if (!validPassword)
                return null;

            return UserToUserDto(user, await _userManager.GetRolesAsync(user));
        }

        private UserDto UserToUserDto(User user, IList<string> roles)
        {
            var userDto = _mapper.Map<UserDto>(user);
            userDto.Roles = roles;

            return userDto;
        }
    }
}
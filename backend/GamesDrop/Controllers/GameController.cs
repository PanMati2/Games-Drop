using System.Threading.Tasks;
using AutoMapper;
using GamesDrop.Contracts.Requests;
using GamesDrop.Contracts.Responses;
using GamesDrop.Dtos;
using GamesDrop.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamesDrop.Controllers
{
    [ApiController]
    [Route("api/games/")]
    public class GameController : ControllerBase
    {
        private readonly IGameCategoryService _gameCategoryService;
        private readonly IGamePlatformService _gamePlatformService;
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;

        public GameController(IGameService gameService, IMapper mapper, IGameCategoryService gameCategoryService,
            IGamePlatformService gamePlatformService)
        {
            _gameService = gameService;
            _mapper = mapper;
            _gameCategoryService = gameCategoryService;
            _gamePlatformService = gamePlatformService;
        }

        [HttpGet("platforms")]
        public async Task<IActionResult> GetGamePlatforms()
        {
            var gamePlatformDtos = await _gamePlatformService.GetGamePlatformDtosAsync();
            return Ok(gamePlatformDtos);
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetGameCategories()
        {
            var gameCategoryDtos = await _gameCategoryService.GetGameCategoryDtosAsync();
            return Ok(gameCategoryDtos);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGames()
        {
            var gameDtos = await _gameService.GetGameDtosAsync();
            return Ok(gameDtos);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateGame(CreateGameRequest request)
        {
            var categoryExists = await _gameCategoryService.CategoryExistsByIdAsync(request.CategoryId);
            var platformExists = await _gamePlatformService.PlatformExistsByIdAsync(request.PlatformId);

            if (!categoryExists)
                return BadRequest(new ErrorsResponse("niewłasciwy id kategorii"));

            if (!platformExists)
                return BadRequest(new ErrorsResponse("niewłaściwy id platformy"));

            var gameDto = _mapper.Map<GameDto>(request);
            var result = await _gameService.CreateGameAsync(gameDto);

            return result.Succeeded
                ? NoContent()
                : BadRequest(new ErrorsResponse(result.Errors));
        }
    }
}
using System.Threading.Tasks;
using GamesDrop.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GamesDrop.Controllers
{
    [ApiController]
    [Route("api/games/recomended")]
    public class RecommendedController : ControllerBase
    {
        private readonly IGameService _gameService;

        public RecommendedController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRecommendedGames()
        {
            var recommendedGames = await _gameService.GetRecommendedGameDtosAsync();
            return recommendedGames == null ? NotFound() : Ok(recommendedGames);
        }
    }
}
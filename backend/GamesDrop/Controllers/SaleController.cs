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
    [Route("api/games/sales")]
    public class SaleController : ControllerBase
    {
        private readonly IGameService _gameService;
        private readonly IMapper _mapper;
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService, IGameService gameService, IMapper mapper)
        {
            _saleService = saleService;
            _gameService = gameService;
            _mapper = mapper;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreteSale(CreateSaleRequest request)
        {
            var gameExists = await _gameService.GameExistsByIdAsync(request.GameId);

            if (!gameExists)
                return BadRequest(new ErrorsResponse("gra nie istnieje"));

            var gameOnSale =
                await _saleService.SaleExistsAsync(request.GameId, request.ValidFrom, request.ValidTo);

            if (gameOnSale)
                return BadRequest(new ErrorsResponse("gra znajduje się aktualnie na promocji w tej dacie"));

            var saleDto = _mapper.Map<SaleDto>(request);
            var result = await _saleService.CreateSaleAsync(saleDto);

            return result.Succeeded
                ? NoContent()
                : BadRequest(new ErrorsResponse(result.Errors));
        }

        [HttpGet]
        public async Task<IActionResult> GetGamesOnSale()
        {
            var gameDtos = await _saleService.GetAllGameDtosOnSaleAsync();
            return gameDtos == null ? NotFound() : Ok(gameDtos);
        }
    }
}
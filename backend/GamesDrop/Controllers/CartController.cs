using System.Linq;
using System.Threading.Tasks;
using GamesDrop.Contracts.Requests;
using GamesDrop.Contracts.Responses;
using GamesDrop.Extensions;
using GamesDrop.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamesDrop.Controllers
{
    [ApiController]
    [Route("api/cart/items")]
    [Authorize]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IGameService _gameService;

        public CartController(ICartService cartService, IGameService gameService)
        {
            _cartService = cartService;
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var cart = await _cartService.GetUserCartAsync(HttpContext.GetUserId());
            return cart != null
                ? Ok(cart)
                : NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequest request)
        {
            var gameExists = await _gameService.GameExistsByIdAsync(request.GameId);

            if (!gameExists)
                return BadRequest(new ErrorsResponse("gra nie istnieje"));

            var result = await _cartService.AddToCartAsync(HttpContext.GetUserId(), request.GameId);

            return result.Succeeded
                ? NoContent()
                : BadRequest(result.Errors);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFromCart([FromBody] DeleteFromCartRequest request)
        {
            var cart = await _cartService.GetUserCartAsync(HttpContext.GetUserId());

            if (cart.CartItems.FirstOrDefault(cartItem => cartItem.Game.Id == request.GameId) == null)
                return BadRequest(new ErrorsResponse("gra nie znajduje się w koszyku"));

            var result = await _cartService.RemoveFromCartAsync(HttpContext.GetUserId(), request.GameId);

            return result.Succeeded
                ? NoContent()
                : BadRequest(result.Errors);
        }

        [HttpPost("clear")]
        public async Task<IActionResult> ClearCart()
        {
            var result = await _cartService.ClearCartAsync(HttpContext.GetUserId());

            return result.Succeeded
                ? NoContent()
                : BadRequest(result.Errors);
        }
    }
}
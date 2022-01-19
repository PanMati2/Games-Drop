using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesDrop.Data;
using GamesDrop.Data.Entities;
using GamesDrop.Dtos;
using GamesDrop.Results;
using GamesDrop.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesDrop.Services
{
    public class CartService : ICartService
    {
        private readonly ApplicationDbContext _context;
        private readonly IGameService _gameService;

        public CartService(ApplicationDbContext context, IGameService gameService)
        {
            _context = context;
            _gameService = gameService;
        }

        public async Task<CartDto> GetUserCartAsync(string userId)
        {
            var cart = await _context.Carts
                .AsNoTracking()
                .Include(cart1 => cart1.CartItems)
                .FirstOrDefaultAsync(cart1 => cart1.UserId == userId);

            if (cart == null || !cart.CartItems.Any())
                return null;

            var cartItemsDto = new List<CartItemDto>();

            foreach (var cartItem in cart.CartItems)
            {
                var gameDto = await _gameService.GetGameByIdAsync(cartItem.GameId);
                var cartItemDto = new CartItemDto {Game = gameDto, Quantity = cartItem.Quantity};
                cartItemsDto.Add(cartItemDto);
            }

            var cartDto = new CartDto
            {
                CartItems = cartItemsDto
            };

            return cartDto;
        }

        public async Task<ServiceResult> AddToCartAsync(string userId, int gameId)
        {
            var cart = await _context.Carts
                .AsNoTracking()
                .Include(cart1 => cart1.CartItems)
                .FirstOrDefaultAsync(cart1 => cart1.UserId == userId);

            if (cart == null)
                return ServiceResult.Failure("użytkownik nie posiada koszyka");

            var existingCartItem = cart.CartItems.FirstOrDefault(item => item.GameId == gameId);

            if (existingCartItem != null)
            {
                existingCartItem.Quantity++;
                _context.CartItem.Update(existingCartItem);

                return await _context.SaveChangesAsync() > 0
                    ? ServiceResult.Success()
                    : ServiceResult.Failure("coś poszło nie tak");
            }

            var cartItem = new CartItem
            {
                GameId = gameId,
                CardId = cart.Id,
                Quantity = 1
            };

            await _context.CartItem.AddAsync(cartItem);
            return await _context.SaveChangesAsync() > 0
                ? ServiceResult.Success()
                : ServiceResult.Failure("coś poszło nie tak");
        }

        public async Task<ServiceResult> ClearCartAsync(string userId)
        {
            var cart = await _context.Carts
                .AsNoTracking()
                .Include(cart1 => cart1.CartItems)
                .FirstOrDefaultAsync(cart1 => cart1.UserId == userId);

            if (cart?.CartItems == null)
                return ServiceResult.Failure("użytkownik nie posiada koszyka lub koszyk jest pusty");

            _context.RemoveRange(cart.CartItems.Select(item => item));
            return await _context.SaveChangesAsync() > 0
                ? ServiceResult.Success()
                : ServiceResult.Failure("coś poszło nie tak");
        }

        public async Task<ServiceResult> RemoveFromCartAsync(string userId, int gameId)
        {
            var cart = await _context.Carts
                .AsNoTracking()
                .Include(x => x.CartItems)
                .FirstOrDefaultAsync(cart1 => cart1.UserId == userId);

            if (cart == null)
                return ServiceResult.Failure("użytkownik nie posiada koszyka lub produkt nie znajduje się w koszyku");

            var cartItem = cart.CartItems.SingleOrDefault(item => item.GameId == gameId);

            if (cartItem == null)
                return ServiceResult.Failure("użytkownik nie posiada koszyka lub produkt nie znajduje się w koszyku");

            _context.CartItem.Remove(cartItem);
            return await _context.SaveChangesAsync() > 0
                ? ServiceResult.Success()
                : ServiceResult.Failure("coś poszło nie tak");
        }

        public async Task<bool> CreateCartAsync(string userId)
        {
            var cart = new Cart {UserId = userId};
            await _context.Carts.AddAsync(cart);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesDrop.Data;
using GamesDrop.Data.Entities;
using GamesDrop.Dtos;
using GamesDrop.Results;
using GamesDrop.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesDrop.Services
{
    public class SaleService : ISaleService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public SaleService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> SaleExistsAsync(int gameId, DateTime validFrom, DateTime validTo)
        {
            var sale = await _context
                .Sales
                .AsNoTracking()
                .SingleOrDefaultAsync(sale1 =>
                    sale1.GameId == gameId &&
                    (sale1.ValidFrom <= validFrom && sale1.ValidTo >= validFrom ||
                     sale1.ValidFrom <= validTo && sale1.ValidTo >= validTo));

            return sale != null;
        }

        public async Task<ServiceResult> CreateSaleAsync(SaleDto saleDto)
        {
            var sale = _mapper.Map<Sale>(saleDto);

            await _context.Sales.AddAsync(sale);
            return await _context.SaveChangesAsync() > 0
                ? ServiceResult.Success()
                : ServiceResult.Failure("coś poszło nie tak");
        }

        public async Task<IEnumerable<GameDto>> GetAllGameDtosOnSaleAsync()
        {
            var games = await _context.Games
                .AsNoTracking()
                .Include(game => game.Keys)
                .Include(game => game.GameCategory)
                .Include(game => game.GamePlatform)
                .ThenInclude(platform => platform.OperatingSystem)
                .ThenInclude(system => system.Device)
                .Include(
                    game => game.Sales)
                .Where(game => game.Sales.Select(sale => sale.ValidFrom > DateTime.Now && sale.ValidTo < DateTime.Now)
                    .Any())
                .ToArrayAsync();

            if (games == null || games.Length == 0)
                return null;

            var gameDtos = new List<GameDto>();

            foreach (var game in games)
            {
                var gameDto = new GameDto
                {
                    Id = game.Id,
                    CategoryId = game.CategoryId,
                    Title = game.Title,
                    Recommended = game.Recommended,
                    CategoryName = game.GameCategory.Name,
                    CoverUrl = game.CoverUrl,
                    TrailerUrl = game.TrailerUrl,
                    Description = game.Description,
                    DeviceId = game.GamePlatform.OperatingSystem.Device.Id,
                    DeviceName = game.GamePlatform.OperatingSystem.Device.Name,
                    OperatingSystemId = game.GamePlatform.OperatingSystem.Id,
                    OperatingSystemName = game.GamePlatform.OperatingSystem.Name,
                    PlatformId = game.GamePlatform.Id,
                    PlatformName = game.GamePlatform.Name,
                    Price = game.Price,
                    KeysInStock = game.Keys.Count(),
                    PercentDiscount = game.Sales.First().PercentDiscount
                };

                if (game.Sales.Any()) gameDto.PercentDiscount = game.Sales.First().PercentDiscount;

                gameDtos.Add(gameDto);
            }

            return gameDtos;
        }
    }
}
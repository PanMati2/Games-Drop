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
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GameService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GameDto>> GetGameDtosAsync()
        {
            var games = await _context.Games
                .AsNoTracking()
                .Include(game => game.Keys)
                .Include(game => game.GameCategory)
                .Include(game => game.GamePlatform)
                .ThenInclude(platform => platform.OperatingSystem)
                .ThenInclude(system => system.Device)
                .Include(
                    game => game.Sales.Where(sale => sale.ValidFrom > DateTime.Now && sale.ValidTo < DateTime.Now))
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
                    KeysInStock = game.Keys.Count()
                };

                if (game.Sales.Any()) gameDto.PercentDiscount = game.Sales.First().PercentDiscount;

                gameDtos.Add(gameDto);
            }

            return gameDtos;
        }

        public async Task<ServiceResult> CreateGameAsync(GameDto gameDto)
        {
            var game = _mapper.Map<Game>(gameDto);

            await _context.Games.AddAsync(game);
            return await _context.SaveChangesAsync() > 0
                ? ServiceResult.Success()
                : ServiceResult.Failure("coś poszło nie tak, spróbuj ponownie później");
        }

        public async Task<bool> GameExistsByIdAsync(int gameId)
        {
            var game = await _context.Games.AsNoTracking().SingleOrDefaultAsync(game1 => game1.Id == gameId);
            return game != null;
        }

        public async Task<IEnumerable<GameDto>> GetRecommendedGameDtosAsync()
        {
            var games = await _context.Games
                .AsNoTracking()
                .Include(game => game.Keys)
                .Include(game => game.GameCategory)
                .Include(game => game.GamePlatform)
                .ThenInclude(platform => platform.OperatingSystem)
                .ThenInclude(system => system.Device)
                .Include(
                    game => game.Sales.Where(sale => sale.ValidFrom > DateTime.Now && sale.ValidTo < DateTime.Now))
                .Where(game => game.Recommended)
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
                    KeysInStock = game.Keys.Count()
                };

                if (game.Sales.Any()) gameDto.PercentDiscount = game.Sales.First().PercentDiscount;

                gameDtos.Add(gameDto);
            }

            return gameDtos;
        }

        public async Task<GameDto> GetGameByIdAsync(int gameId)
        {
            var game = await _context.Games
                .AsNoTracking()
                .Include(game1 => game1.Keys)
                .Include(game1 => game1.GameCategory)
                .Include(game1 => game1.GamePlatform)
                .ThenInclude(platform => platform.OperatingSystem)
                .ThenInclude(system => system.Device)
                .Include(
                    game1 => game1.Sales.Where(sale => sale.ValidFrom > DateTime.Now && sale.ValidTo < DateTime.Now))
                .FirstOrDefaultAsync(game1 => game1.Id == gameId);

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
                KeysInStock = game.Keys.Count()
            };

            if (game.Sales.Any()) gameDto.PercentDiscount = game.Sales.First().PercentDiscount;

            return gameDto;
        }
    }
}
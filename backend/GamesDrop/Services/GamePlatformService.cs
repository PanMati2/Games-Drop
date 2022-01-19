using System.Collections.Generic;
using System.Threading.Tasks;
using GamesDrop.Data;
using GamesDrop.Dtos;
using GamesDrop.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesDrop.Services
{
    public class GamePlatformService : IGamePlatformService
    {
        private readonly ApplicationDbContext _context;

        public GamePlatformService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GamePlatformDto>> GetGamePlatformDtosAsync()
        {
            var gamePlatforms = await _context.GamePlatforms
                .AsNoTracking()
                .Include(platform => platform.OperatingSystem)
                .ThenInclude(system => system.Device)
                .ToArrayAsync();

            if (gamePlatforms == null || gamePlatforms.Length == 0)
                return null;

            var gamePlatformDtos = new List<GamePlatformDto>();

            foreach (var gamePlatform in gamePlatforms)
            {
                var gamePlatformDto = new GamePlatformDto
                {
                    Id = gamePlatform.Id,
                    Name = gamePlatform.Name,
                    OperatingSystem = gamePlatform.OperatingSystem.Name,
                    Device = gamePlatform.OperatingSystem.Device.Name
                };

                gamePlatformDtos.Add(gamePlatformDto);
            }

            return gamePlatformDtos;
        }

        public async Task<bool> PlatformExistsByIdAsync(int platformId)
        {
            var platform =
                await _context.GamePlatforms
                    .AsNoTracking()
                    .FirstOrDefaultAsync(gamePlatform => gamePlatform.Id == platformId);

            return platform != null;
        }
    }
}
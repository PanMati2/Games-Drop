using System.Collections.Generic;
using System.Threading.Tasks;
using GamesDrop.Dtos;

namespace GamesDrop.Services.Interfaces
{
    public interface IGamePlatformService
    {
        Task<IEnumerable<GamePlatformDto>> GetGamePlatformDtosAsync();
        Task<bool> PlatformExistsByIdAsync(int platformId);
    }
}
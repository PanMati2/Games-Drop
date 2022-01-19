using System.Collections.Generic;
using System.Threading.Tasks;
using GamesDrop.Dtos;
using GamesDrop.Results;

namespace GamesDrop.Services.Interfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetGameDtosAsync();
        Task<ServiceResult> CreateGameAsync(GameDto gameDto);
        Task<bool> GameExistsByIdAsync(int gameId);
        Task<IEnumerable<GameDto>> GetRecommendedGameDtosAsync();
        Task<GameDto> GetGameByIdAsync(int gameId);
    }
}
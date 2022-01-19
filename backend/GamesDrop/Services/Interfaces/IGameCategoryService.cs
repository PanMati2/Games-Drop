using System.Collections.Generic;
using System.Threading.Tasks;
using GamesDrop.Dtos;

namespace GamesDrop.Services.Interfaces
{
    public interface IGameCategoryService
    {
        Task<IEnumerable<GameCategoryDto>> GetGameCategoryDtosAsync();
        Task<bool> CategoryExistsByIdAsync(int categoryId);
    }
}
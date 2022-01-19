using System.Threading.Tasks;
using GamesDrop.Dtos;
using GamesDrop.Results;

namespace GamesDrop.Services.Interfaces
{
    public interface ICartService
    {
        Task<CartDto> GetUserCartAsync(string userId);
        Task<ServiceResult> AddToCartAsync(string userId, int gameId);
        Task<ServiceResult> ClearCartAsync(string userId);
        Task<ServiceResult> RemoveFromCartAsync(string userId, int gameId);
        Task<bool> CreateCartAsync(string userId);
    }
}
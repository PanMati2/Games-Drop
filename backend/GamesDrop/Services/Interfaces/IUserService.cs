using System.Threading.Tasks;
using GamesDrop.Dtos;
using GamesDrop.Results;

namespace GamesDrop.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> UserExistsByEmail(string email);
        Task<ServiceResult> CreateUserAsync(UserDto user, string password);
        Task<UserDto> GetUserDtoByCredentialsAsync(string email, string password);
    }
}
using DataAccess.Entities;
using SharedModels.DTOs;

namespace DataAccess.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDTO> GetUserByFileAsync(int file);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> CreateUserAsync(UserCreateDTO userCreateDto);
        Task DeleteUserAsync(int file);
    }
}
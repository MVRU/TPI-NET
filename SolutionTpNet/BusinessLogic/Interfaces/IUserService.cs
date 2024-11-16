using SharedModels.DTOs;

namespace BusinessLogic.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetUserAsync(int file);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> CreateUserAsync(UserCreateDTO userCreateDto);
        Task<bool> DeleteUserAsync(int file);
    }
}
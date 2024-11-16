using AutoMapper;
using BusinessLogic.Interfaces;
using SharedModels.DTOs;
using DataAccess.Interfaces;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> GetUserAsync(int file)
        {
            return await _userRepository.GetUserByFileAsync(file);
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<UserDTO> CreateUserAsync(UserCreateDTO userCreateDto)
        {
            return await _userRepository.CreateUserAsync(userCreateDto);
        }

        public async Task<bool> DeleteUserAsync(int file)
        {
            var user = await _userRepository.GetUserByFileAsync(file);
            if (user == null) return false;

            await _userRepository.DeleteUserAsync(file);
            return true;
        }
    }
}
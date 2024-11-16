using DataAccess.Entities;
using DataAccess.Interfaces;
using DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using SharedModels.DTOs;
using AutoMapper;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UniversityDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(UniversityDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetUserByFileAsync(int file)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.File == file);
            return user == null ? null : _mapper.Map<UserDTO>(user);
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> CreateUserAsync(UserCreateDTO userCreateDto)
        {
            var user = _mapper.Map<User>(userCreateDto);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserDTO>(user);
        }

        public async Task DeleteUserAsync(int file)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.File == file);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }
}
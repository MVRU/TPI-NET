using SharedModels.Interfaces;

namespace DataAccess.Interfaces;

public interface IUserRepository
{
    Task AddAsync(IUser user);
    Task<IUser?> GetByIdAsync(int id);
    Task<IUser?> GetByEmailAsync(string email);
}
using SharedModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IProfessorRepository
    {
        Task<List<Professor>> GetAllAsync();
        Task<Professor?> GetByIdAsync(int id);
        Task AddAsync(Professor professor);
        Task UpdateAsync(Professor professor);
        Task DeleteAsync(int id);
    }
}
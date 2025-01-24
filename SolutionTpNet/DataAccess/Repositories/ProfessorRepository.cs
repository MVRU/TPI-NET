using Microsoft.EntityFrameworkCore;
using SharedModels.Models;

namespace DataAccess.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly UniversityDbContext _context;

        public ProfessorRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public async Task<List<Professor>> GetAllAsync()
        {
            return await _context.Professors.ToListAsync();
        }

        public async Task<Professor?> GetByIdAsync(int id)
        {
            return await _context.Professors.FindAsync(id);
        }

        public async Task AddAsync(Professor professor)
        {
            await _context.Professors.AddAsync(professor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Professor professor)
        {
            _context.Professors.Update(professor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var professor = await _context.Professors.FindAsync(id);
            if (professor != null)
            {
                _context.Professors.Remove(professor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
using DataAccess.Repositories;
using SharedModels.Models;

namespace BusinessLogic.Services
{
    public class ProfessorService
    {
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public async Task<List<Professor>> GetAllProfessorsAsync()
        {
            return await _professorRepository.GetAllAsync();
        }

        public async Task<Professor?> GetProfessorByIdAsync(int id)
        {
            return await _professorRepository.GetByIdAsync(id);
        }

        public async Task AddProfessorAsync(Professor professor)
        {
            await _professorRepository.AddAsync(professor);
        }

        public async Task UpdateProfessorAsync(Professor professor)
        {
            await _professorRepository.UpdateAsync(professor);
        }

        public async Task DeleteProfessorAsync(int id)
        {
            await _professorRepository.DeleteAsync(id);
        }
    }
}
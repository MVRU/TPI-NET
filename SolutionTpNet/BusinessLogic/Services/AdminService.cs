using DataAccess.Repositories;
using SharedModels.Models;

namespace BusinessLogic.Services
{
    public class AdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<List<Admin>> GetAllAdminsAsync()
        {
            return await _adminRepository.GetAllAsync();
        }

        public async Task<Admin?> GetAdminByIdAsync(int id)
        {
            return await _adminRepository.GetByIdAsync(id);
        }

        public async Task AddAdminAsync(Admin admin)
        {
            await _adminRepository.AddAsync(admin);
        }

        public async Task UpdateAdminAsync(Admin admin)
        {
            await _adminRepository.UpdateAsync(admin);
        }

        public async Task DeleteAdminAsync(int id)
        {
            await _adminRepository.DeleteAsync(id);
        }
    }
}
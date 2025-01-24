using DataAccess.Repositories;
using SharedModels.Models;

namespace BusinessLogic.Services
{
    public class ScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleService(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task<List<Schedule>> GetAllSchedulesAsync()
        {
            return await _scheduleRepository.GetAllAsync();
        }

        public async Task<Schedule?> GetScheduleByIdAsync(int id)
        {
            return await _scheduleRepository.GetByIdAsync(id);
        }

        public async Task AddScheduleAsync(Schedule schedule)
        {
            await _scheduleRepository.AddAsync(schedule);
        }

        public async Task UpdateScheduleAsync(Schedule schedule)
        {
            await _scheduleRepository.UpdateAsync(schedule);
        }

        public async Task DeleteScheduleAsync(int id)
        {
            await _scheduleRepository.DeleteAsync(id);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using ProyectoNET.Data;
using ProyectoNET.Models;

namespace ProyectoNET.Repositories
{
    internal class StatusRepository
    {
        private readonly UniversityContext _context;

        public StatusRepository(UniversityContext context)
        {
            _context = context;
        }

        public void CreateStatus(string description)
        {
            var status = new Status
            {
                Description = description
            };

            _context.Statuses.Add(status);
            _context.SaveChanges();
        }

        public Status GetStatusById(int id)
        {
            return _context.Statuses
                .FirstOrDefault(s => s.Id == id);
        }

        public void UpdateStatus(int id, string newDescription)
        {
            var status = _context.Statuses.FirstOrDefault(s => s.Id == id);

            if (status != null)
            {
                status.Description = newDescription;
                _context.SaveChanges();
            }
        }

        public void DeleteStatus(int id)
        {
            var status = _context.Statuses.FirstOrDefault(s => s.Id == id);

            if (status != null)
            {
                _context.Statuses.Remove(status);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Status> GetAllStatuses()
        {
            return _context.Statuses.ToList();
        }
    }
}

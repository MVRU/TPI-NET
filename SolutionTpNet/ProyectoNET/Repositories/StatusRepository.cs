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

        // Método para actualizar el estado de inscripción de un estudiante
        public void UpdateEnrollmentStatus(int enrollmentId, string statusDescription)
        {
            var enrollment = _context.Enrollments.FirstOrDefault(e => e.Id == enrollmentId);

            if (enrollment != null)
            {
                var status = _context.Statuses.FirstOrDefault(s => s.Description == statusDescription);

                if (status != null)
                {
                    enrollment.StatusId = status.Id;
                    _context.SaveChanges();
                }
            }
        }

        // Método para realizar la eliminación lógica de una inscripción
        public void MarkEnrollmentAsFree(int enrollmentId)
        {
            var enrollment = _context.Enrollments.FirstOrDefault(e => e.Id == enrollmentId);

            if (enrollment != null)
            {
                var freeStatus = _context.Statuses.FirstOrDefault(s => s.Description == "Libre");

                if (freeStatus != null)
                {
                    enrollment.StatusId = freeStatus.Id;
                    _context.SaveChanges();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using ProyectoNET.Repositories;
using ProyectoNET.Models;

namespace ProyectoNET.Controllers
{
    internal class StatusController
    {
        private readonly StatusRepository _statusRepository;

        public StatusController(StatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public void CreateStatus(string description)
        {
            _statusRepository.CreateStatus(description);
            Console.WriteLine("Estado creado con éxito.");
        }

        public void GetStatusById(int id)
        {
            var status = _statusRepository.GetStatusById(id);

            if (status != null)
            {
                Console.WriteLine($"Estado encontrado: Id {status.Id}");
                Console.WriteLine($"Descripción: {status.Description}");
            }
            else
            {
                Console.WriteLine("Estado no encontrado.");
            }
        }

        public void UpdateStatus(int id, string newDescription)
        {
            _statusRepository.UpdateStatus(id, newDescription);
            Console.WriteLine("Estado actualizado con éxito.");
        }

        public void DeleteStatus(int id)
        {
            _statusRepository.DeleteStatus(id);
            Console.WriteLine("Estado eliminado con éxito.");
        }

        public void GetAllStatuses()
        {
            var statuses = _statusRepository.GetAllStatuses();

            if (statuses.Any())
            {
                Console.WriteLine("Estados disponibles:");
                foreach (var status in statuses)
                {
                    Console.WriteLine($"Id: {status.Id}, Descripción: {status.Description}");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron estados.");
            }
        }
    }
}

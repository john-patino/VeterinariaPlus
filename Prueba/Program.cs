using BLL;

using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicioVeterinario servicio = new ServicioVeterinario();

            Veterinario javier = new Veterinario
            {
                Id = 3,
                Nombre = "Dr. Javier Méndez",
                TelefonoContacto = "3021234567"
            };

            Veterinario ana = new Veterinario
            {
                Id = 2,
                Nombre = "Dra. Ana Torres",
                TelefonoContacto = "3019876543"
            };


            //Console.WriteLine(servicio.Agregar(javier));

            var lista = servicio.ObtenerTodas();
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Id} --> {item.Nombre}  --> {item.TelefonoContacto}");
            }
            Console.ReadKey();
        }
    }
}

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
            Console.WriteLine(javier.Nombre);
            var x = javier;
            var y = javier;

            y.Nombre = "johnp";

            Console.WriteLine(x.Nombre);
            Console.WriteLine("************************");
            Console.WriteLine(javier.Nombre);
            Console.ReadKey();
        }
    }
}

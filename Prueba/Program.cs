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
            //    ENTITY.Raza unica = new ENTITY.Raza(1, "unica");
            //    ENTITY.Raza labrador = new ENTITY.Raza(2, "ladrador");

            //    DAL.RazaRepository razaRepository = new DAL.RazaRepository();
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica)); 
            //Console.WriteLine(razaRepository.Agregar(unica));

            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(unica));
            //Console.WriteLine(razaRepository.Agregar(labrador));

            BLL.ServicioRaza servicioRaza = new BLL.ServicioRaza();
            var listaRazas = servicioRaza.ObtenerTodas();

            foreach (var item in listaRazas)
            {
                Console.WriteLine($"{item.Id} --- > {item.NombreRaza}");
            }

            Console.ReadKey();
        }
    }
}

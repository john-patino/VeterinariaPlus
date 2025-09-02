using DAL;
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
            PropietarioRepository repo = new PropietarioRepository();

            Propietario pedro = new Propietario(1,"pedro","46468855");
            Propietario juan = new Propietario(1, "juan", "46468855");

            //Console.WriteLine(repo.Agregar(pedro));
            //Console.WriteLine(repo.Agregar(juan));
            //Console.WriteLine(repo.Agregar(pedro));
            //Console.WriteLine(repo.Agregar(juan));
            //Console.WriteLine(repo.Agregar(pedro));
            //Console.WriteLine(repo.Agregar(juan));
            //Console.WriteLine(repo.Agregar(pedro));
            //Console.WriteLine(repo.Agregar(pedro));
            //Console.WriteLine(repo.Agregar(juan));
            //Console.WriteLine(repo.Agregar(juan));
            var lista = repo.ObtenerTodas();

            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Id} ---> {item.Nombre}");
            }

            Console.ReadKey();
        }
    }
}

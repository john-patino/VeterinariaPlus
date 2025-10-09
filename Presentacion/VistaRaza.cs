using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class VistaRaza
    {
        ServicioRaza servicio;
        public VistaRaza()
        {
            servicio = new ServicioRaza();
        }
        public void MenuRaza()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 4); Console.WriteLine("G E S T I O N  P R O P I E T A R I O S");
                Console.SetCursorPosition(20, 6); Console.WriteLine("1. Agregar raza");
                Console.SetCursorPosition(20, 8); Console.WriteLine("2. Buscar raza");
                Console.SetCursorPosition(20, 10); Console.WriteLine("3. Actializar raza");
                Console.SetCursorPosition(20, 12); Console.WriteLine("4. Eliminar raza");
                Console.SetCursorPosition(20, 14); Console.WriteLine("5. Consultar razas");

                Console.SetCursorPosition(20, 16); Console.WriteLine("0. Salir");

                Console.SetCursorPosition(20, 20); Console.WriteLine("Seleccione una opción: ");
                Console.SetCursorPosition(44, 20); opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CapturarRaza();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        ConsultarTodos();
                        break;


                }

            } while (opcion != 0);
        }

        private void ConsultarTodos()
        {
            int salto = 0;
            Console.Clear();
            Console.SetCursorPosition(12, 3); Console.WriteLine("L I S T A D O  D E  R A Z A S ");
            Console.SetCursorPosition(15, 5); Console.Write("-------------------------------------------");
            Console.SetCursorPosition(15, 6); Console.WriteLine("ID");
            Console.SetCursorPosition(28, 6); Console.WriteLine("NOMBRE");
           

            foreach (var item in servicio.ObtenerTodas())
            {
                Console.SetCursorPosition(15, 8 + salto); Console.Write(item.Id);
                Console.SetCursorPosition(28, 8 + salto); Console.Write(item.Nombre);
                
                Console.SetCursorPosition(15, 9 + salto); Console.Write("-------------------------------------------");
                salto++;
            }
            Console.ReadKey();
        }

        private void CapturarRaza()
        {
            Raza raza = new Raza();
            Console.Clear();
            Console.WriteLine("INFORMACION DEL RAZA");

            Console.WriteLine("Identificacion: ");
            raza.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombres: ");
            raza.Nombre = (Console.ReadLine());
            

            var mensaje = servicio.Agregar(raza);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}

using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class VistaPropietario
    {
        ServicioPropietario servicioPropietario;
        public VistaPropietario()
        {
            servicioPropietario = new ServicioPropietario();
        }
        public void MenuPropietario()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 4); Console.WriteLine("G E S T I O N  P R O P I E T A R I O S");
                Console.SetCursorPosition(20, 6); Console.WriteLine("1. Agregar Propietario");
                Console.SetCursorPosition(20, 8); Console.WriteLine("2. Buscar Propietario");
                Console.SetCursorPosition(20, 10); Console.WriteLine("3. Actializar Propietario");
                Console.SetCursorPosition(20, 12); Console.WriteLine("4. Eliminar Propietario");
                Console.SetCursorPosition(20, 14); Console.WriteLine("5. Consultar Propietarios");

                Console.SetCursorPosition(20, 16); Console.WriteLine("0. Salir");

                Console.SetCursorPosition(20, 20); Console.WriteLine("Seleccione una opción: ");
                Console.SetCursorPosition(44, 20); opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CapturarPropietario();
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
            Console.SetCursorPosition(12, 3); Console.WriteLine("L I S T A D O  D E  P R O P I E T A R I O S");
            Console.SetCursorPosition(15, 5); Console.Write("-------------------------------------------");
            Console.SetCursorPosition(15, 6); Console.WriteLine("ID");
            Console.SetCursorPosition(28, 6); Console.WriteLine("NOMBRE");
            Console.SetCursorPosition(40, 6); Console.WriteLine("TELEFONO");

            foreach (var item in servicioPropietario.ObtenerTodas())
            {
                Console.SetCursorPosition(15, 8 + salto); Console.Write(item.Id);
                Console.SetCursorPosition(28, 8 + salto); Console.Write(item.Nombre);
                Console.SetCursorPosition(40, 8 + salto); Console.Write(item.Telefono);
                Console.SetCursorPosition(15, 9 + salto); Console.Write("-------------------------------------------");
                salto++;
            }
            Console.ReadKey();
        }

        private void CapturarPropietario()
        {
            Propietario propietario = new Propietario();
            Console.Clear();
            Console.WriteLine("INFORMACION DEL PROPIETARIO");

            Console.WriteLine("Identificacion: ");
            propietario.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nombres: ");
            propietario.Nombre = (Console.ReadLine());
            Console.WriteLine("Telefono: ");
            propietario.Telefono = (Console.ReadLine());

            var mensaje = servicioPropietario.Agregar(propietario);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}

using BLL;
using ENTITY;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class VistaVeterinario
    {
        ServicioVeterinario servicioVeterinario;
        public VistaVeterinario()
        {
            servicioVeterinario = new ServicioVeterinario();
        }
        public void MenuVeterinarios()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Gestionar Veterinarios");
                Console.WriteLine("1. Agregar Veterinario");
                Console.WriteLine("2. Buscar Veterinarios");
                Console.WriteLine("3. Actualizar Veterinario");
                Console.WriteLine("4. Eliminar Veterinario");
                Console.WriteLine("5. Listar Veterinarios");

                Console.WriteLine("0. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarVeterinario();
                        break;
                    case 2:
                        BuscarVeterinario();
                        break;
                    case 3:
                        // Lógica para actualizar veterinario
                        break;
                    case 4:
                        // Lógica para eliminar veterinario
                        break;
                    case 5:
                        // Lógica para listar veterinarios
                        ListarVeterinarios();
                        break;
                    default:
                        break;
                }

            } while (opcion != 0);
            
        }

        private void ListarVeterinarios()
        {
            int salto = 0;

            Console.Clear();
            Console.SetCursorPosition(12, 3); Console.Write("L I S T A D O  D E  V E T E R I N A R I O S");
            Console.SetCursorPosition(15, 6); Console.Write("-------------------------------------------");
            Console.SetCursorPosition(15, 7); Console.Write("ID");
            Console.SetCursorPosition(28, 7); Console.Write("NOMBRE");
            Console.SetCursorPosition(42, 7); Console.Write("TELEFONO");
            Console.SetCursorPosition(15, 8); Console.Write("-------------------------------------------");
            foreach (var item in servicioVeterinario.ObtenerTodas())
            {
                Console.SetCursorPosition(15, 9 + salto); Console.Write(item.Id);
                Console.SetCursorPosition(28, 9 + salto); Console.Write(item.Nombre);
                Console.SetCursorPosition(43, 9 + salto); Console.Write(item.Telefono);
                Console.SetCursorPosition(15, 10 + salto); Console.Write("-------------------------------------------");
                salto+=2;
            }
            Console.ReadKey();
        }

        private void BuscarVeterinario()
        {
            Console.Clear();
            Console.WriteLine("Buscar Veterinario");

            Console.Write("Ingrese Identificacion del Veterinario: ");
            int id = int.Parse(Console.ReadLine());
            var veterinario = servicioVeterinario.ObtenerPorId(id);
            if (veterinario != null)
            {
                //Console.WriteLine($"ID: {veterinario.Id}");
                Console.WriteLine($"Nombre: {veterinario.Nombre}");
                Console.WriteLine($"Telefono: {veterinario.Telefono}");
            }
            else
            {
                Console.WriteLine("Veterinario no encontrado.");
            }
            Console.ReadKey();
        }

        private void AgregarVeterinario()
        {
            Console.Clear();
            Console.WriteLine("Agregar Nuevo Veterinario");
            Veterinario veterinario = new Veterinario();

            Console.Write("Ingrese Identificacion: ");
            veterinario.Id =int.Parse( Console.ReadLine());
            Console.Write("Ingrese Nombre: ");
            veterinario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Telefono: ");
            veterinario.Telefono = Console.ReadLine();

            var mensaje= servicioVeterinario.Agregar(veterinario);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}

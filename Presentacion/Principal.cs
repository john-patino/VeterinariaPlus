using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Principal
    {
        ServicioPropietario servicio;
        public Principal()
        {
            servicio = new ServicioPropietario();
        }
        public void MenuPrincipal()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(20, 6);  Console.Write("1. Gestion Mascotas ...");
                Console.SetCursorPosition(20, 8);  Console.Write("2. Gestion Propietario ...");
                Console.SetCursorPosition(20, 10); Console.Write("3. Gestion Veterinario ...");
                Console.SetCursorPosition(20, 12); Console.Write("4. Gestion Mascotas ...");
                Console.SetCursorPosition(20, 14); Console.Write("5. Gestion Mascotas ...");
                Console.SetCursorPosition(20, 16); Console.Write("0. Salir");
                Console.SetCursorPosition(17,4);   Console.Write("M E N U   P R I N C I P A L");

                Console.SetCursorPosition(20, 20); Console.Write("Seleccione una opción: ");

                Console.SetCursorPosition(44, 20); opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        
                        break;
                    case 2:
                        VistaPropietario vistaPropietario = new VistaPropietario();
                        vistaPropietario.MenuPropietario();
                        break;
                    case 3:
                        new VistaVeterinario().MenuVeterinarios();

                        break;
                    default:
                        break;
                }

            } while (opcion!=0);
        }
        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Propietario : Persona
    {
        public Propietario()
        {
            
        }
        public Propietario( int id, string nombre, string telefono)
        {
            Id = id;
            Nombre = nombre;
            TelefonoContacto = telefono;
        }

        public override string ToString()
        {
            return $"{Id};{Nombre};{TelefonoContacto}";
        }
    }
}

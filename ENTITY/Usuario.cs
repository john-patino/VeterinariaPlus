using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario : Persona
    {
        public override string Formatear()
        {
            return $"{Id};{Nombre};{TelefonoContacto}";
        }
    }
}

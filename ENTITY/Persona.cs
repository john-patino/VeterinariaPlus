using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        //public DateTime FechaNacimiento { get; set; }

        public abstract string Formatear();// aagrega el ; entre atributos
    }
}

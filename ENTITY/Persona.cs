using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public abstract class Persona: EntidadBase
    {

      

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TelefonoContacto { get; set; }
        //public DateTime FechaNacimiento { get; set; }

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Raza
    {
        public Raza(int id, string nombreRaza)
        {
            Id = id;
            NombreRaza = nombreRaza;
        }

        public int Id { get; set; }
        public string NombreRaza { get; set; }

     
    }
}

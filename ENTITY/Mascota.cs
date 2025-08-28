using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Mascota
    {
        public Mascota()
        {
        }

        public Mascota(int id, string nombreMascota)
        {
            Id = id;
            NombreMascota = nombreMascota;
            
        }

        public int Id { get; set; }
        public string  NombreMascota { get; set; }
        public Raza Raza { get; private set; }
        public void AsignarRaza(Raza raza)
        {
            this.Raza = raza;
        }

    }
}

using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class DemoMascota
    {
        ENTITY.Mascota mascota = new ENTITY.Mascota(1, "firu");
        ENTITY.Mascota mascota1 = new ENTITY.Mascota(2, "firu2");
        ENTITY.Raza raza = new ENTITY.Raza(1,"unica");

        public BLL.ServicioMascota servicio = new BLL.ServicioMascota();

        public DemoMascota()
        {
            mascota.AsignarRaza(raza);
            mascota1.AsignarRaza(raza);
            servicio.Agregar(mascota);
            servicio.Agregar(mascota1);
        }

    }
}

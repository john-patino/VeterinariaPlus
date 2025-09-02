using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Icrud
    {
        string Agregar(Raza raza);
        Raza ObtenerPorId(int id);
        List<Raza> ObtenerTodas();
        bool Actualizar(Raza raza);
        bool Eliminar(int id);
    }
}

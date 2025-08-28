using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrudMascota
    {
        // Crear
        string Agregar(Mascota mascota);

        // Leer (uno)
        Mascota ObtenerPorId(int id);

        // Leer (todos)
        List<Mascota> ObtenerTodas();

        // Actualizar
        bool Actualizar(Mascota mascota);

        // Eliminar
        bool Eliminar(int id);
    }
}

using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrudVeterinario
    {
        string Agregar(Veterinario veterinario);
        Veterinario ObtenerPorId(int id);
        List<Veterinario> ObtenerTodas();
        bool Actualizar(Veterinario veterinario);
        bool Eliminar(int id);
    }
}

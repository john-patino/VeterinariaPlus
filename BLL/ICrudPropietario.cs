using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICrudPropietario
    {   
        string Agregar(Propietario propietario );              
        Propietario ObtenerPorId(int id);
        List<Propietario> ObtenerTodas();
        bool Actualizar(Propietario propietario);
        bool Eliminar(int id);
    }
}

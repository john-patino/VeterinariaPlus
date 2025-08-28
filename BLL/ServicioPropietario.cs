using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPropietario : ICrudPropietario
    {
        List<Propietario> propietarios;

        public ServicioPropietario()
        {
            propietarios = new List<Propietario>();
        }

        public bool Actualizar(Propietario propietario)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Propietario propietario)
        {
            //validar
            propietarios.Add(propietario);
            return $"se guardo el propiestario con el nombre :{propietario.Nombre}";
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Propietario ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Propietario> ObtenerTodas()
        {
            return propietarios;
        }
    }
}

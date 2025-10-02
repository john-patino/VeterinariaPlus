using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioPropietario : ENTITY.ICrud<Propietario>
    {
        List<Propietario> propietarios;
        PropietarioRepository propietarioRepository;

        public ServicioPropietario()
        {
            propietarioRepository = new PropietarioRepository();
            propietarios = propietarioRepository.ObtenerTodas();
        }

        public bool Actualizar(Propietario propietario)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Propietario propietario)
        {
            //validar
            var mensaje = propietarioRepository.Agregar(propietario);
            propietarios = propietarioRepository.ObtenerTodas();
            return mensaje;
           
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Propietario ObtenerPorId(int id)
        {
            return propietarios.FirstOrDefault<Propietario>(x => x.Id == id);
        }

        public List<Propietario> ObtenerTodas()
        {
            return propietarios;
        }
    }
}

using ENTITY;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioRaza //: ICrudRaza
    {
        IList<Raza> razas;
        RazaRepository razaRepository;
        public ServicioRaza()
        {
            razaRepository = new RazaRepository();
            razas = razaRepository.ObtenerTodas();
        }
        public bool Actualizar(Raza raza)
        {
            var razaEncontrada = ObtenerPorId(raza.Id);
            if (razaEncontrada != null)
            {
                razaEncontrada.Nombre = raza.Nombre;
                return true;
            }   

            return false;
        }

        public string Agregar(Raza raza)
        {
            //if (razas.Exists(r => r.NombreRaza == raza.NombreRaza))
            //{
            //    return $"La raza con el nombre {raza.NombreRaza} ya existe.";
            //}
            var mensaje= razaRepository.Agregar(raza);
            razas = razaRepository.ObtenerTodas();
            return mensaje;
        }

        public bool Eliminar(int id)
        {
            foreach (var raza in razas)
            {
                if (raza.Id == id)
                {
                    razas.Remove(raza);
                    return true;
                }
            }
            return false;
        }

        public Raza ObtenerPorId(int id)
        {
            foreach (var raza in razas)
            {
                if (raza.Id == id)
                {
                    return raza;
                }
            }
            return null;
        }

        public IList<Raza> ObtenerTodas()
        {
            return razas;
        }
    }
}

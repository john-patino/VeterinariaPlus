using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioRaza : ICrudRaza
    {
        List<Raza> razas;
        public ServicioRaza()
        {
            razas = new List<Raza>();
        }
        public bool Actualizar(Raza raza)
        {
            var razaEncontrada = ObtenerPorId(raza.Id);
            if (razaEncontrada != null)
            {
                razaEncontrada.NombreRaza = raza.NombreRaza;
                return true;
            }   

            return false;
        }

        public string Agregar(Raza raza)
        {
            if (razas.Exists(r => r.NombreRaza == raza.NombreRaza))
            {
                return $"La raza con el nombre {raza.NombreRaza} ya existe.";
            }
            razas.Add(raza);
            return $"Se guardo la raza con el nombre: {raza.NombreRaza}";
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

        public List<Raza> ObtenerTodas()
        {
            return razas;
        }
    }
}

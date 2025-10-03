using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace BLL
{
    public class ServicioMascota : ICrudMascota
    {
        DAL.MascotaRepository mascotaRepository = new DAL.MascotaRepository();
        List<Mascota> mascotas = new List<Mascota>();
        public bool Actualizar(Mascota mascota)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Mascota mascota)
        {
            //validar
            if (mascota== null)
            {
                return "la mascota no puede ser nula";
            }
            try
            {
                var msg= mascotaRepository.Agregar(mascota);
                mascotas.Add(mascota);
                return msg;
            }
            catch (Exception)
            {
                return "Error al guardar la mascota";
            }
            
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Mascota ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mascota> ObtenerTodas()
        {
            return mascotas;
        }
    }
}

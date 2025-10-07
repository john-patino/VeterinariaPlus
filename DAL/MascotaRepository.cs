using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
namespace DAL
{
    public class MascotaRepository : ICrudLectura<Mascota>, ICrudEscritura<Mascota>
    {
        string ruta = "mascotas.txt";
        public bool Actualizar(Mascota entity)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Mascota entity)
        {

            try
            {
                //1
                StreamWriter sw = new StreamWriter(ruta, true);
                //2
                sw.WriteLine($"{entity.Id};{entity.NombreMascota}:{entity.Raza.Id}");
                // cerrar
                sw.Close();
                return $" se guardo la raza {entity.NombreMascota}";
            }
            catch (Exception ex)
            {
                return "error al guardar ..." + "\n" + ex.Message;
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

        public IList<Mascota> ObtenerTodas()
        {
            throw new NotImplementedException();
        }
    }
}

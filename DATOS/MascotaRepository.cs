using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTITY;
namespace DAL
{
    public class MascotaRepository : RepositorioBase<Mascota>
    {
        string ruta = "mascotas.txt";

        RazaRepository razaRepository = new RazaRepository();

        public bool Actualizar(Mascota entity)
        {
            try
            {
                var mascota = ObtenerPorId(entity.Id);
                mascota.Nombre = entity.Nombre;
                mascota.AsignarRaza(entity.Raza);
                Actualizar(Consultar());
                return true;
            }
            catch (Exception)
            {

                return  false;
            }


        }
        public bool Actualizar(IList<Mascota> lista)
        {
            try
            {
                StreamWriter sw = new StreamWriter(ruta);
                foreach (var item in lista)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
                return true;
               
            }
            catch (Exception)
            {
                throw new Exception("error al actualizar el archivo");
            }

        }

        

        public bool Eliminar(int id)
        {
            var lista = Consultar();
            lista.Remove(ObtenerPorId(id));
            return Actualizar(lista);
        }

        public Mascota ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Mascota>(x => x.Id == id);

            //foreach (var item in ObtenerTodas())
            //{
            //    if (item.Id==id)
            //    {
            //        return item;
            //    }
            //}
            //return null;
        }

        public override IList<Mascota> Consultar()
        {
            try
            {
                IList<Mascota> lista = new List<Mascota>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mappear(sr.ReadLine()));

                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Mascota Mappear1(string linea)
        {
            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(linea.Split(';')[0]);
            mascota.Nombre = linea.Split(';')[1];
            var idRaza= int.Parse(linea.Split(';')[3]);
            var raza= razaRepository.ObtenerPorId(idRaza);
            mascota.AsignarRaza(raza);
            return mascota;
        }

        private Mascota Mappear(string linea)
        {
            if (string.IsNullOrWhiteSpace(linea))
                throw new ArgumentException("La línea no puede estar vacía.");

            var partes = linea.Split(';');

            if (partes.Length < 4)
                throw new FormatException("La línea no tiene el formato esperado.");

            int idMascota;
            int idRaza;

            if (!int.TryParse(partes[0], out idMascota))
                throw new FormatException("El ID de la mascota no es válido.");

            if (!int.TryParse(partes[3], out idRaza))
                throw new FormatException("El ID de la raza no es válido.");

            var mascota = new Mascota(idMascota, partes[1]);

            var raza = razaRepository.ObtenerPorId(idRaza);
            if (raza == null)
                throw new InvalidOperationException($"No se encontró la raza con ID {idRaza}.");

            mascota.AsignarRaza(raza);

            return mascota;
        }

    }
}

using ENTITY;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropietarioRepository: ICrudLectura<Propietario>, ICrudEscritura<Propietario>
    {
        private string ruta="propietario.txt";

        public bool Actualizar(Propietario entity)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Propietario entity)
        {
            try
            {
                //1
                StreamWriter escritor = new StreamWriter(ruta, true);
                //2
                escritor.WriteLine($"{entity.Id};{entity.Nombre};{entity.TelefonoContacto}");
                //3
                escritor.Close();
                return $"se guardo el propietario {entity.Nombre}";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Propietario ObtenerPorId(int id)
        {
            return ObtenerTodas().FirstOrDefault<Propietario>(x => x.Id == id);
        }

        public IList<Propietario> ObtenerTodas()
        {
            try
            {
                List<Propietario> lista = new List<Propietario>();
                StreamReader lector = new StreamReader(ruta);
             
                while (! lector.EndOfStream)
                {
                    lista.Add(Mappear(lector.ReadLine()));
                }
                lector.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        private Propietario Mappear(string linea)
        {
            Propietario propietario = new Propietario();
            //var aux = linea.Split(';');

            propietario.Id = int.Parse(linea.Split(';')[0]);
            propietario.Nombre = linea.Split(';')[1];
            propietario.TelefonoContacto = linea.Split(';')[2];
            return propietario;
        }
    }
}

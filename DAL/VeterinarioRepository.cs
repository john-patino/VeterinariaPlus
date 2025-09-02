using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeterinarioRepository: ICrud<Veterinario>
    {
        private string ruta="veterinario.txt";

        public bool Actualizar(Veterinario entity)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Veterinario entity)
        {
            try
            {
                //1
                StreamWriter escritor = new StreamWriter(ruta,true);
                //2
                escritor.WriteLine(entity.Formatear());
                //3
                escritor.Close();
                return $"se guardo el veterinario {entity.Nombre}";
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

        public Veterinario ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Veterinario> ObtenerTodas()
        {
            try
            {
                StreamReader lector = new StreamReader(ruta);
                List<Veterinario> lista = new List<Veterinario>();

                while (!lector.EndOfStream)
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

        private Veterinario Mappear(string linea)
        {
            Veterinario veterinario = new Veterinario();

            var aux = linea.Split(';');

            veterinario.Id = int.Parse(aux[0]);
            veterinario.Nombre = aux[1];
            veterinario.Telefono = aux[2];

            return veterinario;
        }

               
    }
}

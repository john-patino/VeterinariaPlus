using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VeterinarioRepository: ICrudLectura<Veterinario>
    {
        private string ruta="veterinario.txt";

        public bool Actualizar(Veterinario entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            if (!File.Exists(ruta)) return false;

            try
            {
                var lineas = File.ReadAllLines(ruta).ToList();
                var actualizado = false;

                for (int i = 0; i < lineas.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                    var v = Mappear(lineas[i]);
                    if (v.Id == entity.Id)
                    {
                        lineas[i] = entity.Formatear(); // reemplaza la línea
                        actualizado = true;
                        break;
                    }
                }

                if (actualizado)
                {
                    File.WriteAllLines(ruta, lineas);
                }

                return actualizado;
            }
            catch
            {
                return false;
            }
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
            if (!File.Exists(ruta)) return false;

            try
            {
                var lineas = File.ReadAllLines(ruta).ToList();
                int antes = lineas.Count;

                // Elimina TODAS las líneas cuyo primer campo (Id) coincida
                lineas = lineas
                    .Where(l =>
                    {
                        if (string.IsNullOrWhiteSpace(l)) return false; // descarta vacías
                        var f = l.Split(';');
                        return !(f.Length > 0 && int.TryParse(f[0], out var lid) && lid == id);
                    })
                    .ToList();

                if (lineas.Count == antes) return false; // no encontró el id

                File.WriteAllLines(ruta, lineas);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Veterinario ObtenerPorId(int id)
        {
            return ObtenerTodas().FirstOrDefault<Veterinario>(x => x.Id == id);
        }

        public IList<Veterinario> ObtenerTodas()
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
            veterinario.TelefonoContacto = aux[2];

            return veterinario;
        }

               
    }
}

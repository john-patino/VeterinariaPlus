using ENTITY;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepo : ICrudLectura<Usuario>, ICrudEscritura<Usuario>
    {
        string ruta = "usuario.txt";

        public bool Actualizar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Usuario entity)
        {

            try
            {
                //1
                StreamWriter sw = new StreamWriter(ruta, true);
                //2
                sw.WriteLine(entity.ToString());
                // cerrar
                sw.Close();
                return $" se guardo la raza {entity.Nombre}";
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

        public Usuario ObtenerPorId(int id)
        {
            return ObtenerTodas().FirstOrDefault<Usuario>(x => x.Id == id);
        }

        public IList<Usuario> ObtenerTodas()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                StreamReader lector = new StreamReader(ruta);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    lista.Add(MapearUsuario(linea));
                }
                lector.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Usuario MapearUsuario(string linea)
        {
            //   1;unica

            Usuario usuario = new Usuario();

            var aux = linea.Split(';');

            usuario.Id = int.Parse(aux[0]);

            usuario.Nombre = aux[1];

            return usuario;
            //raza.Id = int.Parse(linea.Split(';')[0]);
        }
    }
}

using DATOS;
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
    public class UsuarioRepo:RepositorioBase<Usuario>
    {
        string ruta = "usuario.txt";

       

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Usuario>(x => x.Id == id);
        }

        public override IList<Usuario> Consultar()
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

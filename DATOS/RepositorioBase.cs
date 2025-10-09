using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public abstract class RepositorioBase<T>
    {
        protected string _ruta;
        protected RepositorioBase()
        {

        }
        protected RepositorioBase(string ruta)
        {
            _ruta = ruta;
        }
        public string Guardar(T entidad)
        {

            try
            {
                //1
                StreamWriter escritor = new StreamWriter(_ruta, true);
                //2
                escritor.WriteLine($"{entidad.ToString()}");
                //3
                escritor.Close();
                return $"se guardo la entidad";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public abstract IList<T> Consultar();
    }
}

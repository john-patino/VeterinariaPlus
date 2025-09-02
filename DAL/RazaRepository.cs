using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DAL
{
    public class RazaRepository : Icrud
    {
        string ruta = "Raza.txt";
        public bool Actualizar(Raza raza)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Raza raza)
        {
            try
            {
                //1
                StreamWriter sw = new StreamWriter(ruta,true);
                //2
                sw.WriteLine($"{raza.Id};{raza.NombreRaza}");
                // cerrar
                sw.Close();
                return $" se guardo la raza {raza.NombreRaza}";
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

        public Raza ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Raza> ObtenerTodas()
        {
            List<Raza> listaRazas = new List<Raza>();
            try
            {
                StreamReader lector = new StreamReader(ruta);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    listaRazas.Add(MapearRaza(linea));
                }
                lector.Close();
                return listaRazas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private Raza MapearRaza(string linea)
        {
            //   1;unica

            Raza raza = new Raza();

            var aux = linea.Split(';');

            raza.Id = int.Parse(aux[0]);

            raza.NombreRaza = aux[1];

            return raza;
                 //raza.Id = int.Parse(linea.Split(';')[0]);
        }
    }
}

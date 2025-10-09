using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DATOS
{
    public class RazaRepository : RepositorioBase<Raza>
    {
        public override IList<Raza> Consultar()
        {
            List<Raza> listaRazas = new List<Raza>();
            try
            {
                StreamReader lector = new StreamReader(_ruta);
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

        internal Raza ObtenerPorId(int id)
        {
            return Consultar().FirstOrDefault<Raza>(x => x.Id == id);
        }

        private Raza MapearRaza(string linea)
        {
            //   1;unica

            Raza raza = new Raza();

            var aux = linea.Split(';');

            raza.Id = int.Parse(aux[0]);

            raza.Nombre = aux[1];

            return raza;
            //raza.Id = int.Parse(linea.Split(';')[0]);
        }
    }
}

using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioVeterinario : ICrudVeterinario
    {
        List<Veterinario> listaVeterinarios;
        public ServicioVeterinario()
        {
            listaVeterinarios = new List<Veterinario>();
        }
        public bool Actualizar(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Veterinario veterinario)
        {
            //validar
            listaVeterinarios.Add(veterinario);
            return $"Veterinario agregado con el nombre {veterinario.Nombre}";
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Veterinario ObtenerPorId(int id)
        {
            foreach (var item in listaVeterinarios)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Veterinario> ObtenerTodas()
        {
            return listaVeterinarios;
        }
    }
}

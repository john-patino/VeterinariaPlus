using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioVeterinario : ICrud<Veterinario>
    {
        List<Veterinario> listaVeterinarios;
        VeterinarioRepository veterinarioRepository;
        public ServicioVeterinario()
        {
            veterinarioRepository = new VeterinarioRepository();
            listaVeterinarios = veterinarioRepository.ObtenerTodas();
        }
        public bool Actualizar(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public string Agregar(Veterinario veterinario)
        {
            //validar
           var mensaje= veterinarioRepository.Agregar(veterinario);
            listaVeterinarios = veterinarioRepository.ObtenerTodas();
            return mensaje;
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

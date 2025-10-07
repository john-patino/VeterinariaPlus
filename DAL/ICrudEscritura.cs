using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public interface ICrudEscritura<T>
    {
        string Agregar(T entity);
        bool Actualizar(T entity);
        bool Eliminar(int id);

       
        
        
       
    }
}

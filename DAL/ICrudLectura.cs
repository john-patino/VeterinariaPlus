using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public interface ICrudLectura<T>
    {
     
        T ObtenerPorId(int id);
        IList<T> ObtenerTodas();
       
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    internal interface IGestor<T>
    {
        bool Guardar(T Objeto);
        bool Baja(T Objeto);

        List<T> ListarTodo();
        T ListarObjeto(T Objeto);
    }
}

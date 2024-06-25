using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    public class ProductoNoEncontrado:Exception
    {
        public override string Message
        {
            get { return "Producto no encontrado"; }
        }
    }
}

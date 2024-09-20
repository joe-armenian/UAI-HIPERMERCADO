using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProductoNoEncontrado:Exception
    {
        public override string Message
        {
            get { return "Producto no encontrado"; }
        }
    }
}

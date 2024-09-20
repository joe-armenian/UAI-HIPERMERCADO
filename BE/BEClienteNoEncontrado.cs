using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEClienteNoEncontrado:Exception
    {
        public override string Message
        {
            get { return "Cliente no encontrado"; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    public class ClienteNoEncontrado:Exception
    {
        public override string Message
        {
            get { return "Cliente no encontrado";}
        }
    }
}

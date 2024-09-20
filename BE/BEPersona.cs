using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEPersona
    {
        public int Codigo { get; set; }
        public Int64 CUIT { get; set; }

        public double totalSimpuesto;

    }

   
}

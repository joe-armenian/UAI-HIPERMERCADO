using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    public interface ITCalculable
    {
        double CalcularTotalSinImpuesto(List<Producto> productos);
        double Total { get; set; }


    }
}

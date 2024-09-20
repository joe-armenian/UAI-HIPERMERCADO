using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public abstract class BLLPersona
    {
        public abstract double CalcularImpuestoPais(List<BEProducto> oBEProductos);

        public abstract double CalcularPrecioNormal(List<BEProducto> oBEProductos);
        public abstract double CalcularPrecioCompra(List<BEProducto> oBEProductos);



        public virtual long retonarCuit(BEPersona oBEPersona)
        {
            return oBEPersona.CUIT;
        }
    }
}

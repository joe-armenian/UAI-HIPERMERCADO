using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    public abstract class Persona
    {


        #region Propiedades

        public Int64 CUIT { get; set; }

        public double totalSimpuesto;

        

        #endregion



        #region Metodos
        public abstract double CalcularImpuestoPais(List<Producto> productos);

        public virtual long retonarCuit()
        {
            return CUIT;
        }

        #endregion

    }
}

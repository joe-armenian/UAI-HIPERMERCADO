using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    public class PersonaPyme : Persona,ITCalculable
    {
        #region Propiedades
        public string RazonSocial { get; set; }
        #endregion
        #region Metodos
      
        double ITCalculable.Total
        {
            get { return totalSimpuesto; }
            set { totalSimpuesto = value; }
        }
        double ITCalculable.CalcularTotalSinImpuesto(List<Producto> productos)
        {
            double totalSinImpuesto = 0;

            foreach (Producto producto in productos)
            {
                totalSinImpuesto += producto.Precio * producto.Cantidad;
            }

            this.totalSimpuesto = totalSinImpuesto;

            return totalSinImpuesto;
        }
        public override double CalcularImpuestoPais(List<Producto> productos)
        {
            double totalImpuesto = 0;

            foreach (Producto producto in productos)
            {
                totalImpuesto += producto.Precio * producto.Cantidad;
            }

            return totalImpuesto * 0.5;
        }
        public override long retonarCuit()
        {
            return base.retonarCuit();
        }
        public override string ToString()
        {
            return ($"{RazonSocial} {CUIT}");
        }
        #endregion 







    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    namespace Facturacion
    {
        public class Factura
        {
            #region Propiedades



            int randomID = new Random().Next(1, 500);

            public string Estado { get; set; }


            public int CodFactura { set { randomID = value; } }


            public DateTime FechaFactura { get => DateTime.Now; }


            public List<Producto> ListaProductos = new List<Producto>(); 
            public Persona Persona { get; set; }
            #endregion

            #region Constructores

            public Factura() { }

            public Factura(Persona persona, string estado)
            {
                this.Persona = persona;
                this.Estado = estado;
            }

            #endregion



            #region Metodos

            public override string ToString()
            {
                return $"{FechaFactura}"; 
            }

            #endregion


        }

    }
}

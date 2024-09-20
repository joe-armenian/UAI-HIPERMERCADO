using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFactura
    {

        #region Propiedades


        //int randomID = new Random().Next(1, 500);

        public int Codigo { get; set; }

        public DateTime FechaFactura { get; set; }
        public string Estado { get; set; }

        public BEPersona Persona { get; set; }

        // public int CodFactura { set { randomID = value; } }


        public List<BEProducto> ListaProductos { get; set; }

       

        public BEFactura() { }

        public BEFactura(BEPersona persona, string estado)
        {
            this.Persona = persona;
            this.Estado = estado;
        }

        public override string ToString()
        {
            return $"{FechaFactura}";
        }
        #endregion
    }
}

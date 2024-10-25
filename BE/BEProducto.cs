using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEProducto:BEEntidad
    {
        #region Propiedades
       // public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public int Cantidad { get; set; }
        #endregion

        public BEProducto()
        { }

        public BEProducto(int codigo, string nombre, int precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"Codigo:{this.Codigo} Nombre:{this.Nombre} Precio:{this.Precio} Cantidad:{this.Cantidad}";
        }


    }

}

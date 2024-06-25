using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAI_HIPERMERCADO
{
    public class Producto:ICloneable
    {
        #region Propiedades
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public int Cantidad { get; set; }
        #endregion

        #region Metodos

        public object Clone()
        {    
            return this.MemberwiseClone();

        }

        public override string ToString()
        {
            return ($"Codigo: {Codigo} - Nombre: {Nombre} - Precio: {Precio} Cantidad {Cantidad}");
        }

        public double CalcularTotalCompra()
        {
            return Precio * Cantidad;
        }

        #endregion



        #region Constructores
        public Producto()
        { }

        public Producto(int codigo, string nombre, double precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        #endregion



    }
}

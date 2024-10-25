using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;
using Abstraccion;

namespace BLL
{
    public class BLLPersonaPyme:BLLPersona,IGestor<BEPersonaPyme>
    {

        MPPyme oMPPyme;
        public BLLPersonaPyme()
        {
            oMPPyme = new MPPyme(); 
        }

        public List<BEPersonaPyme> ListarTodo()
        {
            return oMPPyme.ListarTodo();
        }

        public bool Guardar(BEPersonaPyme oBePyme)
        {
            return oMPPyme.Guardar(oBePyme);
        }
        public bool Baja(BEPersonaPyme oBePyme)
        {
            return oMPPyme.Baja(oBePyme);
        }
       public BEPersonaPyme ListarObjeto(BEPersonaPyme oBePyme)
        {
            throw new NotImplementedException();
        }
        
        
        public override double CalcularImpuestoPais(List<BEProducto> oBEproductos)
        {
            double totalImpuesto = 0;

            foreach (BEProducto oBEproducto in oBEproductos)
            {
                totalImpuesto += oBEproducto.Precio * oBEproducto.Cantidad;
            }

            return totalImpuesto * 0.5;
        }

        public override double CalcularPrecioNormal(List<BEProducto> oBEProductos)
        {
            double totalNormal = 0;

            foreach (BEProducto oBEproducto in oBEProductos)
            {
                totalNormal += oBEproducto.Precio * oBEproducto.Cantidad;
            }

            return totalNormal;
        }

        public override double CalcularPrecioCompra(List<BEProducto> oBEProductos)
        {
            double recuperarImpuestos = 0;
            BLLPersonaPyme oBLL = new BLLPersonaPyme();
            recuperarImpuestos = oBLL.CalcularImpuestoPais(oBEProductos);

            double totalPrecio = 0;


            foreach (BEProducto oBEproducto in oBEProductos)
            {
                totalPrecio += oBEproducto.Precio * oBEproducto.Cantidad;
            }

            return totalPrecio + recuperarImpuestos;
        }
        public override long retonarCuit(BEPersona oBEPersona)
        {
            return base.retonarCuit(oBEPersona);
        }




    }
}

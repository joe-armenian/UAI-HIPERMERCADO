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
    public class BLLPersonaIndividuo:BLLPersona,IGestor<BEPersonaIndividuo>
    {
        MPPIndividuo oMPPIndividuo;

        public BLLPersonaIndividuo()
        {
            oMPPIndividuo=new MPPIndividuo();
        }


        public List<BEPersonaIndividuo> ListarTodo()
        {
            return oMPPIndividuo.ListarTodo();
        }

        public bool Guardar(BEPersonaIndividuo oBePersonaIndividuo)
        {
            return oMPPIndividuo.Guardar(oBePersonaIndividuo);
        }
        public bool Baja(BEPersonaIndividuo oBePersonaIndividuo)
        {
            return oMPPIndividuo.Baja(oBePersonaIndividuo);
        }
        public BEPersonaIndividuo ListarObjeto(BEPersonaIndividuo oBePersonaIndividuo)
        {
            throw new NotImplementedException();
        }

        public override double CalcularImpuestoPais(List<BEProducto> oBEProductos)
        {
            double totalImpuesto = 0;

            foreach ( BEProducto oBEproducto in oBEProductos)
            {
                totalImpuesto += oBEproducto.Precio * oBEproducto.Cantidad;
            }

            return totalImpuesto * 0.1;
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
            BLLPersonaIndividuo oBLL = new BLLPersonaIndividuo();
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

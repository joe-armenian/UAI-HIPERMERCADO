using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using System.CodeDom;

namespace BLL
{
    public class BLLProducto : IGestor<BEProducto>
    {
        MPPProduct OMPProd;
        public BLLProducto()
        {
            OMPProd = new MPPProduct();
        }
        public double CalcularTotalCompra(BEProducto oBEProducto)
        {
            return oBEProducto.Precio * oBEProducto.Cantidad;
        }
        public List<BEProducto> ListarTodo()
        {
            return OMPProd.ListarTodo();
        }

        public bool Guardar(BEProducto oBEProducto)
        {
            return OMPProd.Guardar(oBEProducto);
        }

        public bool Baja(BEProducto oBEProducto)
        {
            return OMPProd.Baja(oBEProducto);
        }

        public BEProducto ListarObjeto(BEProducto oBEProducto)
        {

            throw new NotImplementedException();
        }
    }
}

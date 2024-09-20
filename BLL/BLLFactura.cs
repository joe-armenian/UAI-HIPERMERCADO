using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MPP;
using BE;


namespace BLL
{
    public class BLLFactura:IGestor<BEFactura>
    {
        MPPFactura oMPPFactura;

        public BLLFactura() 
        {
            oMPPFactura= new MPPFactura();  
        }

        public List<BEFactura> ListarTodo()
        {
            return oMPPFactura.ListarTodo();
        }
        public bool AsociarProducto(BEFactura oBeFactura, BEProducto oBEProducto)
        {
            return oMPPFactura.AsociarProducto(oBeFactura, oBEProducto);
        }
        public bool Guardar(BEFactura OBEFactura)
        {
            return oMPPFactura.Guardar(OBEFactura);   
        }
        public bool Baja (BEFactura OBEFactura)
        {
            throw new NotImplementedException();
        }

        public bool FacturaAbonada(BEFactura oBEFactura)
        {
            return oMPPFactura.FacturaAbonada(oBEFactura);
        }

        public BEFactura ListarObjeto(BEFactura oBEFacutra)
            { throw new NotImplementedException(); }    
    }
}

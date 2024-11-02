using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLInforme
    {
        MPPInformes oMPPInfores;

        public BLLInforme() {
            oMPPInfores = new MPPInformes();
        }

        public List<BEResumenInformes> LeerXML()
        {
            return oMPPInfores.LeerXML();

        }

        public void AgregarXML(BEResumenInformes resumen)
        {
            oMPPInfores.AgregarXML(resumen);
        }

        public void BajaXML(BEResumenInformes resumen)
        {
            oMPPInfores.BajaXML(resumen);
        }

        public void ModificarXML(BEResumenInformes resumen)
        {
            oMPPInfores.ModificarXML(resumen);  
        }



    }
}

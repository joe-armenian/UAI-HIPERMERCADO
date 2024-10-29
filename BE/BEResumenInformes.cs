using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEResumenInformes
    {
        public string Descripcion { get; set; }
        public string FechaReferencia { get; set; }
        public int FacturasEmitidas { get; set; }
        public int FacturasAbonadas { get; set; }
        public int ProductosEnStock { get; set; }
        public int PymesRegistradas { get; set; }
        public int IndividuosRegistrados { get; set; }
        public double TotalRecaudado { get; set; }

        public override string ToString()
        {
            return $"Descripcion:{Descripcion}\n FechaReferencia:{FechaReferencia}\n  FacturasE:{FacturasEmitidas}\n FacturasA:{FacturasAbonadas}\n ProductosSTOCK: {ProductosEnStock}\n PymesRegistradas:{PymesRegistradas}\n IndividuosRegistrados:{IndividuosRegistrados}\n TotalRecaudado:{TotalRecaudado}";
        }



    }
}

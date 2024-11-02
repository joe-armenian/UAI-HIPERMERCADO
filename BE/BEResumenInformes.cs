using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEResumenInformes:BEEntidad
    {
        public string Descripcion { get; set; }
        public string FechaReferencia { get; set; }
        public int FacturasEmitidas { get; set; }
        public int FacturasAbonadas { get; set; }
        public int ProductosEnStock { get; set; }
        public int PymesRegistradas { get; set; }
        public int IndividuosRegistrados { get; set; }
        public int TotalRecaudado { get; set; }

       



    }
}

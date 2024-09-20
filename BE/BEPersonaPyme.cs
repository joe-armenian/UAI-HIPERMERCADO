using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPersonaPyme:BEPersona
    {

        #region Propiedades
        public string RazonSocial { get; set; }

        #endregion

        public override string ToString()
        {
            return ($"{RazonSocial} {CUIT}");
        }
    }
}

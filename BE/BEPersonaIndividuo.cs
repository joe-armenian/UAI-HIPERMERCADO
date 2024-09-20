using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPersonaIndividuo:BEPersona
    {

        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        #endregion
        public override string ToString()
        {
            return ($"{Nombre} {Apellido} {CUIT}");
        }
    }
}

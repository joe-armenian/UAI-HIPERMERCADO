using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BE
{
    public class BEUsuario
    {
        public string Usuario { get; set; }

        public string Contrasenia { get; set; }

        public DataSet ListarDS()
        {
            Datos ODatos = new Datos();
            dynamic consulta = "select * From Usuarios";
            return ODatos.LeerDesconectado(consulta);
        }




    }
}

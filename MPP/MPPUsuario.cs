using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;


namespace MPP
{
    public class MPPUsuario
    {
        Datos oDatos;

        public bool Baja(BEUsuario Objeto)
        {
            if (Objeto.Usuario.Length > 2)
            {
                string Consulta_SQL = "DELETE FROM Usuarios where Codigo = " + Objeto.Usuario + "";
                oDatos = new Datos();
                return oDatos.Escribir(Consulta_SQL);
            }
            else
            { return false; }
        }

        public bool Guardar(BEUsuario oUsuario)
        {
            
            string consulta = string.Empty;

            if (oUsuario.Usuario.Length > 0)
            {
                consulta = string.Format("Insert into Usuarios(Username,Password) values('{0}','{1}')",oUsuario.Usuario,oUsuario.Contrasenia);
            }
            else
            {
                consulta = string.Format("Update Usuarios SET Password='{0}' where Username='{1}')",oUsuario.Contrasenia, oUsuario.Usuario);
            }

            oDatos = new Datos();
            return oDatos.Escribir(consulta);
        }

        public bool ListarObjeto(BEUsuario oUsuario)
        {
            string Consulta =string.Format("Select * from Usuarios where Username='{0}' and Password='{1}'",oUsuario.Usuario,oUsuario.Contrasenia);
            oDatos = new Datos();
            DataTable Tabla = oDatos.Leer(Consulta);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEUsuario oUser = new BEUsuario();
                    oUser.Usuario = (fila["Username"]).ToString();
                    oUser.Contrasenia = (fila["Password"]).ToString();
                    return true;
                }

            }
            return false;
        }

        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class BLLUsuario
    {
        MPPUsuario MPPUsuario;

        public BLLUsuario()
        {
            MPPUsuario = new MPPUsuario();
        }

        public bool Baja(BEUsuario Objeto)
        {
            return MPPUsuario.Baja(Objeto);
        }

        #region "Métodos"
        public bool Guardar(BEUsuario oUsuario)
        {
            return MPPUsuario.Guardar(oUsuario);
        }

        public bool ListarObjeto(BEUsuario oUsuario)
        {
            return MPPUsuario.ListarObjeto(oUsuario);
        }

        public List<BEUsuario> ListarTodo()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

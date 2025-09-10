using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mapper_usuario : Mapper<BE.USUARIO>
    {
        public override void Borrar(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(USUARIO obj)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombreusuario", obj.NombreUsuario));
            parametros.Add(acceso.CrearParametro("@contraseña", obj.Contraseña));
            parametros.Add(acceso.CrearParametro("@salt", obj.Salt));
            acceso.Escribir("USUARIO_AGREGAR", parametros);
            acceso.Cerrar();
        }

        public override List<USUARIO> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(USUARIO objviejo, USUARIO objnuevo)
        {
            throw new NotImplementedException();
        }

        public USUARIO BuscarUsuario(USUARIO user)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", user.NombreUsuario));

            DataTable dt = new DataTable();
            dt = acceso.Leer("USUARIO_BUSCAR", parametros);

            if (dt.Rows.Count > 0)
            {
                BE.USUARIO usuario = new BE.USUARIO();
                usuario.IDUsuario = Convert.ToInt32(dt.Rows[0]["id_usuario"]);
                usuario.NombreUsuario = dt.Rows[0]["usuario"].ToString();
                usuario.Contraseña = dt.Rows[0]["contraseña"].ToString();
                usuario.Salt = dt.Rows[0]["salt"].ToString();
                acceso.Cerrar();
                return usuario;
            }
            else
            {
                acceso.Cerrar();
                return null;
            }
        }
    }
}

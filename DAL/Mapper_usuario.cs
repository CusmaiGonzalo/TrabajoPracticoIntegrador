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
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idus", obj.IDUsuario));
            acceso.Escribir("USUARIO_BORRAR", parametros);
            acceso.Cerrar();
        }

        public override void Insertar(USUARIO obj)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombreusuario", obj.NombreUsuario));
            parametros.Add(acceso.CrearParametro("@contraseña", obj.ObtenerContraseña()));
            parametros.Add(acceso.CrearParametro("@salt", obj.ObtenerSalt()));
            acceso.Escribir("USUARIO_AGREGAR", parametros);
            acceso.Cerrar();
        }

        public override List<USUARIO> Listar()
        {
            acceso.Abrir();
            DataTable dt = new DataTable();
            dt = acceso.Leer("USUARIO_LISTAR");
            List<USUARIO> listaUsuarios = new List<USUARIO>();
            foreach (DataRow dr in dt.Rows)
            {
                BE.USUARIO obj = new BE.USUARIO();
                obj.IDUsuario = int.Parse(dr["id_usuario"].ToString());
                obj.NombreUsuario = dr["usuario"].ToString();
                listaUsuarios.Add(obj);
            }
            acceso.Cerrar();
            return listaUsuarios;
        }

        public override void Modificar(USUARIO objviejo, USUARIO objnuevo)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idus", objviejo.IDUsuario));
            parametros.Add(acceso.CrearParametro("@nombre", objnuevo.NombreUsuario));
            acceso.Escribir("USUARIO_MODIFICAR", parametros);
            acceso.Cerrar();
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
        public void AsignarPermisoAUsuario(USUARIO usr, COMPONENTE permiso)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idus", usr.IDUsuario));
            parametros.Add(acceso.CrearParametro("@idperm", permiso.IDPatente));
            acceso.Escribir("USxPER_AGREGAR_PERMISO", parametros);
            acceso.Cerrar();
        }
    }
}

using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
    }
}

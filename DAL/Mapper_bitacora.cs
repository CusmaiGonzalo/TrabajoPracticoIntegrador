using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mapper_bitacora : Mapper<BE.BITACORA>
    {
        public override void Borrar(BITACORA obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(BITACORA obj)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@detalle", obj.Detalle));
            parametros.Add(acceso.CrearParametro("@tipo", obj.Tipo));
            parametros.Add(acceso.CrearParametro("@fecha", obj.FechaBitacora));
            parametros.Add(acceso.CrearParametro("@user", obj.UserBitacora));
            acceso.Escribir("EVENTO_AGREGAR", parametros);
            acceso.Cerrar();
        }

        public override List<BITACORA> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(BITACORA objviejo, BITACORA objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

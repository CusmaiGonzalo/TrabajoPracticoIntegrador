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
            acceso.Abrir();
            DataTable dt = new DataTable();
            dt = acceso.Leer("EVENTO_LISTAR");
            List<BITACORA> listaBitacoras = new List<BITACORA>();
            foreach (DataRow dr in dt.Rows)
            {
                BE.BITACORA obj = new BE.BITACORA();
                obj.IDBitacora = int.Parse(dr["id_bitacora"].ToString());
                obj.Detalle = dr["detalle"].ToString();
                obj.Tipo = dr["tipo"].ToString();
                obj.FechaBitacora = DateTime.Parse(dr["fechabitacora"].ToString());
                obj.UserBitacora = dr["usuario"].ToString();
                listaBitacoras.Add(obj);
            }
            acceso.Cerrar();
            return listaBitacoras;
        }

        public override void Modificar(BITACORA objviejo, BITACORA objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

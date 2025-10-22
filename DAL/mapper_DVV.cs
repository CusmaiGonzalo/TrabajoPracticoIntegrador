using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mapper_DVV : Mapper<DVV>
    {
        
        public override void Borrar(DVV obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(DVV obj)
        {
            throw new NotImplementedException();
        }

        public override List<DVV> Listar()
        {
            DataTable dt = new DataTable();
            List<DVV> listaDVV = new List<DVV>();
            acceso.Abrir();
            dt = acceso.LeerTablas("sp_verificar_integridad_productos").Tables[1];
            foreach (DataRow dr in dt.Rows)
            {
                BE.DVV obj = new BE.DVV();
                obj.DVVTabla = dr["DVV_almacenado"].ToString();
                obj.Estado = dr["Estado"].ToString();
                listaDVV.Add(obj);
            }
            return listaDVV;
        }

        public override void Modificar(DVV objviejo, DVV objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

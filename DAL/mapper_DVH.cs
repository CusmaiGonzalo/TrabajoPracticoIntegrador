using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mapper_DVH : Mapper<BE.DVH>
    {
        Acceso acceso = new Acceso();

        public override void Borrar(DVH obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(DVH obj)
        {
            throw new NotImplementedException();
        }

        public override List<DVH> Listar()
        {
            DataTable dt = new DataTable();
            List<DVH> listaDVH = new List<DVH>();
            acceso.Abrir();
            dt = acceso.LeerTablas("sp_verificar_integridad_productos").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                BE.DVH obj = new BE.DVH();
                obj.IDProducto = int.Parse(dr["id_producto"].ToString());
                obj.DVHString = dr["DVH_almacenado"].ToString();
                obj.Estado = dr["Estado"].ToString();
                listaDVH.Add(obj);
            }
            return listaDVH;
        }

        public override void Modificar(DVH objviejo, DVH objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

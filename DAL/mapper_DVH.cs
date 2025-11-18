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
            acceso.Cerrar();
            return listaDVH;
        }

        public override void Modificar(DVH objviejo, DVH objnuevo)
        {
            throw new NotImplementedException();
        }
        public List<OBJETO_DVH> ListarDVHs()
        {
            DataTable dt = new DataTable();
            List<OBJETO_DVH> listadvhs = new List<OBJETO_DVH>();
            acceso.Abrir();
            dt = acceso.LeerTablas("SP_Verificar_Integridad_Productos").Tables[0];
            foreach (DataRow dr in dt.Rows)
            { 
                OBJETO_DVH obj = new OBJETO_DVH();
                obj.IDProducto = int.Parse(dr["id_producto"].ToString());
                obj.NombreProducto = dr["producto"].ToString();
                obj.Estado = dr["Estado"].ToString();
                listadvhs.Add(obj);
            }
            acceso.Cerrar();
            return listadvhs;
        }

        public string EstadoTabla()
        {
            DataTable dt = new DataTable();
            string estadoTabla;
            acceso.Abrir();
            dt = acceso.LeerTablas("SP_Verificar_Integridad_Productos").Tables[1];
            estadoTabla = dt.Rows[0]["Estado"].ToString();
            acceso.Cerrar();
            return estadoTabla;
        }
        public void RecalcularTablas()
        {
            acceso.Abrir();
            acceso.Escribir("Actualizar_DVH_Producto");
            acceso.Escribir("Actualizar_DVV_Producto");
            acceso.Cerrar();
        }
    }
}

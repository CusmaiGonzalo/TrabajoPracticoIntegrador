using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mapper_pedido_insumo : Mapper<BE.PEDIDO_INSUMO>
    {
        public override void Borrar(PEDIDO_INSUMO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(PEDIDO_INSUMO obj)
        {
            throw new NotImplementedException();
        }

        public override List<PEDIDO_INSUMO> Listar()
        {
            acceso.Abrir();

            DataTable dt = new DataTable();
            List<PEDIDO_INSUMO> lista = new List<PEDIDO_INSUMO>();

            dt = acceso.Leer("PEDIDO_INSUMO_LISTAR");
            foreach (DataRow dr in dt.Rows)
            {
                PEDIDO_INSUMO p = new PEDIDO_INSUMO();
                p.IdPedido = Convert.ToInt32(dr["id_pedido"]);
                p.Fecha = Convert.ToDateTime(dr["fecha"]);
                p.Total = Convert.ToDecimal(dr["total"]);
                PROVEEDOR prov = new PROVEEDOR();
                prov.IdProveedor = Convert.ToInt32(dr["id_proveedor"]);
                prov.Nombre = dr["nombre"].ToString();
                prov.Direccion = dr["direccion"].ToString();
                p.EmpresaProveedor = prov;
                lista.Add(p);
            }
            return lista;
        }

        public override void Modificar(PEDIDO_INSUMO objviejo, PEDIDO_INSUMO objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

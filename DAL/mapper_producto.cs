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
    public class mapper_producto : Mapper<BE.PRODUCTO>
    {
        public override void Borrar(PRODUCTO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(PRODUCTO obj)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@prod", obj.NombreProducto));
            parametros.Add(acceso.CrearParametro("@tipo", obj.TipoProducto));
            parametros.Add(acceso.CrearParametro("@precio", obj.PrecioUnitario));
            acceso.Escribir("PRODUCTO_INSERTAR", parametros);
            acceso.Escribir("Actualizar_DVH_Producto");
            acceso.Escribir("Actualizar_DVV_Producto");
            acceso.Cerrar();
        }

        public override List<PRODUCTO> Listar()
        {
            acceso.Abrir();
            DataTable dt = new DataTable();
            dt = acceso.Leer("PRODUCTO_LISTAR");
            List<PRODUCTO> listaProductos = new List<PRODUCTO>();
            foreach (DataRow dr in dt.Rows) 
            {
                BE.PRODUCTO obj = new BE.PRODUCTO();
                obj.IDProducto = int.Parse(dr["id_producto"].ToString());
                obj.NombreProducto = dr["producto"].ToString();
                obj.TipoProducto = dr["tipo"].ToString();
                obj.PrecioUnitario = decimal.Parse(dr["precio_unitario"].ToString());
                listaProductos.Add(obj);
            }
            acceso.Cerrar();
            return listaProductos;
        }

        public override void Modificar(PRODUCTO objviejo, PRODUCTO objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

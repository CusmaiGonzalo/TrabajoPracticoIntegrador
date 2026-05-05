using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mapper_pedido : Mapper<BE.PEDIDO>
    {
        public override void Borrar(PEDIDO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(PEDIDO obj)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@fecha", obj.FechaYHora));
            parametros.Add(acceso.CrearParametro("@nombre_cliente", obj.NombreCliente));
            parametros.Add(acceso.CrearParametro("@precio_total", obj.PrecioTotal));
            acceso.Escribir("PEDIDO_CREAR_NUEVO", parametros);
            acceso.Cerrar();
        }

        public override List<PEDIDO> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(PEDIDO objviejo, PEDIDO objnuevo)
        {
            throw new NotImplementedException();
        }
        public void AgregarProductoAlPedido(int idPedido, int idProducto, int cantidad)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id_pedido", idPedido));
            parametros.Add(acceso.CrearParametro("@id_producto", idProducto));
            parametros.Add(acceso.CrearParametro("@cantidad", cantidad));
            acceso.Escribir("PEDIDOxPRODUCTO_AGREGAR", parametros);
            acceso.Cerrar();
        }
    }
}

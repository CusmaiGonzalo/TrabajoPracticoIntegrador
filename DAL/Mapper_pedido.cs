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
            parametros.Add(acceso.CrearParametro("@estado", Servicios.ConversorEstadoPedido.ConvertirEstadoPedido(obj.EstadoActual)));
            parametros.Add(acceso.CrearParametro("@id_vendedor", Servicios.SessionManager.Instance.UsuarioLog.IDUsuario));
            acceso.Escribir("PEDIDO_CREAR_NUEVO", parametros);
            acceso.Cerrar();
        }

        public override List<PEDIDO> Listar()
        {
            acceso.Abrir();
            List<PEDIDO> pedidos = new List<PEDIDO>();

            DataTable tabla = new DataTable();
            tabla = acceso.Leer("PEDIDO_LISTAR");
            foreach (DataRow fila in tabla.Rows)
            {
                PEDIDO pedido = new PEDIDO();
                pedido.IdPedido = Convert.ToInt32(fila["id_pedido"]);
                pedido.NombreCliente = fila["nombre_cliente"].ToString();
                pedido.FechaYHora = Convert.ToDateTime(fila["fecha_y_hora"]);
                pedido.PrecioTotal = Convert.ToDecimal(fila["precio_total"]);
                pedido.EstadoActual = Servicios.ConversorEstadoPedido.ConvertirEstadoPedido(fila["estado"].ToString());
                pedidos.Add(pedido);
            }
            return pedidos;
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

        public List<BE.PRODUCTO> ListarProductosDePedido(int idPedido)
        {
            acceso.Abrir();
            List<BE.PRODUCTO> productos = new List<BE.PRODUCTO>();
            DataTable tabla = new DataTable();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idpedido", idPedido));
            tabla = acceso.Leer("PEDIDOxPRODUCTO_LISTAR", parametros);
            foreach (DataRow fila in tabla.Rows)
            {
                BE.PRODUCTO producto = new BE.PRODUCTO();
                producto.IDProducto = Convert.ToInt32(fila["id_producto"]);
                producto.NombreProducto = fila["producto"].ToString();
                producto.PrecioUnitario = Convert.ToDecimal(fila["precio_unitario"]);
                producto.Cantidad = (Convert.ToInt32(fila["cantidad"]));
                producto.TipoProducto = Servicios.ConversorTipoProducto.ConvertirTipoProducto(Convert.ToInt32(fila["cantidad"]));
                productos.Add(producto);
            }
            return productos;
        }

        public void AgregarCocineroAlPedido(int idPedido, int idCocinero)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id_pedido", idPedido));
            parametros.Add(acceso.CrearParametro("@id_cocinero", idCocinero));
            acceso.Escribir("PEDIDO_AGREGAR_COCINERO", parametros);
            acceso.Cerrar();
        }
        public void ActualizazrEstadoPedido(int idPedido, string nuevoEstado)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@idpedido", idPedido));
            parametros.Add(acceso.CrearParametro("@estado", nuevoEstado));
            acceso.Escribir("PEDIDO_CAMBIAR_ESTADO", parametros);
            acceso.Cerrar();
        }
    }
}

using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestionNegocio
    {
        mapper_producto maperProducto = new mapper_producto();
        mapper_DVH maperDvh = new mapper_DVH();
        mapper_DVV maperDvv = new mapper_DVV();
        mapper_tipo_producto mapper_Tipo_Producto = new mapper_tipo_producto();
        Mapper_backup mapper_Backup = new Mapper_backup();
        public List<BE.PRODUCTO> ListarProductos()
        {
            return maperProducto.Listar();
        }
        public void AgregarProducto(BE.PRODUCTO nuevoProducto)
        {
            maperProducto.Insertar(nuevoProducto);
        }
        public void BorrarProducto(BE.PRODUCTO productoABorrar)
        {
            maperProducto.Borrar(productoABorrar);
        }
        public List<BE.DVH> ListarDVH()
        {
            return maperDvh.Listar();
        }
        public List<BE.DVV> ListarDVV()
        {
            return maperDvv.Listar();
        }
        public List<BE.TIPO_PRODUCTO> ListarTipoProducto()
        {
            return mapper_Tipo_Producto.Listar();
        }
        public bool VerificarIntegridadProductos()
        {
            if (Servicios.DigitoVerificador.VerificarIntegridadDVH(ListarDVH()) && Servicios.DigitoVerificador.VerificarIntegridadDVV(ListarDVV()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<BE.PRODUCTO_HISTORICO> ListarHistoricoProducto(BE.PRODUCTO producto)
        {
            return maperProducto.HistorialProducto(producto);
        }
        public void ModificarProducto(BE.PRODUCTO_HISTORICO productoViejo, BE.PRODUCTO productoNuevo)
        {
            maperProducto.ModificarProducto(productoViejo, productoNuevo, Servicios.SessionManager.Instance.UsuarioLog);
        }
        public List<OBJETO_DVH> ListarDVHs()
        {
            return maperDvh.ListarDVHs();
        }
        public string EstadoDeTabla()
        {
            return maperDvh.EstadoTabla();
        }
        public void RepararIntegridadProductos()
        {
            maperDvh.RecalcularTablas();
        }
        public void RealizarBackup(string ruta, string nombre)
        {
            mapper_Backup.RealizarBackup(ruta, nombre);
        }
        public void RestaurarBackup(string ruta, string nombre)
        {
            mapper_Backup.RealizarRestore(ruta, nombre);
        }

        public BE.PEDIDO CrearNuevoPedido(string nombrecliente)
        {
            BE.PEDIDO nuevoPedido = new BE.PEDIDO();
            nuevoPedido.NombreCliente = nombrecliente;
            nuevoPedido.Vendedor = Servicios.SessionManager.Instance.UsuarioLog;
            return nuevoPedido;
        }
        public void GuardarPedido(BE.PEDIDO pedido)
        {
            Mapper_pedido mapperPedido = new Mapper_pedido();
            mapperPedido.Insertar(pedido);
        }
        public void AgregarProductoAlPedido(BE.PEDIDO pedido, List<PRODUCTO> listaProductos)
        {
            Mapper_pedido mapperPedido = new Mapper_pedido();
            foreach (BE.PRODUCTO prod in listaProductos)
            {
                mapperPedido.AgregarProductoAlPedido(pedido.IdPedido, prod.IDProducto, prod.GetCantidad());
            }
        }
        public List<BE.PRODUCTO> AgruparProductos(List<BE.PRODUCTO> listaProductos)
        {
            List<BE.PRODUCTO> listaAgrupada = new List<BE.PRODUCTO>();
            listaAgrupada = listaProductos.GroupBy(p => p.IDProducto).Select(g => new BE.PRODUCTO
            {
                IDProducto = g.Key,
                NombreProducto = g.First().NombreProducto,
                TipoProducto = g.First().TipoProducto,
                PrecioUnitario = g.First().PrecioUnitario,
                Cantidad = g.Sum(p => p.GetCantidad())
            }).ToList();
            return listaAgrupada;
        }
        public BE.PEDIDO CalcularPrecioTotal(BE.PEDIDO pedido)
        {
            BE.PEDIDO pedidoAux = new BE.PEDIDO();
            pedidoAux = pedido;
            pedidoAux.PrecioTotal = 0;

            foreach (BE.PRODUCTO prod in pedidoAux.Items)
            {
                pedidoAux.PrecioTotal += prod.PrecioUnitario * prod.GetCantidad();
            }
            return pedidoAux;
        }
    }
}

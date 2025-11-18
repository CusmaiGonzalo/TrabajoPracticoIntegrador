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
            if(Servicios.DigitoVerificador.VerificarIntegridadDVH(ListarDVH()) && Servicios.DigitoVerificador.VerificarIntegridadDVV(ListarDVV()))
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
        public void ModificarProducto(BE.PRODUCTO productoViejo, BE.PRODUCTO productoNuevo)
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
    }
}

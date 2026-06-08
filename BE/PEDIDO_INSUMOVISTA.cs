using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PEDIDO_INSUMOVISTA
    {
        private readonly PEDIDO_INSUMO _pedidoInsumo;
        public PEDIDO_INSUMOVISTA(PEDIDO_INSUMO pedidoInsumo)
        {
            _pedidoInsumo = pedidoInsumo;
        }
        public int IdPedido => _pedidoInsumo.IdPedido;
        public DateTime Fecha => _pedidoInsumo.Fecha;
        public string EmpresaProveedor => _pedidoInsumo.EmpresaProveedor.Nombre;
        public decimal Total => _pedidoInsumo.Total;
        public ESTADO_PEDIDO_INSUMO Estado => _pedidoInsumo.EstadoDelPedido;
    }
}

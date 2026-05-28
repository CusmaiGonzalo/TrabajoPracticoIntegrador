using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PEDIDOVISTA
    {
        private readonly PEDIDO _pedido;
        public PEDIDOVISTA(PEDIDO pedido)
        {
            _pedido = pedido;
        }
        public int IdPedido => _pedido.IdPedido;
        public string NombreCliente => _pedido.NombreCliente;
        public DateTime FechaYHora => _pedido.FechaYHora;
        public decimal PrecioTotal => _pedido.PrecioTotal;
        public ESTADO EstadoActual => _pedido.EstadoActual;
        public PEDIDO GetPedido()
        {
            return _pedido;
        }
    }
}

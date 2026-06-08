using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PEDIDO_INSUMO
    {
		private int _id_pedido;

		public int IdPedido
		{
			get { return _id_pedido; }
			set { _id_pedido = value; }
		}
		private DateTime _fecha;

		public DateTime Fecha
		{
			get { return _fecha; }
			set { _fecha = value; }
		}
		private PROVEEDOR _empresa_proveedor;

		public PROVEEDOR EmpresaProveedor
		{
			get { return _empresa_proveedor; }
			set { _empresa_proveedor = value; }
		}
		private decimal _total;

		public decimal Total
		{
			get { return _total; }
			set { _total = value; }
		}
		private ESTADO_PEDIDO_INSUMO _estado;

		public ESTADO_PEDIDO_INSUMO EstadoDelPedido
		{
			get { return _estado; }
			set { _estado = value; }
		}

		private List<PRODUCTO> _items;
		public PEDIDO_INSUMO()
		{
			_items = new List<PRODUCTO>();
        }
		public void AgregarItem(PRODUCTO producto)
		{
			_items.Add(producto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PEDIDO
    {
		private int _id_pedido;

		public int IdPedido
		{
			get { return _id_pedido; }
			set { _id_pedido = value; }
		}
		private BE.USUARIO _cocinero;

		public BE.USUARIO Cocinero
		{
			get { return _cocinero; }
			set { _cocinero = value; }
		}
		private BE.USUARIO _vendedor;

		public BE.USUARIO Vendedor
		{
			get { return _vendedor; }
			set { _vendedor = value; }
		}
		private BE.USUARIO _supervisor;

		public BE.USUARIO Supervisor
		{
			get { return _supervisor; }
			set { _supervisor = value; }
		}
		private DateTime _fecha_y_hora;

		public DateTime FechaYHora
		{
			get { return _fecha_y_hora; }
			set { _fecha_y_hora = value; }
        }
		private List<BE.PRODUCTO> _items;

		public List<BE.PRODUCTO> Items
		{
			get { return _items; }
			set { _items = value; }
		}
		private string _nombre_cliente;

		public string NombreCliente
		{
			get { return _nombre_cliente; }
			set { _nombre_cliente = value; }
		}
		private decimal _precio_total;

		public decimal PrecioTotal
		{
			get { return _precio_total; }
			set { _precio_total = value; }
		}
		private ESTADO _estado_actual;

		public ESTADO EstadoActual
		{
			get { return _estado_actual; }
			set { _estado_actual = value; }
		}
		public PEDIDO()
		{
			 Items = new List<BE.PRODUCTO>();
			 FechaYHora = DateTime.Now;
			 EstadoActual = ESTADO.INICIADO;
        }
	}
}

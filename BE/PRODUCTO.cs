using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PRODUCTO
    {
		private int _id_producto;

		public int IDProducto
		{
			get { return _id_producto; }
			set { _id_producto = value; }
		}
		private string _nombre_producto;

		public string NombreProducto
		{
			get { return _nombre_producto; }
			set { _nombre_producto = value; }
		}
		private string _tipo_producto;

		public string TipoProducto
		{
			get { return _tipo_producto; }
			set { _tipo_producto = value; }
		}
		private decimal _precio_unitario;

		public decimal PrecioUnitario
		{
			get { return _precio_unitario; }
			set { _precio_unitario = value; }
		}
		public PRODUCTO() { }
	}
}

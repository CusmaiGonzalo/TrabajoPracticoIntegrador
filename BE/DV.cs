using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DVH
    {
		private string _dvh;

		public string DVHString
		{
			get { return _dvh; }
			set { _dvh = value; }
		}
		private int _id_producto;

		public int IDProducto
		{
			get { return _id_producto; }
			set { _id_producto = value; }
		}
		private string _estado;

		public string Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}

		public DVH() { }
	}
}

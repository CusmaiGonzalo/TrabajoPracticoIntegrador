using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OBJETO_DVH
    {
		private int _id_producto;

		public int IDProducto
		{
			get { return _id_producto; }
			set { _id_producto = value; }
		}
		private string _nombre_prod;

		public string NombreProducto
		{
			get { return _nombre_prod; }
			set { _nombre_prod = value; }
		}
		private string _estado;
		public string Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}
		public OBJETO_DVH() { }
	}
}

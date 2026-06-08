using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PROVEEDOR
    {
		private int _id_proveedor;

		public int IdProveedor
		{
			get { return _id_proveedor; }
			set { _id_proveedor = value; }
		}
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}
		private string _direccion;

		public string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}

	}
}

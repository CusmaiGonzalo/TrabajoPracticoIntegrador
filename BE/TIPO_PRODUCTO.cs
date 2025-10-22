using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TIPO_PRODUCTO
    {
		private int _id_tipo;

		public int IDTipo
		{
			get { return _id_tipo; }
			set { _id_tipo = value; }
		}
		private string _tipo;

		public string Tipo
		{
			get { return _tipo; }
			set { _tipo = value; }
		}

	}
}

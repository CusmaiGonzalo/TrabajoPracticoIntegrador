using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DVV
    {
		private string _estado;

		public string Estado
		{
			get { return _estado; }
			set { _estado = value; }
		}
		private string _dvv_tabla;

		public string DVVTabla
		{
			get { return _dvv_tabla; }
			set { _dvv_tabla = value; }
		}

		public DVV() { }
	}
}

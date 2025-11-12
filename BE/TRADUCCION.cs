using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TRADUCCION
    {
		private string _etiqueta;

		public string Etiqueta
		{
			get { return _etiqueta; }
			set { _etiqueta = value; }
		}
		private string _trad_esp;

		public string TraduccionEspañol
		{
			get { return _trad_esp; }
			set { _trad_esp = value; }
		}
		private string _traduccion;

		public string Traduccion
		{
			get { return _traduccion; }
			set { _traduccion = value; }
		}
		private int _id_etiqueta		;

		public int IDEtiqueta
		{
			set { _id_etiqueta = value; }
		}
		public int ObtenerIdTrad()
		{
			return _id_etiqueta;
        }
		public TRADUCCION() { }
    }
}

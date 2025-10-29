using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class IDIOMA
    {
		private int _id_idioma;

		public int IDIdioma
		{
			get { return _id_idioma; }
			set { _id_idioma = value; }
		}
		private string _nombre_idioma;

		public string NombreIdioma
		{
			get { return _nombre_idioma; }
			set { _nombre_idioma = value; }
		}

	}
}

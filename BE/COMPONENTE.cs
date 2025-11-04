using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class COMPONENTE
    {
		private int _id_patente;

		public int IDPatente
		{
			get { return _id_patente; }
			set { _id_patente = value; }
		}
		private string _nombre_patente;

		public string NombrePatente
		{
			get { return _nombre_patente; }
			set { _nombre_patente = value; }
		}

		public abstract bool Validar(COMPONENTE compo);

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BITACORA
    {
		private int _id_bitacora;

		public int IDBitacora
		{
			get { return _id_bitacora; }
			set { _id_bitacora = value; }
		}
		private string _detalle;

		public string Detalle
		{
			get { return _detalle; }
			set { _detalle = value; }
		}
		private string _tipo;

		public string Tipo
		{
			get { return _tipo; }
			set { _tipo = value; }
		}
		private DateTime _fecha_bitacora;

		public DateTime FechaBitacora
		{
			get { return _fecha_bitacora; }
			set { _fecha_bitacora = value; }
		}
		private string _user_bitacora;

		public string UserBitacora
		{
			get { return _user_bitacora; }
			set { _user_bitacora = value; }
		}


	}
}

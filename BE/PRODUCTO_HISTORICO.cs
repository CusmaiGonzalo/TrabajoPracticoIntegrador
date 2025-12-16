using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PRODUCTO_HISTORICO : PRODUCTO
    {
		private DateTime _fecha_cambio;

		public DateTime FechaCambio
		{
			get { return _fecha_cambio; }
			set { _fecha_cambio = value; }
		}
		private string _usuario;

		public string Usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}
		private string _detalle_cambio;

		public string DetalleCambio
		{
			get { return _detalle_cambio; }
			set { _detalle_cambio = value; }
		}
		public PRODUCTO_HISTORICO()
		{
			_detalle_cambio = "Cambios: ";
		}
	}
}

using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Bitacora
    {
        public static BE.BITACORA ErrorBitacora(string detalleEvento)
        {
            BE.BITACORA nuevaBitacora = new BE.BITACORA();
            nuevaBitacora.Detalle = detalleEvento;
            nuevaBitacora.UserBitacora = "SISTEMA";
            nuevaBitacora.FechaBitacora = DateTime.Now;
            nuevaBitacora.Tipo = "ERROR";
            return nuevaBitacora;
        }
        public static BE.BITACORA EventoBitacora(string detalleEvento)
        {
            BE.BITACORA nuevaBitacora = new BE.BITACORA();
            nuevaBitacora.Detalle = detalleEvento;
            nuevaBitacora.UserBitacora = SessionManager.Instance.UsuarioLog.NombreUsuario;
            nuevaBitacora.FechaBitacora = DateTime.Now;
            nuevaBitacora.Tipo = "EVENTO";
            return nuevaBitacora;
        }
    }
}

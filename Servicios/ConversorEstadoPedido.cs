using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Servicios
{
    public static class ConversorEstadoPedido
    {
        public static string ConvertirEstadoPedido(ESTADO estado)
        {
            switch (estado)
            {
                case ESTADO.PAGADO:
                    return "PAGADO";
                case ESTADO.COCINA:
                    return "COCINA";
                case ESTADO.ENTREGADO:
                    return "ENTREGADO";
                case ESTADO.LISTO:
                    return "LISTO";
                case ESTADO.CALCULADO:
                    return "CALCULADO";
                case ESTADO.INICIADO:
                     return "INICIADO";
                default:
                    return "INICIADO";
            }
        }
         public static ESTADO ConvertirEstadoPedido(string estado)
        {
            switch (estado)
            {
                case "INICIADO":
                    return ESTADO.INICIADO;
                case "CALCULADO":
                    return ESTADO.CALCULADO;
                case "PAGADO":
                    return ESTADO.PAGADO;
                case "COCINA":
                    return ESTADO.COCINA;
                case "LISTO":
                    return ESTADO.LISTO;
                case "ENTREGADO":
                    return ESTADO.ENTREGADO;
                default:
                    return ESTADO.INICIADO;
            }
        }
    }
}

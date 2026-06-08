using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public static class ConvEstPedidoInsumo
    {
        public static BE.ESTADO_PEDIDO_INSUMO Convertir(string estado)
        {
            switch (estado)
            {
                case "INICIADO":
                    return BE.ESTADO_PEDIDO_INSUMO.INICIADO;
                case "FIN_APROBADO":
                    return BE.ESTADO_PEDIDO_INSUMO.FIN_APROBADO;
                case "FIN_RECHAZADO":
                    return BE.ESTADO_PEDIDO_INSUMO.FIN_RECHAZADO;
                case "PRE_APROBADO":
                    return BE.ESTADO_PEDIDO_INSUMO.PRE_APROBADO;
                case "PRE_RECHAZADO":
                    return BE.ESTADO_PEDIDO_INSUMO.PRE_RECHAZADO;
                case "RECIBIDO_OK":
                    return BE.ESTADO_PEDIDO_INSUMO.RECIBIDO_OK;
                case "RECIBIDO_FALTANTE":
                    return BE.ESTADO_PEDIDO_INSUMO.RECIBIDO_FALTANTE;
                default:
                    throw new ArgumentException("Estado no válido");
            }
        }
        public static string Convertir(BE.ESTADO_PEDIDO_INSUMO estado)
        {
            switch (estado)
            {
                case BE.ESTADO_PEDIDO_INSUMO.INICIADO:
                    return "INICIADO";
                case BE.ESTADO_PEDIDO_INSUMO.FIN_APROBADO:
                    return "FIN_APROBADO";
                case BE.ESTADO_PEDIDO_INSUMO.FIN_RECHAZADO:
                    return "FIN_RECHAZADO";
                case BE.ESTADO_PEDIDO_INSUMO.PRE_APROBADO:
                    return "PRE_APROBADO";
                case BE.ESTADO_PEDIDO_INSUMO.PRE_RECHAZADO:
                    return "PRE_RECHAZADO";
                case BE.ESTADO_PEDIDO_INSUMO.RECIBIDO_OK:
                    return "RECIBIDO_OK";
                case BE.ESTADO_PEDIDO_INSUMO.RECIBIDO_FALTANTE:
                    return "RECIBIDO_FALTANTE";
                default:
                    throw new ArgumentException("Estado no válido");
            }
        }
    }
}

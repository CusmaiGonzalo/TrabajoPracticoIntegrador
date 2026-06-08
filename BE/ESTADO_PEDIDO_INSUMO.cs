using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum ESTADO_PEDIDO_INSUMO
    {
        INICIADO,
        FIN_APROBADO,
        FIN_RECHAZADO,
        PRE_APROBADO,
        PRE_RECHAZADO,
        RECIBIDO_OK,
        RECIBIDO_FALTANTE
    }
}

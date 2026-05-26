using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public static class ConversorTipoProducto
    {
        public static TIPO_PRODUCTO ConvertirTipoProducto(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return TIPO_PRODUCTO.NORMAL;
                case 2:
                    return TIPO_PRODUCTO.EXTRAS;
                case 3:
                    return TIPO_PRODUCTO.BEBIDA;
                case 4:
                    return TIPO_PRODUCTO.COMBO;
                default:
                    return TIPO_PRODUCTO.NORMAL;
            }
        }
        public static int ConvertirTipoProducto(TIPO_PRODUCTO tipo)
        {
            switch (tipo)
            {
                case TIPO_PRODUCTO.NORMAL:
                    return 1;
                case TIPO_PRODUCTO.EXTRAS:
                    return 2;
                case TIPO_PRODUCTO.BEBIDA:
                    return 3;
                case TIPO_PRODUCTO.COMBO:
                    return 4;
                default:
                    return 1;
            }
        }
    }
}

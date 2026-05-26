using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PRODUCTOVISTA
    {
        private readonly PRODUCTO _producto;

        public PRODUCTOVISTA(PRODUCTO producto)
        {
            _producto = producto;
        }

        public int IDProducto => _producto.IDProducto;
        public string NombreProducto => _producto.NombreProducto;
        public TIPO_PRODUCTO TipoProducto => _producto.TipoProducto;
        public decimal PrecioUnitario => _producto.PrecioUnitario;
        public int Cantidad => _producto.GetCantidad();
    }
}

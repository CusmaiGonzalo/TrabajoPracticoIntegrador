using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestionNegocio
    {
        mapper_producto maperProducto = new mapper_producto();
        public List<BE.PRODUCTO> ListarProductos()
        {
            return maperProducto.Listar();
        }
    }
}

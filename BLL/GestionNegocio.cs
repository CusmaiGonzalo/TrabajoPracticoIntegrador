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
        mapper_DVH maperDvh = new mapper_DVH();
        public List<BE.PRODUCTO> ListarProductos()
        {
            return maperProducto.Listar();
        }
        public void AgregarProducto(BE.PRODUCTO nuevoProducto)
        {
            maperProducto.Insertar(nuevoProducto);
        }
        public List<BE.DVH> ListarDVH()
        {
            return maperDvh.Listar();
        }
    }
}

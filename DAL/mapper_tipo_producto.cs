using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mapper_tipo_producto : Mapper<BE.TIPO_PRODUCTO>
    {
        public override void Borrar(TIPO_PRODUCTO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(TIPO_PRODUCTO obj)
        {
            throw new NotImplementedException();
        }

        public override List<TIPO_PRODUCTO> Listar()
        {
            DataTable dt = new DataTable();
            List<TIPO_PRODUCTO> listaproductos = new List<TIPO_PRODUCTO>();
            acceso.Abrir();
            dt = acceso.Leer("TIPOPRODUCTO_LISTAR");
            foreach (DataRow row in dt.Rows)
            { 
                TIPO_PRODUCTO nuevotipo = new TIPO_PRODUCTO();
                nuevotipo.IDTipo = int.Parse(row["id_tipo"].ToString());
                nuevotipo.Tipo = row["tipo"].ToString();
                listaproductos.Add(nuevotipo);
            }
            return listaproductos;
        }

        public override void Modificar(TIPO_PRODUCTO objviejo, TIPO_PRODUCTO objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

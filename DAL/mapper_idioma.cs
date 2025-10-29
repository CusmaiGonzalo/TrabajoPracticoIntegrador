using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class mapper_idioma : Mapper<BE.IDIOMA>
    {
        public override void Borrar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public override List<IDIOMA> Listar()
        {
            DataTable dt = new DataTable();
            acceso.Abrir();
            dt = acceso.Leer("IDIOMA_LISTAR");
            List<IDIOMA> listaIdiomas = new List<IDIOMA>();
            foreach (DataRow dr in dt.Rows)
            {
                BE.IDIOMA obj = new BE.IDIOMA();
                obj.IDIdioma = int.Parse(dr["id_idioma"].ToString());
                obj.NombreIdioma = dr["idioma"].ToString();
                listaIdiomas.Add(obj);
            }
            acceso.Cerrar();
            return listaIdiomas;
        }

        public override void Modificar(IDIOMA objviejo, IDIOMA objnuevo)
        {
            throw new NotImplementedException();
        }
    }
}

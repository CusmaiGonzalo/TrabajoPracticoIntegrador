using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mapper_etiquetas
    {
        Acceso acceso = new Acceso();
        public string ObtenerTraduccion(int idioma, string etiqueta)
        {
            DataTable dt = new DataTable();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@ididioma", idioma));
            parametros.Add(acceso.CrearParametro("@etiqueta", etiqueta));
            dt = acceso.Leer("TRADUCCION_BUSCAR", parametros);
            acceso.Cerrar();
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["traduccion"].ToString();
            }
            else
            {
                return null;
            }
        }
    }
}

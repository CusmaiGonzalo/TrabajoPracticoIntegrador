using BE;
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

        public List<TRADUCCION> ListarTraducciones(int ididioma)
        {
            DataTable dt = new DataTable();
            List<TRADUCCION> listaTraducciones = new List<TRADUCCION>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.Abrir();
            parametros.Add(acceso.CrearParametro("@ididioma", ididioma));
            dt = acceso.Leer("TRADUCCION_LISTAR_TRADUCCIONES", parametros);
            foreach(DataRow dr in dt.Rows)
            {
                TRADUCCION tradu = new TRADUCCION();
                tradu.Etiqueta = dr["etiqueta"].ToString();
                tradu.TraduccionEspañol = dr["trad_esp"].ToString();
                tradu.Traduccion = dr["traduccion"].ToString();
                tradu.IDEtiqueta = int.Parse(dr["id_etiqueta"].ToString());
                listaTraducciones.Add(tradu);
            }
            acceso.Cerrar();
            return listaTraducciones;
        }

        public void InsertarNuevoIdioma(string nombreidioma)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", nombreidioma));
            acceso.Escribir("IDIOMA_INSERTAR", parametros);
            acceso.Cerrar();
        }
        public void InsertarTraduccionesGenericaas(IDIOMA idiomanuevo, List<TRADUCCION> listaetiquetas)
        {
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            foreach (TRADUCCION traduccionesnuevas in listaetiquetas)
            {
                parametros.Add(acceso.CrearParametro("@ididioma", idiomanuevo.IDIdioma));
                parametros.Add(acceso.CrearParametro("@idetiqueta", traduccionesnuevas.ObtenerIdTrad()));
                parametros.Add(acceso.CrearParametro("@traduccion", traduccionesnuevas.Traduccion));
                acceso.Escribir("TRADUCCION_INSERTAR", parametros);
                parametros.Clear();
            }
        }
    }
}

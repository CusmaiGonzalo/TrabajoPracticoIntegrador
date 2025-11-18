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
    public class mapper_idioma : Mapper<BE.IDIOMA>
    {
        public override void Borrar(IDIOMA obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.Abrir();
            parametros.Add(acceso.CrearParametro("@ididioma", obj.IDIdioma));
            acceso.Escribir("IDIOMA_BORRAR", parametros);
            acceso.Cerrar();
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
        public List<IDIOMA> ListarTodos()
        {
            DataTable dt = new DataTable();
            acceso.Abrir();
            dt = acceso.Leer("IDIOMA_LISTAR_TODOS");
            List<IDIOMA> listaIdiomas = new List<IDIOMA>();
            foreach (DataRow dr in dt.Rows)
            {
                BE.IDIOMA obj = new BE.IDIOMA();
                obj.IDIdioma = int.Parse(dr["id_idioma"].ToString());
                obj.NombreIdioma = dr["idioma"].ToString();
                obj.Alta = int.Parse(dr["alta"].ToString());
                listaIdiomas.Add(obj);
            }
            acceso.Cerrar();
            return listaIdiomas;
        }
        public void AltaIdioma(IDIOMA idioma)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.Abrir();
            parametros.Add(acceso.CrearParametro("@ididioma", idioma.IDIdioma));
            acceso.Escribir("IDIOMA_ALTA", parametros);
            acceso.Cerrar();
        }
        public void BajaIdioma(IDIOMA idioma)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.Abrir();
            parametros.Add(acceso.CrearParametro("@ididioma", idioma.IDIdioma));
            acceso.Escribir("IDIOMA_BAJA", parametros);
            acceso.Cerrar();
        }
        public void ModificarIdiomaNombre(IDIOMA idioma)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.Abrir();
            parametros.Add(acceso.CrearParametro("@ididioma", idioma.IDIdioma));
            parametros.Add(acceso.CrearParametro("@nombreidioma", idioma.NombreIdioma));
            acceso.Escribir("IDIOMA_MODIFICAR_NOMBRE", parametros);
            acceso.Cerrar();
        }
    }
}

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
    public class mapper_permiso : Mapper<COMPONENTE>
    {
        public override void Borrar(COMPONENTE obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(COMPONENTE obj)
        {
            throw new NotImplementedException();
        }

        public override List<COMPONENTE> Listar()
        {
            DataTable dt = new DataTable();
            List<COMPONENTE> lista_permisos = new List<COMPONENTE>();
            acceso.Abrir();
            dt = acceso.Leer("PERMISO_LISTAR");
            foreach(DataRow dr in dt.Rows)
            {
                COMPONENTE obj = new PATENTE();
                obj.IDPatente = int.Parse(dr["id_permiso"].ToString());
                obj.NombrePatente = dr["detalle_permiso"].ToString();
                lista_permisos.Add(obj);
            }
            acceso.Cerrar();
            return lista_permisos;
        }

        public override void Modificar(COMPONENTE objviejo, COMPONENTE objnuevo)
        {
            throw new NotImplementedException();
        }
        public List<COMPONENTE> ListarPorUsuario(USUARIO usr)
        {
            DataTable dt = new DataTable();
            List<COMPONENTE> lista_permisos = new List<COMPONENTE>();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@usuario", usr.IDUsuario));
            dt = acceso.Leer("BUSCAR_PERMISOS_USUARIO", parametros);
            foreach(DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["id_permiso"].ToString()) <= 999)
                {
                    PATENTE pat = new PATENTE();
                    pat.IDPatente = int.Parse(dr["id_permiso"].ToString());
                    pat.NombrePatente = dr["detalle_permiso"].ToString();
                    lista_permisos.Add(pat);
                }
                else
                {
                    FAMILIA fam = new FAMILIA();
                    fam.IDPatente = int.Parse(dr["id_permiso"].ToString());
                    fam.NombrePatente = dr["detalle_permiso"].ToString();
                    lista_permisos.Add(fam);
                    fam.listaComponentes.AddRange(ListarPatentes(fam));
                }
            }
            return lista_permisos;
        }

        public List<COMPONENTE> ListarPatentes(FAMILIA GrupoPatentes)
        {
            DataTable dt = new DataTable();
            List<COMPONENTE> lista_patentes = new List<COMPONENTE>();
            acceso.Abrir();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@familia", GrupoPatentes.IDPatente));
            dt = acceso.Leer("PERMISO_BUSCAR", parametros);
            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(dr["id_permiso"].ToString()) <= 999)
                {
                    PATENTE pat = new PATENTE();
                    pat.IDPatente = int.Parse(dr["id_permiso"].ToString());
                    pat.NombrePatente = dr["detalle_permiso"].ToString();
                    lista_patentes.Add(pat);
                }
                else
                {
                    FAMILIA fam = new FAMILIA();
                    fam.IDPatente = int.Parse(dr["id_permiso"].ToString());
                    fam.NombrePatente = dr["detalle_permiso"].ToString();
                    lista_patentes.Add(fam);
                    fam.listaComponentes.AddRange(ListarPatentes(fam));
                }
            }
            return lista_patentes;
        }
        
    }
}

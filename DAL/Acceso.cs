using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;

namespace DAL
{
    public class Acceso
    {
        SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection(@"INTEGRATED SECURITY=SSPI; DATA SOURCE=DESKTOP-14CDBSR\SQLEXPRESS; INITIAL CATALOG=TPIntegrador; TrustServerCertificate=True");
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }
        public SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }
            return cmd;
        }
        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = CrearComando(sql, parametros);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            adaptador = null;
            return tabla;
        }
        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = CrearComando(sql, parametros);
            int filas = 0;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                filas = -1;
            }
            return filas;
        }
        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter par = new SqlParameter(nombre, valor);
            par.DbType = DbType.String;
            return par;
        }
        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter par = new SqlParameter(nombre, valor);
            par.DbType = DbType.Int32;
            return par;
        }
        public SqlParameter CrearParametro(string nombre, DateTime valor)
        {
            SqlParameter par = new SqlParameter(nombre, valor);
            par.DbType = DbType.DateTime;
            return par;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mapper_backup
    {
        Acceso acceso = new Acceso();
        public void RealizarBackup(string ruta, string nombreBackup)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.Abrir();
            parametros.Add(acceso.CrearParametro("@DatabaseName", nombreBackup));
            parametros.Add(acceso.CrearParametro("@BackupFolder", ruta));
            acceso.Escribir("BACKUP_GENERAR", parametros);
            acceso.Cerrar();
        }
        public void RealizarRestore(string rutaArchivo, string nombre)
        {
            
            List<SqlParameter> parametros = new List<SqlParameter>();
            acceso.AbrirMotor(@"INTEGRATED SECURITY=SSPI; DATA SOURCE=DESKTOP-0S6I2FQ; INITIAL CATALOG=master; TrustServerCertificate=True");
            parametros.Add(acceso.CrearParametro("@BackupFile", rutaArchivo));
            parametros.Add(acceso.CrearParametro("@DatabaseName", nombre));
            acceso.Escribir("BACKUP_RESTORE", parametros);
            acceso.Cerrar();
        }
    }
}

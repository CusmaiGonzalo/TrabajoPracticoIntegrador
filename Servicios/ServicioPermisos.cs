using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Servicios
{
    public class ServicioPermisos
    {
        public static bool ValidarPermisos(COMPONENTE permisoValidar, USUARIO user)
        {
            bool validacion = false;
            foreach (COMPONENTE permiso in user.ListaPermisos)
            {
                if (permiso.Validar(permisoValidar) == true)
                {
                    validacion = true;
                    break;
                }
            }
            return validacion;
        }
    }
}

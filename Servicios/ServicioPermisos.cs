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
        
        public static bool ValidarPermisosGeneral(COMPONENTE permiso, List<COMPONENTE> listaCompo)
        {
            bool validacion = false;
            foreach (COMPONENTE comp in listaCompo)
            {
                if(comp is PATENTE)
                {
                    validacion = comp.Validar(permiso);
                    if (validacion == true) { break; }
                }
                if(comp is FAMILIA)
                {
                    FAMILIA compfamilia = (FAMILIA)comp;
                    if(compfamilia.IDPatente == permiso.IDPatente)
                    {
                        validacion = true;
                        break;
                    }
                    validacion = ValidarPermisosGeneral(permiso, compfamilia.listaComponentes);
                }
            }
            return validacion;
        }
        public static COMPONENTE ObeterComponenteEnontrada(COMPONENTE permiso, List<COMPONENTE> listacompo)
        {
            bool validacion = false;
            COMPONENTE componenteencontrado = null;
            
            foreach (COMPONENTE comp in listacompo)
            {
                if (comp is PATENTE)
                {
                    validacion = comp.Validar(permiso);
                    if (validacion == true) 
                    {
                        componenteencontrado = comp;
                        break; 
                    }
                }
                if (comp is FAMILIA)
                {
                    FAMILIA compfamilia = (FAMILIA)comp;
                    if (compfamilia.IDPatente == permiso.IDPatente)
                    {
                        validacion = true;
                        componenteencontrado = compfamilia;
                        break;
                    }
                    else
                    {
                        componenteencontrado = ObeterComponenteEnontrada(permiso, compfamilia.listaComponentes);
                    }
                }
            }
            return componenteencontrado;
        }
    }
}

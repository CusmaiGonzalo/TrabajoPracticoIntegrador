using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DigitoVerificador
    {
        
        public static bool VerificarIntegridadDVH(List<BE.DVH> listadigitos)
        {
            if (listadigitos == null || listadigitos.Count == 0)
            {
                return false; // Si no hay dígitos para verificar, consideramos que la integridad no es válida
            }

            foreach (BE.DVH digito in listadigitos)
            {
                if (digito.Estado != "OK")
                {
                    return false; // Si encontramos al menos un dígito cuyo estado no es "OK", devolvemos false
                }
            }

            return true; // Todos los dígitos tienen estado "OK"
        }
        public static bool VerificarIntegridadDVV(List<BE.DVV> listadigitos)
        {
            if (listadigitos == null || listadigitos.Count == 0)
            {
                return false; 
            }

            foreach (BE.DVV digito in listadigitos)
            {
                if (digito.Estado != "OK")
                {
                    return false; 
                }
            }

            return true;
        }
    }
}

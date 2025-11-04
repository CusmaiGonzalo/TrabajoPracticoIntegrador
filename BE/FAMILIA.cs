using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FAMILIA : COMPONENTE
    {
        private List<COMPONENTE>  _lista_componentes;

        public List<COMPONENTE>  listaComponentes
        {
            get { return  _lista_componentes; }
            set {  _lista_componentes = value; }
        }

        public override bool Validar(COMPONENTE compo)
        {
            bool encontrado = false;
            foreach (COMPONENTE componente in listaComponentes)
            {
                if (componente.IDPatente == compo.IDPatente)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }

        public FAMILIA()
        {
            listaComponentes = new List<COMPONENTE>();
        }
    }
}

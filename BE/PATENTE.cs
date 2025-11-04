using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PATENTE : COMPONENTE
    {
        public override bool Validar(COMPONENTE compo)
        {
            return compo.IDPatente == this.IDPatente;
        }
    }
}

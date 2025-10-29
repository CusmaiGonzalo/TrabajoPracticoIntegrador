using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface ISujetoObserver
    {
        public void Agregar(IObserver observer);
        public void Quitar(IObserver observer);
        public void NotificarObservadores();
    }
}

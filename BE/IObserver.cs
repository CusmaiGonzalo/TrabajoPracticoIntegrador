using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IObserver
    {
        public void Traducir(int nuevoIdioma);
    }
}

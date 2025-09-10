using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Mapper<T>
    {
        protected Acceso acceso = new Acceso();
        public abstract void Insertar(T obj);
        public abstract void Borrar(T obj);
        public abstract void Modificar(T objviejo, T objnuevo);
        public abstract List<T> Listar();
    }
}

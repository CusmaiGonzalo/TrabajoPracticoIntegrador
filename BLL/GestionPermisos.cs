using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestionPermisos
    {
        mapper_permiso mapperPermisos = new DAL.mapper_permiso();
        public USUARIO CargarPermisosUsuario(USUARIO user)
        {
            user.ListaPermisos = mapperPermisos.ListarPorUsuario(user);
            return user;
        }
    }
}

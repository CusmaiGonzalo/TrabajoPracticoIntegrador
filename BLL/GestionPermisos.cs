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
        public bool ValidarPermisosDeUsuario(COMPONENTE permiso, USUARIO user)
        {
            bool validacion = false;
            validacion = Servicios.ServicioPermisos.ValidarPermisos(permiso, user);
            return validacion;
        }
        public List<COMPONENTE> ListarPermisos()
        {
            return mapperPermisos.Listar();
        }
        public void InsertarGrupoPermiso(FAMILIA permiso)
        {
            mapperPermisos.Insertar(permiso);
        }
        public List<FAMILIA> ListarSoloFamilias()
        {
            return mapperPermisos.ListarSoloFamilias();
        }
        public List<PATENTE> ListarSoloPermisos()
        {
            return mapperPermisos.ListarSoloPatente();
        }
        public List<COMPONENTE> ListarPatentesDeGrupo(FAMILIA familiaelecgida)
        {
            return mapperPermisos.ListarPatentes(familiaelecgida);
        }
        public void InsertarPatenteAGrupo(FAMILIA familiaseleccionada, PATENTE patenteseleciconada)
        {
            mapperPermisos.InsertarPatenteAGrupo(familiaseleccionada, patenteseleciconada);
        }
    }
}

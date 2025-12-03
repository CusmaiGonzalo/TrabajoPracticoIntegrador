using BE;
using DAL;
using Servicios;
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
            bool validar = false;
            validar = ServicioPermisos.ValidarPermisosGeneral(patenteseleciconada, familiaseleccionada.listaComponentes); 
            if(familiaseleccionada.listaComponentes.Find(x => x.IDPatente == patenteseleciconada.IDPatente) != null)
            {
                validar = true;
            }
            if(validar == false)
            {
                mapperPermisos.InsertarPatenteAGrupo(familiaseleccionada, patenteseleciconada);
            }
            else { throw new Exception("Ya existe esa patente en ese grupo."); }
        }
        public void AgregarGrupoAFamilia(FAMILIA familiaPadre, FAMILIA familiaHija)
        {
            bool validar = false;
            if(familiaHija.IDPatente == familiaPadre.IDPatente)
            {
                throw new Exception("No se puede agregar un grupo a si mismo.");
            }
            if(familiaHija.IDPatente == 1000) { throw new Exception("No se puede agregar Administrador a otro grupo.");}
            validar = ServicioPermisos.ValidarPermisosGeneral(familiaHija, familiaPadre.listaComponentes);
            if (validar == false)
            {
                mapperPermisos.InsertarGrupoAGrupo(familiaPadre, familiaHija);
            }
            else { throw new Exception("Ya existe ese grupo en ese grupo padre."); }
        }
        public void EliminarPatenteDeGrupo(FAMILIA familiaseleccionada, PATENTE patenteseleciconada)
        {
            bool validar = false;
            validar = familiaseleccionada.listaComponentes.Exists(x => x.IDPatente == patenteseleciconada.IDPatente);
            if (validar == true)
            {
                mapperPermisos.BorrarPermisoDeGrupo(familiaseleccionada, patenteseleciconada);
            }
            else { throw new Exception("No existe esa patente individual en ese grupo."); }
        }
        public void EliminarGrupo(FAMILIA familiaseleccionada)
        {
            mapperPermisos.BorrarGrupoCompleto(familiaseleccionada);
        }
    }
}

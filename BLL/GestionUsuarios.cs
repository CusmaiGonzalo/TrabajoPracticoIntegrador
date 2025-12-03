using BE;
using Servicios;
using System.Diagnostics.Contracts;

namespace BLL
{
    public class GestionUsuarios
    {
        DAL.Mapper_usuario mapper = new DAL.Mapper_usuario();
        DAL.mapper_bitacora maperbitacora = new DAL.mapper_bitacora();
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        public void LogearUsuario(BE.USUARIO user)
        {
            USUARIO usuarioEncontrado = new USUARIO();
            usuarioEncontrado = mapper.BuscarUsuario(user);
            if(usuarioEncontrado == null)
            {
                nuevaBitacora = Bitacora.ErrorBitacora("Usuario incorrecto");
                maperbitacora.Insertar(nuevaBitacora);
                throw new Exception("Usuario o contraseña incorrectos.");
            }
            else if (CryptoManager.VerificarContraseña(user.ObtenerContraseña(), usuarioEncontrado.ObtenerContraseña(), Convert.FromBase64String(usuarioEncontrado.ObtenerSalt())) == true)
            {
                SessionManager.LogIn(usuarioEncontrado);
                
                nuevaBitacora = Bitacora.EventoBitacora("Usuario logueado correctamente");
                maperbitacora.Insertar(nuevaBitacora);
                
            }
            else
            {
                nuevaBitacora = Bitacora.ErrorBitacora("Contraseña Incorrecta");
                maperbitacora.Insertar(nuevaBitacora);
                throw new Exception("Usuario o contraseña incorrectos.");
            }
            
        }

        public void AgregarUsuario(BE.USUARIO nuevoUsuario)
        {
            byte[] salt;
            nuevoUsuario.Contraseña = CryptoManager.HashearContraseña(nuevoUsuario.ObtenerContraseña(), out salt);
            nuevoUsuario.Salt = Convert.ToBase64String(salt);
            mapper.Insertar(nuevoUsuario);
            
            // Registrar evento en bitácora
            nuevaBitacora = Bitacora.EventoBitacora($"Usuario '{nuevoUsuario.NombreUsuario}' agregado al sistema");
            maperbitacora.Insertar(nuevaBitacora);
        }

        public void EscribirBitacora(BE.BITACORA nuevoBitacora)
        {
            maperbitacora.Insertar(nuevoBitacora);
        }
        public List<BE.BITACORA> ListarBitacora()
        {
            List<BE.BITACORA> listadebitacoras = new List<BE.BITACORA>();
            listadebitacoras = maperbitacora.Listar();
            return listadebitacoras;
        }

        public List<BE.USUARIO> ListarUsuarios()
        {
            return mapper.Listar();
        }
        public void BorrarUsuario(BE.USUARIO usuario)
        {
            mapper.Borrar(usuario);
            
            // Registrar evento en bitácora
            nuevaBitacora = Bitacora.EventoBitacora($"Usuario '{usuario.NombreUsuario}' eliminado del sistema");
            maperbitacora.Insertar(nuevaBitacora);
        }
        
        public void ModificarUsuario(BE.USUARIO usuarioViejo, BE.USUARIO usuarioNuevo)
        {
            mapper.Modificar(usuarioViejo, usuarioNuevo);
            
            // Registrar evento en bitácora
            nuevaBitacora = Bitacora.EventoBitacora($"Usuario '{usuarioViejo.NombreUsuario}' modificado en el sistema");
            maperbitacora.Insertar(nuevaBitacora);
        }
        public void AgregarPermisoAUsuario(BE.USUARIO usuarioSeleccionado, PATENTE patenteSeleccionada)
        {
            bool validacion = false;
            foreach(COMPONENTE comp in usuarioSeleccionado.ListaPermisos)
            {
                validacion = comp.Validar(patenteSeleccionada);
                if (validacion == true) { break; }
            }
            if (usuarioSeleccionado.ListaPermisos.Find(x => x.IDPatente == patenteSeleccionada.IDPatente) != null)
            {
                validacion = true;
            }
            if (validacion == true) { throw new Exception("El usuario ya posee ese permiso"); }
            else { mapper.AsignarPermisoAUsuario(usuarioSeleccionado, patenteSeleccionada); }
        }
        public void QuitarPermisoAUsuario(BE.USUARIO usuarioSeleccionado, COMPONENTE patenteSeleccionada)
        {
            bool validacion = false;
            if (usuarioSeleccionado.ListaPermisos.Find(x => x.IDPatente == patenteSeleccionada.IDPatente) != null)
            {
                validacion = true;
            }
            if (validacion == false) { throw new Exception("El usuario no posee ese permiso"); }
            else { mapper.BorrarPermisoDeUsuario(usuarioSeleccionado, patenteSeleccionada); }
        }
    }
}

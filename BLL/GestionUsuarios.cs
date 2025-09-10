using BE;
using Servicios;

namespace BLL
{
    public class GestionUsuarios
    {
        DAL.Mapper_usuario mapper = new DAL.Mapper_usuario();
        public void LogearUsuario(BE.USUARIO user)
        {
            USUARIO usuarioEncontrado = new USUARIO();
            usuarioEncontrado = mapper.BuscarUsuario(user);
            if(usuarioEncontrado == null)
            {
                throw new Exception("Usuario o contraseña incorrectos.");
            }
            if (CryptoManager.VerificarContraseña(user.Contraseña, usuarioEncontrado.Contraseña, Convert.FromBase64String(usuarioEncontrado.Salt)) == true)
            {
                SessionManager.LogIn(user);
            }
            else
            {
                throw new Exception("Contraseña incorrectos.");
            }
            
        }

        public void AgregarUsuario(BE.USUARIO nuevoUsuario)
        {
            byte[] salt;
            nuevoUsuario.Contraseña = CryptoManager.HashearContraseña(nuevoUsuario.Contraseña, out salt);
            nuevoUsuario.Salt = Convert.ToBase64String(salt);
            mapper.Insertar(nuevoUsuario);
        }


    }
}

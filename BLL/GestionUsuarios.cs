using Servicios;

namespace BLL
{
    public class GestionUsuarios
    {
        DAL.Mapper_usuario mapper = new DAL.Mapper_usuario();
        public void LogearUsuario(BE.USUARIO user)
        {
            SessionManager.LogIn(user);
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

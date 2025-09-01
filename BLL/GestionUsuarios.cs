using Servicios;

namespace BLL
{
    public class GestionUsuarios
    {
        public void LogearUsuario(BE.USUARIO user)
        {
            SessionManager.LogIn(user);
        }
    }
}

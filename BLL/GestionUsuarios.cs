using BE;
using Servicios;

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
            else if (CryptoManager.VerificarContraseña(user.Contraseña, usuarioEncontrado.Contraseña, Convert.FromBase64String(usuarioEncontrado.Salt)) == true)
            {
                SessionManager.LogIn(user);
                
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
            nuevoUsuario.Contraseña = CryptoManager.HashearContraseña(nuevoUsuario.Contraseña, out salt);
            nuevoUsuario.Salt = Convert.ToBase64String(salt);
            mapper.Insertar(nuevoUsuario);
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

    }
}

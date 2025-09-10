using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class CryptoManager
    {
        public static string HashearContraseña(string contraseña, out byte[] salt)
        {
            salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            using (var pbkdf2 = new Rfc2898DeriveBytes(contraseña, salt, 100000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                return Convert.ToBase64String(hash);
            }
        }

        public static bool VerificarContraseña(string contraseña, string hashAlmacenado, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(contraseña, salt, 100000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                string hashVerificado = Convert.ToBase64String(hash);
                if(hashVerificado == hashAlmacenado)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

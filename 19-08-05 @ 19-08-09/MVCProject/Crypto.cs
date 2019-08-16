using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MVCProject
{
    class Crypto
    {
        
        public byte[] InputToHash(string input)
        {
            SHA256 hashear = SHA256.Create();
            return hashear.ComputeHash(Encoding.UTF8.GetBytes(input));
        }

        public byte[] GenerateSalt()
        {
            byte[] salt = new byte[12];
            RNGCryptoServiceProvider.Create().GetBytes(salt);
            return salt;
        }

        public string HashQueRetornaString(string input)
        {
            var password = InputToHash(input);
            
            StringBuilder buildar = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                buildar.Append(password[i].ToString());
            }
            return buildar.ToString();
        }

        public string SaltQueRetornaString()
        {
            var salgado = GenerateSalt();
            StringBuilder buildar = new StringBuilder();
            for (int i = 0; i < salgado.Length; i++)
            {
                buildar.Append(salgado[i].ToString());
            }
            return buildar.ToString();

        }
    }
}

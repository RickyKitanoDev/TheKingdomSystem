using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheKingdomSystem.Management.Domain.Shared
{
    public class Encryptor
    {
        public string Key = "123456";
        public string EncryptHmac256(string userPassword)
        {
            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(Key));
            var dataMac = hmac.ComputeHash(Encoding.UTF8.GetBytes(userPassword));
            StringBuilder sBuilderMac = new StringBuilder();
            for(int i = 0; i < dataMac.Length;i++)
            {
                sBuilderMac.Append(dataMac[i].ToString("x2"));
            }
            return sBuilderMac.ToString();
        }

        public string DecryptHmac256(string userPassword)
        {
            throw new NotImplementedException();

        }
    }
}

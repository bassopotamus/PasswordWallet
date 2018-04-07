using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PasswordGenerator
{
    class Hashing
    {        
        private Boolean compareResult = false;

        public String EncryptString(String toEncrypt)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                String encryptResult;

                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(toEncrypt));

                StringBuilder stringEncrypted = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    stringEncrypted.Append(data[i].ToString("x2"));
                }
                
                encryptResult = stringEncrypted.ToString();

                return encryptResult;

            }
            
        }

        public Boolean CompareString(String toCompare)
        {           
            return compareResult;
        }
    }
}

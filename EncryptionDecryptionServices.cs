using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordGenerator
{
    public class EncryptionDecryptionServices
    {
        public string Encrypt(string encryptPass)
        {
            string EncryptionKey = "1125d5dedc2357524654sssseeoiulkdsss";
            byte[] clearBytes = Encoding.Unicode.GetBytes(encryptPass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    encryptPass = Convert.ToBase64String(ms.ToArray());
                }
            }
            return encryptPass;
        }

        public string Decrypt(string decryptPass)
        {
            string EncryptionKey = "1125d5dedc2357524654sssseeoiulkdsss";
            decryptPass = decryptPass.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(decryptPass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    decryptPass = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return decryptPass;
        }
    }
}
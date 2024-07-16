using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LicenseAuthenticationTool
{
    public class Decryptor
    {
        public static string AESDecrypt(string toDecrypt, byte[] aesKey, byte[] aesIv)
        {
            string decryptedKey = String.Empty;
            using (Aes aesDecryptor = Aes.Create())
            {
                ICryptoTransform decryptor = aesDecryptor.CreateDecryptor(aesKey, aesIv);

                using (MemoryStream memStream = new MemoryStream(Convert.FromBase64String(toDecrypt)))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            decryptedKey = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return decryptedKey;
        }
    }
}

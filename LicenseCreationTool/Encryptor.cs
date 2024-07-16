using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseCreationTool
{
    public class Encryptor
    {
        public static string AESEncrypt(string toEncrypt, byte[] aesKey, byte[] aesIv)
        {
            byte[] encryptKey = null;
            using (Aes aesEncryptor = Aes.Create())
            {
                ICryptoTransform encryptor = aesEncryptor.CreateEncryptor(aesKey, aesIv);

                using (MemoryStream memStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(toEncrypt);
                        }

                        encryptKey = memStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(encryptKey);
        }
    }
}

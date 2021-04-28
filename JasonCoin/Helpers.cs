using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JasonCoin
{
    public static class Helpers
    {
        // Convert an object to a byte array
        public static byte[] ObjectToSHA256(Object obj)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (var ms = new MemoryStream())
                {
                    bf.Serialize(ms, obj);
                    return mySHA256.ComputeHash(ms.ToArray());
                }
            }
        }
        public static string ToHexString(this byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}

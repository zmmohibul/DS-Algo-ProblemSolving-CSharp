using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiniatureGit
{
    public class Utils
    {
        public static async Task<string> WriteObjectAndGetObjectHashAsync(object obj, string path)
        {
            var objectSerialized = GetJsonFromObject(obj);
            var objectSerializedByte = UnicodeEncoding.UTF8.GetBytes(objectSerialized);
            var objectHash = Hash(objectSerializedByte);
            
            await WriteJsonAsync(objectSerialized, Path.Join(path, objectHash));

            return objectHash;
        }

        private static string Hash(byte[] input)
        {
            using var sha1 = SHA1.Create();
            return Convert.ToHexString(sha1.ComputeHash(input));
        }

        public static string GetJsonFromObject(object data)
        {
            return JsonSerializer.Serialize(data);
        }
        public static async Task WriteJsonAsync(string data, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            await File.WriteAllTextAsync(filePath, data);
        }
    }
}
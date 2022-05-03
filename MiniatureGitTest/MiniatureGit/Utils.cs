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
            var objectSerialized = JsonSerializer.Serialize(obj);
            var objectHash = GetSha1(objectSerialized);
            await File.WriteAllTextAsync(Path.Join(path, objectHash), objectSerialized);
            return objectHash;
        }

        public static async Task<string> WriteObjectAndGetObjectHashAsync<T>(T obj, string path)
        {
            var objectSerialized = JsonSerializer.Serialize<T>(obj);
            var objectHash = GetSha1(objectSerialized);
            await File.WriteAllTextAsync(Path.Join(path, objectHash), objectSerialized);
            return objectHash;
        }

        public static async Task WriteObject(object obj, string path)
        {
            var objectSerialized = JsonSerializer.Serialize(obj);
            var objectSerializedByte = UnicodeEncoding.UTF8.GetBytes(objectSerialized);
            await File.WriteAllTextAsync(path, objectSerialized);
        }

        public static async Task<T> ReadObjectAsync<T>(string path)
        {
            using FileStream openStream = File.OpenRead(path);
            T objectToReturn = await JsonSerializer.DeserializeAsync<T>(openStream);
            return objectToReturn;
        }

        public static string GetSha1(byte[] input)
        {
            using var sha1 = SHA1.Create();
            return Convert.ToHexString(sha1.ComputeHash(input));
        }

        public static string GetSha1(string intput)
        {
            using var sha1 = SHA1.Create();
            return Convert.ToHexString(sha1.ComputeHash(UnicodeEncoding.UTF8.GetBytes(intput)));
        }

    }
}
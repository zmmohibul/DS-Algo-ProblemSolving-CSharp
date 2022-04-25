using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiniatureGit
{
    public class DataSerializer
    {
        public static string GetJson(object data)
        {
            return JsonSerializer.Serialize(data);
        }
        public static async Task Serialize(string data, string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            await File.WriteAllTextAsync(filePath, data);
        }
    }
}
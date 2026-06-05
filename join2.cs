using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AppConfig
{
    public class AppConfig
    {
        public string ServerName { get; set; }
        public int Port { get; set; }
        public List<EndPoint>? Endpoints { get; set; }
        public AppConfig(string serverName, int port)
        {
            ServerName = serverName;
            Port = port;
            Endpoints = new List<EndPoint>();
        }
        public override string ToString() {

            return $"{ServerName}{Port}{string.Join(",", Endpoints)}";
        }

    }

    public static class ConfigManager
    {
        public static void Save(string path, AppConfig config)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            File.WriteAllText(path, JsonSerializer.Serialize(config, options));
        }

        public static AppConfig Load(string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            using FileStream file = new FileStream(path, FileMode.Open);
            AppConfig deserializedAppConfigs = JsonSerializer.Deserialize<AppConfig>(file, options);
            
            
            if (!File.Exists(path))
            {
                Console.WriteLine("erorr");
            }
            return deserializedAppConfigs;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                string filePath = "app_config.json";
              
                List<string> Endpoints = new List<string> { "/api/uesers", "api/aaaaa" };
                AppConfig config = new AppConfig("sererer", 1234, endpoints);
                ConfigManager.Save(filePath, config);
                AppConfig a= ConfigManager.Load(filePath);
                Console.WriteLine(a);
            }
        }
    }
}

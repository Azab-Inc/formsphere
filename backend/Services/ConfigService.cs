using backend.DTOs;
using backend.Models;
using backend.Interfaces;
using System.Text.Json;
using backend.Data;

namespace backend.Services
{
    public class ConfigService : IConfigService
    {
        private readonly string _configFilePath = Path.Combine("Data", "config.json");
        private readonly DataContext _context;

        public ConfigService()
        {

        }
        public ConfigService(DataContext context)
        {
            _context = context;
        }
        public Config GetConfig()
        {
            // Read JSON content from the file
            string jsonContent = System.IO.File.ReadAllText(_configFilePath);

            // Deserialize JSON content into Config object
            Config configModel = JsonSerializer.Deserialize<Config>(jsonContent);

            return configModel;
        }

        public void SetConfig(ConfigDTO config)
        {
            // Serialize the configModel object to JSON format
            string configData = JsonSerializer.Serialize(config);
            try
            {
                // Write the JSON data back to the file
                System.IO.File.WriteAllText(_configFilePath, configData);
            }
            catch
            {
            }

        }

        public bool dbConnected()
        {
            try
            {
                _context.Users.Count();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

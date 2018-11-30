using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FiltriBot
{
    class Config
    {
        private const string ConfigFolder = "Resources";
        private const string configFile = "config.json";

        public static BotConfig bot;

        static Config()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            if (!Directory.Exists(ConfigFolder))
            {
                Directory.CreateDirectory(ConfigFolder);
                Console.WriteLine("Created new Folder/Directory");
            }
            if (!File.Exists(ConfigFolder + "/" + configFile))
            {
                bot = new BotConfig();
                string json = JsonConvert.SerializeObject(bot, Formatting.Indented);
                File.WriteAllText(ConfigFolder + "/" + configFile, json);
                Console.WriteLine("Created new config file...");
            }
            else
            {
                string json = File.ReadAllText(ConfigFolder + "/" + configFile);
                bot = JsonConvert.DeserializeObject<BotConfig>(json);
                Console.WriteLine("Mounted {0}...", configFile);

            }
        }
    }

    public struct BotConfig
    {
        public string token;
        public string cmdPrefix;
    }
}
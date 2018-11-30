using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace FiltriBot
{
    class Utilities

    {

        private const string ResourcesFolder = "Resources";
        private const string dataJSON = "data.json";
        private static Dictionary<string, string[]> data_dictionary;
        private static String[] filterWords = new String[8];

        static Utilities()
        {
            string json = File.ReadAllText(ResourcesFolder + "/" + dataJSON);
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            //data_dictionary = data.ToObject<Dictionary<string, string[]>>();
            //Console.WriteLine(data);
            //filterWords[0] = data.WordsToFilter[1];
            //filterWords = data.ToObject<List<string>>();

            for (int forX = 0; forX < data.WordsToFilter.Count; forX++)
            {
                filterWords[forX] = data.WordsToFilter[forX];
                Console.WriteLine(filterWords[forX]);
            }
            Console.WriteLine(data.WordsToFilter[0]);
        }

        public static string getData(string key)
        {
            //if (data_dictionary.ContainsKey(key)) return data_dictionary[key];
            return "";
        }

        public static string[] toFilterWords()
        {

            return filterWords;
        }
    }
}
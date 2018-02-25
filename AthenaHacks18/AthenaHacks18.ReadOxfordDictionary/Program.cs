using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace AthenaHacks18.ReadOxfordDictionary
{
    public class Program
    {
        public static string JSONDeserialized { get; set; }


        static void Main(string[] args)
        {
            var oxfordAPIURL = "https://od-api.oxforddictionaries.com/api/v1/entries/en/";
            string textFromFile = File.ReadAllText(@"../../2ndGradeWords.txt");
            string[] words = textFromFile.Split(new string[1] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list = words.ToList();


            using (var webClient = new WebClient())
            {
                webClient.Headers["app_id"] = "ca73cfcd";
                webClient.Headers["app_key"] = "f1e9c82a9cfe6fbf1cdbd88ce21802c1";
                Console.WriteLine(words[0]);
                var str = webClient.DownloadString(oxfordAPIURL + words[0].Trim());

                var jsonStr = JsonConvert.DeserializeObject(str);

                Dictionary<string, object> JSONDic = new Dictionary<string, object>();
                JavaScriptSerializer js = new JavaScriptSerializer();


                JSONDic = js.Deserialize<Dictionary<string, object>>(jsonStr.ToString());
                JSONDeserialized = "";

                Object definition;
                if(JSONDic.TryGetValue("definition", out definition)){
                    Console.WriteLine(definition.ToString());
                }

                Object partsOfSpeech;
                if (JSONDic.TryGetValue("lexicalCategory", out partsOfSpeech))
                {
                    Console.WriteLine(partsOfSpeech.ToString());
                }

                Console.WriteLine(jsonStr);
            }
            Console.ReadLine();
        }
    }
}

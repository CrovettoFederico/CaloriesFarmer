using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CaloriasFarm.Utils {
    public static class JsonHandler {


        public static T ReadFile<T>(string JsonFile) {
            string file = File.ReadAllText(JsonFile);
            return JsonConvert.DeserializeObject<T>(file);
        }

        public static void WriteFile<T>(string JsonFile , T obj) {
            string FileContent = JsonConvert.SerializeObject(obj);
            File.WriteAllText(JsonFile, FileContent);
        }

    }
}

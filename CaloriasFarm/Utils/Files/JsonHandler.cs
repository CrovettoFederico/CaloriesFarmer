using Newtonsoft.Json;


namespace CaloriasFarm.Utils.Files{
    public class JsonHandler : FileHandler{

        public object ReadFile<T>(string JsonFile){
            string file = File.ReadAllText(JsonFile);
            return JsonConvert.DeserializeObject<T>(file);
        }
        
        public void WriteFile<T>(string JsonFile, T obj){
            string FileContent = JsonConvert.SerializeObject(obj);
            File.WriteAllText(JsonFile, FileContent);
        }

    }
}

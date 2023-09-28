using Newtonsoft.Json;

namespace JsonSerializer
{
    public static class JsonEnjoyer
    {
        public static T getInfo<T>(string path)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
        public static void saveInfo<T>(string path, T list)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(list));
        }


    }
}
using Newtonsoft.Json;
using System.Reflection;

namespace Core
{
    public class HS256
    {
        public string Key { get; set; }

        public HS256(string secretPath)
        {
            this.Key = this.ReadSecret(secretPath);
        }

        public HS256() 
            : this ("Core/secret.json")
        {
        }

        public void Encode(string base64Encoding, string key) 
        {
            throw new NotImplementedException();
        }

        private string ReadSecret(string fromCoreDirectoryPath) 
        {
            using TextReader r = new StreamReader(
                Path.Combine(
                    Assembly.GetExecutingAssembly().Location!,
                    fromCoreDirectoryPath));

            return JsonConvert.DeserializeObject<Key>(r.ReadToEnd()).Secret;
        }
    }
}

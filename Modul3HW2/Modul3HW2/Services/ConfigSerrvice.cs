using System.IO;
using Modul3HW2.Configs;
using Modul3HW2.Services.Abstractions;
using Newtonsoft.Json;

namespace Modul3HW2.Services
{
    public class ConfigSerrvice : IConfigService
    {
        private void Serialize(Config config)
        {
            var json = JsonConvert.SerializeObject(config);
            File.WriteAllText(@"E:\A-Level\YurecGusar\Modul3HW2\Modul3HW2\Modul3HW2\config.json", json);
        }

        private Config DeSerialize()
        {
            var readFile = File.ReadAllText(@"E:\A-Level\YurecGusar\Modul3HW2\Modul3HW2\Modul3HW2\config.json");
            var config = JsonConvert.DeserializeObject<Config>(readFile);
            return config;
        }
    }
}

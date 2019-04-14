using Newtonsoft.Json;

namespace BcInstaller.Entities.Index
{
    public class MinecraftIndexDownload
    {
        [JsonProperty("client")]
        public Download Client { get; set; }

        [JsonProperty("server")]
        public Download Server { get; set; }

        [JsonProperty("client")]
        public Download WindowsServer { get; set; }

        public class Download
        {
            [JsonProperty("sha1")]
            public string Hash { get; set; }

            [JsonProperty("size")]
            public long Size { get; set; }

            [JsonProperty("url")]
            public string Url { get; set; }
        }
    }
}

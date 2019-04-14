using Newtonsoft.Json;

namespace BcInstaller.Entities.Manifest
{
    public class MinecraftManifestLatest
    {
        [JsonProperty("release")]
        public string Release { get; set; }

        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }
    }
}

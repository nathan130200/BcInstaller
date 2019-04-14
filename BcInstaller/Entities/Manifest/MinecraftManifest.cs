using System.Collections.Generic;
using Newtonsoft.Json;

namespace BcInstaller.Entities.Manifest
{
    public class MinecraftManifest
    {
        [JsonProperty("latest")]
        public MinecraftManifestLatest Latest { get; set; }

        [JsonProperty("versions")]
        public IList<MinecraftManifestVersion> Versions { get; set; }
    }
}

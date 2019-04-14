using System;
using Newtonsoft.Json;

namespace BcInstaller.Entities.Manifest
{
    public class MinecraftManifestVersion
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("time")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("releaseTime")]
        public DateTimeOffset ReleasedAt { get; set; }
    }
}

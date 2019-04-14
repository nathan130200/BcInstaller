using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BcInstaller.Entities.Index
{
    public class MinecraftIndex
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sha1")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("totalSize")]
        public long TotalSize { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

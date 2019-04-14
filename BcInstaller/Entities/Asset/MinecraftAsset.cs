using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BcInstaller.Entities.Asset
{
    public class MinecraftAsset
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }
    }
}

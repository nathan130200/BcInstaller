using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BcInstaller.Entities.Index;
using BcInstaller.Entities.Manifest;
using Newtonsoft.Json.Linq;

namespace BcInstaller
{
    public static class BcUtil
    {
        public const string VERSION_MANIFEST_URL = "https://launchermeta.mojang.com/mc/game/version_manifest.json";

        public static string ResolveMinecraftVersion()
        {
            var json = "{}";
            var req = (HttpWebRequest)WebRequest.Create(VERSION_MANIFEST_URL);
            req.Method = "GET";

            var res = (HttpWebResponse) req.GetResponse();

            if(res.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Não foi possível recuperar as versões do minecraft! Erro interno no servidor.");
                Environment.Exit(1);
            }

            using (var stream = res.GetResponseStream())
            using (var sr = new StreamReader(stream))
            {
                json = sr.ReadToEnd();
            }

            var mf = JObject.Parse(json)
                .ToObject<MinecraftManifest>();

            if (mf.Versions == null)
            {
                MessageBox.Show("Não foi possível resolver o minecraft! Versão não encontrada");
                Environment.Exit(1);
            }

            foreach (var version in mf.Versions)
            {
                if (version.Id == "1.7.10")
                    return version.Url;
                else
                    continue;
            }

            MessageBox.Show("Não foi possível resolver o minecraft! Versão não encontrada");
            Environment.Exit(1);
            return null;
        }

        public static MinecraftIndex GetIndex(this JObject jo)
        {
            return jo["assetIndex"].ToObject<MinecraftIndex>();
        }

        public static MinecraftIndexDownload GetDownload(this JObject jo)
        {
            return jo["downloads"].ToObject<MinecraftIndexDownload>();
        }

        public static string DownloadContentBlocking(string url)
        {
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";

            var res = req.GetResponse();
            var result = "";

            using (var sr = new StreamReader(res.GetResponseStream()))
                result = sr.ReadToEnd();

            return result;
        }

        public static void DownloadContentAsync(string url, Action<string> cb)
        {
            new Thread(() =>
            {
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "GET";

                var res = req.GetResponse();
                var result = "";

                using (var sr = new StreamReader(res.GetResponseStream()))
                    result = sr.ReadToEnd();

                cb(result);
            }).Start();
        }

        private static readonly string[] SIZES_TABLE = new[] { "B", "KB", "MB", "GB", "TB" };

        public static string GetHumanReadableFileSize(long size)
        {
            int pos = 0;

            while(size >= 1024 && pos < SIZES_TABLE.Length-1)
            {
                pos++;
                size /= 1024;
            }

            return $"{size:0.##}{SIZES_TABLE[pos]}";
        }
    }
}

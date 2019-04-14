using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using BcInstaller.Entities;
using BcInstaller.Entities.Asset;
using BcInstaller.Extensions;
using BcInstaller.Properties;
using Newtonsoft.Json.Linq;

namespace BcInstaller.Forms.Installer
{
    public partial class DownloadAssetsForm : Form
    {
        class QueueItem
        {
            public string Url;
            public string VirtualPath;
            public string Hash;
            public long Size;
            public string Path;
        }

        private bool done;
        private WebClient client = new WebClient();
        private JObject manifest;
        private Queue<QueueItem> queue;
        private object locker = new object();

        public DownloadAssetsForm(JObject mf)
        {
            manifest = mf;
            queue = new Queue<QueueItem>();

            InitializeComponent();

            Icon = Resources.App;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!done)
                e.Cancel = true;
        }

        void WriteOk()
        {
            var fileinfo = new FileInfo(BcEnvironment.R.InstallPath + @"\install\.assets");

            if (!fileinfo.Directory.Exists)
                fileinfo.Directory.Create();

            fileinfo.Create().Close();
        }

        void OnDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled || e.Error != null)
            {
                var item = (QueueItem)e.UserState;

                lock (locker)
                    queue.Enqueue(item);

                return;
            }
            else
            {
                VerifyHash((QueueItem)e.UserState);
            }
        }

        void VerifyHash(QueueItem item)
        {
            var match = false;
            var hashstr = "";

            using (var sha1 = SHA1.Create())
            {
                var buf = File.ReadAllBytes(item.Path);
                var hash = sha1.ComputeHash(buf);
                hashstr = BitConverter.ToString(hash, 0)
                    .Replace("-", string.Empty)
                    .ToLowerInvariant();

                if (hashstr != item.Hash)
                    match = false;
                else
                    match = true;

                buf = null;
                hash = null;
            }

            if (!match)
                MessageBox.Show("A verificação hash no arquivo \"" + item.VirtualPath + "\" não confere!\nExpectativa: " + item.Hash + "\nRealidade: " + hashstr, "Verificação hash malsucedida");

            pbTotal.InvokeSafe(x => x.PerformStep());
            DownloadNextAsync();
        }

        void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pbCurrent.InvokeSafe(x => x.Value = e.ProgressPercentage);

            var item = (QueueItem)e.UserState;

            this.InvokeSafe(_ =>
            {
                lbFileName.Text = item.VirtualPath;
                lbFileSize.Text = BcUtil.GetHumanReadableFileSize(e.TotalBytesToReceive);
                lbHash.Text = item.Hash;
                lbPath.Text = item.Path;
            });
        }

        void DownloadNextAsync()
        {
            QueueItem prox = null;

            lock (locker)
            {
                if (queue.Any())
                    prox = queue.Dequeue();
            }

            if (prox == null)
            {
                WriteOk();
                done = true;
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            var fileinfo = new FileInfo(prox.Path);

            if (!fileinfo.Directory.Exists)
                fileinfo.Directory.Create();

            client.DownloadFileAsync(new Uri(prox.Url), prox.Path, prox);
        }

        bool IsOk()
        {
            var fileinfo = new FileInfo(BcEnvironment.R.InstallPath + @"\install\.assets");

            if (!fileinfo.Directory.Exists)
                fileinfo.Directory.Create();

            return fileinfo.Exists;
        }

        private void DownloadAssetsForm_Load(object sender, EventArgs e)
        {
            client.DownloadFileCompleted += OnDownloadCompleted;
            client.DownloadProgressChanged += OnDownloadProgressChanged;

            if (IsOk())
            {
                done = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }

            var directoryinfo = new DirectoryInfo(BcEnvironment.R.InstallPath + @"\minecraft\assets");

            if (!directoryinfo.Exists)
                directoryinfo.Create();

            var assets = manifest["objects"].ToObject<Dictionary<string, MinecraftAsset>>();

            lock (locker)
            {
                foreach (var asset in assets)
                {
                    var item = new QueueItem();

                    item.VirtualPath = asset.Key;
                    item.Path = directoryinfo.FullName + @"\" + asset.Value.Hash.Substring(0, 2) + "\\" + asset.Value.Hash;
                    item.Url = "http://resources.download.minecraft.net/" + asset.Value.Hash.Substring(0, 2) + "/" + asset.Value.Hash;
                    item.Size = asset.Value.Size;
                    item.Hash = asset.Value.Hash;

                    queue.Enqueue(item);
                }
            }

            this.pbTotal.Maximum = assets.Count;

            DownloadNextAsync();
        }
    }
}
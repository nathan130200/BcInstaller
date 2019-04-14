using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BcInstaller.Entities;
using BcInstaller.Entities.Manifest;
using BcInstaller.Extensions;
using BcInstaller.Properties;
using Newtonsoft.Json.Linq;

namespace BcInstaller.Forms.Installer
{
    public partial class DownloadMinecraftForm : Form
    {
        public DownloadMinecraftForm()
        {
            InitializeComponent();

            Icon = Resources.App;
        }

        private bool _done;

        private void DownloadMinecraftForm_Load(object sender, EventArgs e)
        {
            pbTotal.InvokeSafe(ctx => ctx.PerformStep());
            lbDesc.InvokeSafe(ctx => ctx.Text = "[2/5] Tarefa: Procurando assets...");

            var mjson = BcUtil.DownloadContentBlocking(BcUtil.ResolveMinecraftVersion());

            var manifest = JObject.Parse(mjson);
            BcEnvironment.R.Variables.Set("mc_manifest", manifest);

            var idx = manifest.GetIndex();

            pbTotal.InvokeSafe(ctx => ctx.PerformStep());
            lbDesc.InvokeSafe(ctx => ctx.Text = "[3/5] Tarefa: Baixando assets...");

            this.DisableWhile(() =>
            {
                var index = JObject.Parse(BcUtil.DownloadContentBlocking(idx.Url));

                using (var dlg = new DownloadAssetsForm(index))
                    dlg.ShowDialog();
            });

            pbTotal.InvokeSafe(ctx => ctx.PerformStep());
            lbDesc.InvokeSafe(ctx => ctx.Text = "[4/5] Tarefa: Baixando bibliotecas...");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = !_done;
        }
    }
}

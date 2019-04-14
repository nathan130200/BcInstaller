using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BcInstaller.Entities;
using BcInstaller.Extensions;

namespace BcInstaller
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();

            Icon = Properties.Resources.App;
        }

        private bool _done;

        private void SplashForm_Load(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory() + "/data";
            if (!File.Exists(path + "/modpack.json") && !Directory.Exists(path + "/minecraft/"))
            {
                BcEnvironment.R.IsInstalled = false;
            }
            else
            {
                BcEnvironment.R.IsInstalled = true;
                BcEnvironment.R.InstallPath = Directory.GetCurrentDirectory() + "/data/minecraft";
            }

            _done = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!_done)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}

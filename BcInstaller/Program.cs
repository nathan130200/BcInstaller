using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BcInstaller.Entities;
using BcInstaller.Forms.Installer;

namespace BcInstaller
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Contains("-Dev"))
                BcEnvironment.R.Variables.Set("dev", true);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var splash = new SplashForm())
                splash.ShowDialog();

            using (var dlg = new DownloadMinecraftForm())
                dlg.ShowDialog();
        }
    }
}

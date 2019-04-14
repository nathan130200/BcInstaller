using System;
using System.IO;
using System.Linq;
using System.Text;

namespace BcInstaller.Entities
{
    public sealed class BcEnvironment
    {
        private static object _locker = new object();
        private static BcEnvironment _instance;

        public static BcEnvironment R
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                        _instance = new BcEnvironment();

                    return _instance;
                }
            }
        }

        BcEnvironment()
        {

        }

        public bool IsInstalled { get; set; }
        public bool IsVerified { get; set; }
        public string InstallPath { get; set; } = Directory.GetCurrentDirectory();
        public string NativesPath { get; set; }
        public BcVariables Variables { get; } = new BcVariables();
    }
}

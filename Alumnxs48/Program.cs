using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnxs48
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.FirstRun)
            {
                Properties.Settings.Default.FirstRun = false;
                Properties.Settings.Default.Save();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                path = Path.Combine(new string[] {path, "Alumnxs", "dir"});
                Directory.CreateDirectory(path);
            }
            
            mls.langselector ls = new mls.langselector();
            
            Application.Run(ls);

            if (ls.UserSelectedLanguage)
            {
                Application.EnableVisualStyles();
            
                Application.Run(new Form1());
            }
        }
    }
}

using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Services;
using System.Threading;

namespace ProjektOOP
{
    

    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();
            if (applicationSettingsService.GetAplicationSettings()==null)
            {
                // default jezik je HR
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr-HR");
                var settingsForm = new SettingsForm();
                var result = settingsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Run(new FavoriteTeam());
                }
            }
            else
            {
                Application.Run(new FavoriteTeam());
            }
        }
    }
}

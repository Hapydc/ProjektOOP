using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Services;

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
                Application.Run(new SettingsForm());
            }
            else
            {

                Application.Run(new FavoriteTeam());

            }

            ITeamService teamService = null;

            //if (true)
            //{
            //    teamService = new TeamsAPIService();
            //}
            //else
            //{
            //    teamService = new TeamsFileService();
            //}

            //var teams = teamService.GetTeams();

            



        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using DataLayer.Models;
using DataLayer.Services;

namespace ProjektOOP
{
    public partial class FavoriteTeam : Form
    {
        private static string path = "https://worldcup.sfg.io/teams/";
        public FavoriteTeam()
        {
            InitializeComponent();
        }



        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            if (path.Contains("http"))
            {
                TeamsAPIService service = new TeamsAPIService();
                List<Team> teams = service.GetTeams(path);
                foreach (Team t in teams)
                {
                    string team = t.ToString();
                    cbTeams.Items.Add(team);
                };
            }
            else
            {
                TeamsFileService service = new TeamsFileService();
                List<Team> teams = service.GetTeams(path);
                foreach (Team t in teams)
                {
                    string team = t.ToString();
                    cbTeams.Items.Add(team);
                };
            }
        }

        private void btnFavoriteTeam_Click(object sender, EventArgs e)
        {

        }

        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

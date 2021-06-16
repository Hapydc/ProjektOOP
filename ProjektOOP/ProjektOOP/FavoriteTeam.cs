using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ProjektOOP
{
    public partial class FavoriteTeam : Form
    {
        private static string path = @"Resources\teams.json";
        public FavoriteTeam()
        {
            InitializeComponent();
        }



        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            LoadTeams(path);
        }

        private void LoadTeams(string path)
        {

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                List<Team> teams = JsonConvert.DeserializeObject<List<Team>>(json);
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

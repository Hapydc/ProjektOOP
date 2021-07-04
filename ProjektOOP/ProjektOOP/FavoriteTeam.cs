using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLayer.Models;
using DataLayer.Services;

namespace ProjektOOP
{
    
    public partial class FavoriteTeam : Form
    {
        private List<MatchResult> results = new List<MatchResult>();
        private List<Player> players = new List<Player>();
        private DataService service = new DataService();
        //pathovi za testno dohvacanje podataka timova
        private static string teamPath = @"Resources\teams.json";
        //private static string teamPath = "https://worldcup.sfg.io/teams/";

        //pathovi za dohvacanje podataka o utakmicama i igracima
        private static string matchesPath = @"Resources\matches.json";

        public FavoriteTeam()
        {
            InitializeComponent();         
        }
        private void FavoriteTeam_Load(object sender, EventArgs e)
        {  
            List<Team> teams = service.GetTeams(teamPath);
            foreach (Team t in teams)
            {
                cbTeams.Items.Add(t);
            }
        }
        private void btnFavoriteTeam_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var selectedTeam = (cbTeams.SelectedItem as Team).Country;
            lbCountryCode.Text = selectedTeam;       
            players =service.GetPlayers(selectedTeam);           
            foreach (Player p  in players)
            {            
                PlayerControl player = new PlayerControl(p);
                flowLayoutPanel1.Controls.Add(player);              
            }
            InitDnD();            
        }

        private void InitDnD()
        {
            flowLayoutPanel2.VerticalScroll.Visible = true;
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            flowLayoutPanel1.DragDrop += flowLayoutPanel1_DragDrop;
            flowLayoutPanel2.DragEnter += flowLayoutPanel2_DragEnter;
            flowLayoutPanel2.DragDrop += flowLayoutPanel2_DragDrop;
            
        }

        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {     
            PlayerControl playerControl = (PlayerControl)e.Data.GetData(typeof(PlayerControl));
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            
            e.Effect = DragDropEffects.Move;
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
           PlayerControl playerControl = (PlayerControl)e.Data.GetData(typeof(PlayerControl));
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {          
            e.Effect = DragDropEffects.Move;
        }
        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void cbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }   
    }
}

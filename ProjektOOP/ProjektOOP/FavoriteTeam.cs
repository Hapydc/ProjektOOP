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




        public FavoriteTeam()
        {
            InitializeComponent();
            
        }
        private void FavoriteTeam_Load(object sender, EventArgs e)
        {
            string country = DataService.GetFavoriteTeam();
            List<Team> teams = service.GetTeams(teamPath);
            foreach (Team t in teams)
            {

                cbTeams.Items.Add(t);
                if (t.ToString()==country)
                {
                    cbTeams.SelectedItem = t;
                }
            }
            
            
            
        }
        private void btnFavoriteTeam_Click(object sender, EventArgs e)
        {
            List<Player> favoritePlayers = DataService.ReadFavoritePlayers();
            
            flowLayoutPanel1.Controls.Clear();
            var selectedTeam = (cbTeams.SelectedItem as Team).Country;
            lbCountryCode.Text = selectedTeam;       
            players =service.GetPlayers(selectedTeam);           
            foreach (Player p  in players)
            {
               
                if (favoritePlayers.Find(x => x.Name == p.Name)!=null)
                {
                    PlayerControl player = new PlayerControl(p);
                    flowLayoutPanel2.Controls.Add(player);
                }
                else
                {
                    PlayerControl player = new PlayerControl(p);
                    flowLayoutPanel1.Controls.Add(player);
                }
                           
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
            flowLayoutPanel2.Controls.Add(playerControl);
            playerControl.FavoriteStar(true);
            
        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
           PlayerControl playerControl = (PlayerControl)e.Data.GetData(typeof(PlayerControl));
            flowLayoutPanel1.Controls.Add(playerControl);
            playerControl.FavoriteStar(false);
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {          
            e.Effect = DragDropEffects.Move;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {

            
        
        }

        private void btnSaveFavoriteTeam_Click(object sender, EventArgs e)
        {
            List<Player> favoritePlayerList = new List<Player>();
            foreach (var item in flowLayoutPanel2.Controls)
            {
                if (item is PlayerControl)
                {
                    PlayerControl playerControl = item as PlayerControl;
                    
                    Player player = new Player();
                    player = playerControl.SetPlayerValues(playerControl);
                    favoritePlayerList.Add(player);
                }
            }
            string country = cbTeams.SelectedItem.ToString();
            DataService.WriteFavoriteTeam(country);
            DataService.WriteFavoritePlayers(favoritePlayerList);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
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


        public FavoriteTeam()
        {
            InitializeComponent();
            this.VerticalScroll.Visible = true;
            this.FormClosed += OnClosed;
        }
        private void FavoriteTeam_Load(object sender, EventArgs e)
        {         
            LoadTeamsInForm();
        }
        public void LoadTeamsInForm()
        {
            cbTeams.Items.Clear();
            lbCountryCode.Text = null;
            string country = service.GetFavoriteTeam();
            List<Team> teams = service.GetTeams();
            foreach (Team t in teams)
            {
                cbTeams.Items.Add(t);
                if (t.ToString() == country)
                {
                    cbTeams.SelectedItem = t;
                }
            }
            lbCountryCode.Text = country;
            LoadPlayers();

        }
        private void btnFavoriteTeam_Click(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            flowLayoutPanel2.Controls.Clear();
            List<Player> favoritePlayers = service.ReadFavoritePlayers();
            flowLayoutPanel1.Controls.Clear();
            var selectedTeam = (cbTeams.SelectedItem as Team)?.Country;
            if (selectedTeam != null)
            {
                lbCountryCode.Text = selectedTeam;
                players = service.GetPlayers(selectedTeam);
                if (favoritePlayers == null)
                {
                    foreach (Player p in players)
                    {
                        PlayerControl player = new PlayerControl(p);
                        flowLayoutPanel1.Controls.Add(player);
                    }
                }
                else
                {
                    foreach (Player p in players)
                    {

                        if (favoritePlayers.Find(x => x.Name == p.Name) != null)
                        {
                            PlayerControl player = new PlayerControl(p);
                            flowLayoutPanel2.Controls.Add(player);
                            player.FavoriteStar(true);
                        }
                        else
                        {
                            PlayerControl player = new PlayerControl(p);
                            flowLayoutPanel1.Controls.Add(player);
                        }
                    }
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
        public void OnSettingsFormClosed(object sender, FormClosedEventArgs e)
        {

            LoadTeamsInForm();

        }

        public void OnClosed(object sender, FormClosedEventArgs e)
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
            service.WriteFavoriteTeam(country);
            service.WriteFavoritePlayers(favoritePlayerList);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {

            SettingsForm settingsForm = new SettingsForm();
            settingsForm.FormClosed += OnSettingsFormClosed;
            settingsForm.Show();

        }

        private void btnGoals_Click(object sender, EventArgs e)
        {
            string selectedTeam = (cbTeams.SelectedItem as Team)?.Country;
            if (selectedTeam == null)
            {
                MessageBox.Show("Odaberite tim za koji zelite statistiku golova");
            }
            else
            {
                service.SetSelectedTeam(selectedTeam);
                GoalsStatistics goalsStatisticsForm = new GoalsStatistics();
                goalsStatisticsForm.Show();
            }

                  
        }

        private void btnYellowCardsForm_Click(object sender, EventArgs e)
        {
            string selectedTeam = (cbTeams.SelectedItem as Team)?.Country;
            if (selectedTeam == null)
            {
                MessageBox.Show("Odaberite tim za koji zelite statistiku zutih kartona");
            }
            else
            {
                service.SetSelectedTeam(selectedTeam);
                YellowCardsStatistics yellowCardsStatistics = new YellowCardsStatistics();
                yellowCardsStatistics.Show();
            }
        }

        private void btnGamesInfo_Click(object sender, EventArgs e)
        {
            string selectedTeam = (cbTeams.SelectedItem as Team)?.Country;
            if (selectedTeam == null)
            {
                MessageBox.Show("Odaberite tim za koji zelite statistiku zutih kartona");
            }
            else
            {
                service.SetSelectedTeam(selectedTeam);
                GamesInfoForm gamesInfoForm = new GamesInfoForm();
                gamesInfoForm.Show();
            }

        }
    }
}

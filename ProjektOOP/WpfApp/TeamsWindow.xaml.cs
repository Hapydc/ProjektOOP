using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for TeamsWindow.xaml
    /// </summary>
    public partial class TeamsWindow : Window
    {
        public DataService service = new DataService();
        public string result;
        public TeamInformation favoriteTeamInformation = new TeamInformation();
        public TeamInformation opponentTeamInformation = new TeamInformation();
        public List<Team> teams = new List<Team>();

        public TeamsWindow()
        {
            InitializeComponent();

        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            LoadTeamsInForm();
        }
        public void WindowClosed(object sender, EventArgs e)
        {
            if (cbFirst.SelectedItem != null)
            {
                string country = cbFirst.SelectedItem.ToString();
                service.WriteFavoriteTeam(country);
            }
        }

        public async void LoadTeamsInForm()
        {
            cbFirst.Items.Clear();
            string country = service.GetFavoriteTeam();

            await Task.Run(async () =>
            {
                teams = await service.GetTeams();
            });

            foreach (Team t in teams)
            {
                cbFirst.Items.Add(t);
                if (t.ToString() == country)
                {
                    cbFirst.SelectedItem = t;
                }
            }


        }

        private async Task GetTeamOpponents()
        {
            cbSecond.Items.Clear();
            List<Team> opponentTeams = new List<Team>();
            string selectedTeam = (cbFirst.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                opponentTeams = await service.GetOpponents(selectedTeam);
            });
            foreach (Team t in opponentTeams)
            {
                cbSecond.Items.Add(t);
            }
        }

        private async void ChosenFavoriteTeam(object sender, SelectionChangedEventArgs e)
        {
            await GetTeamOpponents();
            

        }


        private async void OpponentTeamChosen(object sender, SelectionChangedEventArgs e)
        {

            string selectedFavoriteTeam = (cbFirst.SelectedItem as Team)?.Country;
            string selectedOpponentTeam = (cbSecond.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                result = await service.GetScore(selectedFavoriteTeam, selectedOpponentTeam);
            });
            lblResult.Content = result;
            List<Player> players = new List<Player>();
            await Task.Run(async () =>
            {
                players = await service.GetPlayers(selectedFavoriteTeam);
            });
            

            foreach (Player player in players)
            {
                PlayerControl playerControl = new PlayerControl(player);
                switch (player.Position)
                {
                    case "Goalie":
                        Grid.SetRow(playerControl, 1);
                        Grid.SetColumn(playerControl, 0);
                        teamsGrid.Children.Add(playerControl);
                        break;
                    case "Defender":
                        Grid.SetColumn(playerControl, 1);
                        teamsGrid.Children.Add(playerControl);
                        break;
                    case "Midfield":
                        Grid.SetColumn(playerControl, 2);
                        teamsGrid.Children.Add(playerControl);
                        break;
                    case "Forward":
                        
                        Grid.SetColumn(playerControl, 3);
                        teamsGrid.Children.Add(playerControl);
                        break;

                }
            }


        }

        private async void btnFavoriteTeamDetails(object sender, RoutedEventArgs e)
        {
            TeamInformation teamInformation = new TeamInformation();
            string selectedCountry = (cbFirst.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                teamInformation = await service.GetTeamInformation(selectedCountry);
            });
            Window teamInfo = new TeamInfo(teamInformation);
            teamInfo.Show();
        }
        private async void btnOpponentTeamDetails(object sender, RoutedEventArgs e)
        {
            TeamInformation teamInformation = new TeamInformation();
            string selectedCountry = (cbSecond.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                teamInformation = await service.GetTeamInformation(selectedCountry);
            });
            Window teamInfo = new TeamInfo(teamInformation);
            teamInfo.Show();


        }

    }
}

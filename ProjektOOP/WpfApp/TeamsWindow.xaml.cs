using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        public Language language;

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
            firstGridDeffender.Children.Clear();
            firstGridGoalie.Children.Clear();
            firstGridMidfield.Children.Clear();
            firstGridForward.Children.Clear();
            secondGridDeffender.Children.Clear();
            secondGridGoalie.Children.Clear();
            secondGridMidfield.Children.Clear();
            secondGridForward.Children.Clear();

            string selectedFavoriteTeam = (cbFirst.SelectedItem as Team)?.Country;
            string selectedOpponentTeam = (cbSecond.SelectedItem as Team)?.Country;
            List<TeamEvent> homeTeamEvents = await service.GetEvents(selectedFavoriteTeam, selectedOpponentTeam);
            List<TeamEvent> opponentTeamEvents = await service.GetEvents(selectedOpponentTeam, selectedFavoriteTeam);

            await Task.Run(async () =>
            {
                result = await service.GetScore(selectedFavoriteTeam, selectedOpponentTeam);
            });
            lblResult.Content = result;
            List<Player> favoriteTeamplayers = new List<Player>();
            await Task.Run(async () =>
            {
                favoriteTeamplayers = await service.GetStartingEleven(selectedFavoriteTeam, selectedOpponentTeam);
            });
            List<Player> opponentTeamPlayers = new List<Player>();
            await Task.Run(async () =>
            {
                opponentTeamPlayers = await service.GetStartingEleven(selectedOpponentTeam, selectedFavoriteTeam);
            });



            int midfield = 0;
            int defender = 0;
            int attacker = 0;
            foreach (Player player in favoriteTeamplayers)
            {

                PlayerControl playerControl = new PlayerControl(player, homeTeamEvents);
                var imagePath = $"{System.IO.Path.GetTempPath()}{player.Name}.txt";
                if (File.Exists(imagePath))
                {
                    playerControl.SetPicture(File.ReadAllText(imagePath));
                }
                switch (player.Position)
                {
                    case "Goalie":
                        RowDefinition gridRow1 = new RowDefinition();
                        gridRow1.Height = GridLength.Auto;
                        firstGridGoalie.RowDefinitions.Add(gridRow1);
                        Grid.SetRow(playerControl, 1);
                        firstGridGoalie.Children.Add(playerControl);

                        break;
                    case "Defender":
                        RowDefinition deffenderRow = new RowDefinition();
                        deffenderRow.Height = GridLength.Auto;
                        firstGridDeffender.RowDefinitions.Add(deffenderRow);
                        Grid.SetRow(playerControl, defender);
                        firstGridDeffender.Children.Add(playerControl);
                        defender++;
                        break;
                    case "Midfield":
                        RowDefinition midfieldRow = new RowDefinition();
                        midfieldRow.Height = GridLength.Auto;
                        firstGridMidfield.RowDefinitions.Add(midfieldRow);
                        Grid.SetRow(playerControl, midfield);
                        firstGridMidfield.Children.Add(playerControl);
                        midfield++;
                        break;
                    case "Forward":

                        RowDefinition forwardRow = new RowDefinition();
                        forwardRow.Height = GridLength.Auto;
                        firstGridForward.RowDefinitions.Add(forwardRow);
                        Grid.SetRow(playerControl, attacker);
                        firstGridForward.Children.Add(playerControl);
                        attacker++;
                        break;
                }
            }
            midfield = 0;
            defender = 0;
            attacker = 0;
            foreach (Player player in opponentTeamPlayers)
            {
                PlayerControl playerControl = new PlayerControl(player, opponentTeamEvents);
                switch (player.Position)
                {
                    case "Goalie":
                        RowDefinition gridRow1 = new RowDefinition();
                        gridRow1.Height = GridLength.Auto;
                        secondGridGoalie.RowDefinitions.Add(gridRow1);
                        Grid.SetRow(playerControl, 1);
                        secondGridGoalie.Children.Add(playerControl);

                        break;
                    case "Defender":
                        RowDefinition secondDeffenderRow = new RowDefinition();
                        secondDeffenderRow.Height = GridLength.Auto;
                        secondGridDeffender.RowDefinitions.Add(secondDeffenderRow);
                        Grid.SetRow(playerControl, defender);
                        secondGridDeffender.Children.Add(playerControl);
                        defender++;
                        break;
                    case "Midfield":
                        RowDefinition secondMidfieldRow = new RowDefinition();
                        secondMidfieldRow.Height = GridLength.Auto;
                        secondGridMidfield.RowDefinitions.Add(secondMidfieldRow);
                        Grid.SetRow(playerControl, midfield);
                        secondGridMidfield.Children.Add(playerControl);
                        midfield++;
                        break;
                    case "Forward":

                        RowDefinition secondForwardRow = new RowDefinition();
                        secondForwardRow.Height = GridLength.Auto;
                        secondGridForward.RowDefinitions.Add(secondForwardRow);
                        Grid.SetRow(playerControl, attacker);
                        secondGridForward.Children.Add(playerControl);
                        attacker++;
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

        private void OpenSettingsWindow(object sender, RoutedEventArgs e)
        {
            Window settings = new MainWindow();
            settings.Show();
            this.Hide();
        }
    }
}

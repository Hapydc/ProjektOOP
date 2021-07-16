﻿using DataLayer.Models;
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
            List<Team> teams = new List<Team>();
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
            favoriteTeamInformation = cbFirst.SelectedItem as TeamInformation;

        }

        private async void OpponentTeamChosen(object sender, SelectionChangedEventArgs e)
        {
           
            string selectedFavoriteTeam = (cbFirst.SelectedItem as Team)?.Country;
            string selectedOpponentTeam = (cbSecond.SelectedItem as Team)?.Country;
            await Task.Run(async () =>
            {
                 result= await service.GetScore(selectedFavoriteTeam, selectedOpponentTeam);
            });
            lblResult.Content = result;
                       
        }

        private void btnFavoriteTeamDetails(object sender, RoutedEventArgs e)
        {
            Window teamInfo = new TeamInfo(favoriteTeamInformation);
            teamInfo.Show();
        }

        private void btnOpponentTeamDetails(object sender, RoutedEventArgs e)
        {

        }
    }
}

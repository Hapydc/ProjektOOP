using DataLayer.Models;
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
    /// Interaction logic for TeamInfo.xaml
    /// </summary>
    public partial class TeamInfo : Window
    {
        public TeamInfo(TeamInformation teamInformation)
        {
            InitializeComponent();
            lblName.Content = teamInformation.Country;
            lblFifaCode.Content = teamInformation.FifaCode;
            lblGames.Content = teamInformation.GamesPlayed.ToString();
            lblWins.Content = teamInformation.Wins.ToString();
            lblDefeats.Content = teamInformation.Losses.ToString();
            lblDraws.Content = teamInformation.Draws.ToString();
            lblScored.Content = teamInformation.GoalsFor.ToString();
            lblRecieved.Content = teamInformation.GoalsAgainst.ToString();
            lblGoalDiff.Content = teamInformation.GoalDifferential.ToString();

        }
    }
}

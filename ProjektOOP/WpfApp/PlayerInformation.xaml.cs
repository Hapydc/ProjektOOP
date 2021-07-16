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
    /// Interaction logic for PlayerInformation.xaml
    /// </summary>
    public partial class PlayerInformation : Window
    {
        public PlayerInformation(Player player,int goals, int yellowCards)
        {              
            InitializeComponent();
            lblName.Content = $"{player.Name}";
            lblShirtNumber.Content = $"{player.ShirtNumber}";
            lblPosition.Content = $"{player.Position}";
            lblCaptain.Content = $"{player.Captain}";
            lblGoals.Content = $"{goals}";
            lblYellowCards.Content = $"{yellowCards}";

        }
    }
}

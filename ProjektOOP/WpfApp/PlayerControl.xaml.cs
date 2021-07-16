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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PlayerControl.xaml
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        public Player Player { get; set; }
        int goals = 0;
        int yellowCards = 0;

        public PlayerControl()
        {
            InitializeComponent();

        }
        public PlayerControl(Player player, List<TeamEvent>events)
        {
            InitializeComponent();
            Player = player;
            this.DataContext = Player;
           

            foreach (var e in events)
            {
                if (e.TypeOfEvent=="goal" || e.TypeOfEvent =="goal-penalty" )
                {
                    if (player.Name.ToString()==e.Player)
                    {
                        goals++;
                    }
                }
                if (e.TypeOfEvent== "yellow-card")
                {
                    if (player.Name.ToString() == e.Player)
                    {
                        yellowCards++;
                    }
                }
            }

        }

        private void lblPlayerName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Window playerInformation = new PlayerInformation(Player, goals, yellowCards);
            playerInformation.Show();

        }
    }
}

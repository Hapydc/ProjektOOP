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
        public PlayerControl()
        {
            InitializeComponent();

        }
        public PlayerControl(Player player)
        {
            InitializeComponent();
            Player = player;
            this.DataContext = Player;
            
        }

        private void lblPlayerName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show($"Kliknuli ste na igrača {Player.Name}");
        }
    }
}

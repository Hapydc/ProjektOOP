using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Models;

namespace ProjektOOP
{
    public partial class PlayerControl : UserControl
    {
        public PlayerControl()
        {
            InitializeComponent();
        }

       public PlayerControl(Player player)
        {
            InitializeComponent();
            Player plyr = player;
            lblName.Text = plyr.Name;
            lblNumber.Text = plyr.ShirtNumber.ToString();
            lblPosition.Text = plyr.Position;
            lblCaptain.Text = plyr.Captain.ToString();
        } 
       public void setPicture(string path)
        {
            pBplayerPicture.Image = Image.FromFile(path);
        }

        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}

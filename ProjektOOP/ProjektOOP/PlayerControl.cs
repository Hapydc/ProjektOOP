﻿using System;
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
        public Player player;
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
        public Player SetPlayerValues(PlayerControl playerControl)
        {
            Player player = new Player();
            player.Name = playerControl.lblName.Text;
            long l1;
            l1 = long.Parse(playerControl.lblNumber.Text);
            player.ShirtNumber = l1;
            player.Position = playerControl.lblPosition.Text;
            player.Captain = Convert.ToBoolean(lblCaptain.Text);
            return player;
        }

        public void FavoriteStar(bool star)
        {
            pbFavoritePlayer.Image = null;
            if (star)
            { 
                pbFavoritePlayer.Image = Image.FromFile(@"Resources\Pictures\MyStar.png");
               
            }
            else
            {
                pbFavoritePlayer.Image = null;
            }
        }
        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Move);
        }
    }
}

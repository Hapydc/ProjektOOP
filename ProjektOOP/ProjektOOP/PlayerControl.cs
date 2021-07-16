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
using System.IO;

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
            lblNameTag.Text = TranslationService.GetTranslationByKey("lblNameTag");
            lblShirtNumberTag.Text = TranslationService.GetTranslationByKey("lblShirtNumberTag");
            lblPositionTag.Text = TranslationService.GetTranslationByKey("lblPositionTag");
            lblCaptTag.Text = TranslationService.GetTranslationByKey("lblCaptTag");

            Player plyr = player;
            lblName.Text = plyr.Name;
            lblNumber.Text = plyr.ShirtNumber.ToString();

            lblPosition.Text = plyr.Position;
            if (plyr.Captain==true)
            {
                lblCaptain.Text = TranslationService.GetTranslationByKey("captainYes");
            }
            else
            {
                lblCaptain.Text = TranslationService.GetTranslationByKey("captainNo");
            }
        } 

        public Player SetPlayerValues(PlayerControl playerControl)
        {
            Player player = new Player();
            player.Name = playerControl.lblName.Text;
            long l1;
            l1 = long.Parse(playerControl.lblNumber.Text);
            player.ShirtNumber = l1;
            player.Position = playerControl.lblPosition.Text;
            if (lblCaptain.Text==TranslationService.GetTranslationByKey("captainYes"))
            {
                player.Captain = true;
            }
            else
            {
                player.Captain = false;
            }
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

        public void SetPicture(string path)
        {
            var exists = File.Exists(path);
            pBplayerPicture.Image = Image.FromFile(path);
        }


        private void PlayerControl_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(sender, DragDropEffects.Move);
        }

        public void SetGoalsOrCardsValue(string value)
        {
            lblGoals.Text = value;
            lblGoals.Visible = true;
        }

        private void lblCaptain_Click(object sender, EventArgs e)
        {

        }
    }
}

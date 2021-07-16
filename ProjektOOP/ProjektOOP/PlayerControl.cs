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
        public Player Player { get; set; }
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

            Player = player;
            lblName.Text = Player.Name;
            lblNumber.Text = Player.ShirtNumber.ToString();

            lblPosition.Text = Player.Position;
            if (Player.Captain==true)
            {
                lblCaptain.Text = TranslationService.GetTranslationByKey("captainYes");
            }
            else
            {
                lblCaptain.Text = TranslationService.GetTranslationByKey("captainNo");
            }
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

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files |*.png;*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pBplayerPicture.Image = new Bitmap(opnfd.FileName);
                File.WriteAllText($"{System.IO.Path.GetTempPath()}{Player.Name}.txt", opnfd.FileName);
            }
            
        }
    }
}

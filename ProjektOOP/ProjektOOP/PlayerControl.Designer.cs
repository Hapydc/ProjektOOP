    namespace ProjektOOP
{
    partial class PlayerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameTag = new System.Windows.Forms.Label();
            this.lblShirtNumberTag = new System.Windows.Forms.Label();
            this.lblPositionTag = new System.Windows.Forms.Label();
            this.lblCaptTag = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.pBplayerPicture = new System.Windows.Forms.PictureBox();
            this.pbFavoritePlayer = new System.Windows.Forms.PictureBox();
            this.lblGoals = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavoritePlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameTag
            // 
            this.lblNameTag.AutoSize = true;
            this.lblNameTag.Location = new System.Drawing.Point(10, 21);
            this.lblNameTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameTag.Name = "lblNameTag";
            this.lblNameTag.Size = new System.Drawing.Size(30, 17);
            this.lblNameTag.TabIndex = 0;
            this.lblNameTag.Text = "Ime";
            // 
            // lblShirtNumberTag
            // 
            this.lblShirtNumberTag.AutoSize = true;
            this.lblShirtNumberTag.Location = new System.Drawing.Point(10, 70);
            this.lblShirtNumberTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShirtNumberTag.Name = "lblShirtNumberTag";
            this.lblShirtNumberTag.Size = new System.Drawing.Size(33, 17);
            this.lblShirtNumberTag.TabIndex = 1;
            this.lblShirtNumberTag.Text = "Broj";
            // 
            // lblPositionTag
            // 
            this.lblPositionTag.AutoSize = true;
            this.lblPositionTag.Location = new System.Drawing.Point(10, 128);
            this.lblPositionTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPositionTag.Name = "lblPositionTag";
            this.lblPositionTag.Size = new System.Drawing.Size(56, 17);
            this.lblPositionTag.TabIndex = 2;
            this.lblPositionTag.Text = "Pozicija";
            // 
            // lblCaptTag
            // 
            this.lblCaptTag.AutoSize = true;
            this.lblCaptTag.Location = new System.Drawing.Point(10, 182);
            this.lblCaptTag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptTag.Name = "lblCaptTag";
            this.lblCaptTag.Size = new System.Drawing.Size(61, 17);
            this.lblCaptTag.TabIndex = 3;
            this.lblCaptTag.Text = "Kapetan";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(105, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Ime";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(105, 70);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(33, 17);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Broj";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(105, 128);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(56, 17);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Pozicija";
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(105, 182);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(61, 17);
            this.lblCaptain.TabIndex = 8;
            this.lblCaptain.Text = "Kapetan";
            // 
            // pBplayerPicture
            // 
            this.pBplayerPicture.Location = new System.Drawing.Point(305, 144);
            this.pBplayerPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBplayerPicture.Name = "pBplayerPicture";
            this.pBplayerPicture.Size = new System.Drawing.Size(165, 175);
            this.pBplayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBplayerPicture.TabIndex = 9;
            this.pBplayerPicture.TabStop = false;
            // 
            // pbFavoritePlayer
            // 
            this.pbFavoritePlayer.BackColor = System.Drawing.SystemColors.Control;
            this.pbFavoritePlayer.Location = new System.Drawing.Point(305, 17);
            this.pbFavoritePlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFavoritePlayer.Name = "pbFavoritePlayer";
            this.pbFavoritePlayer.Size = new System.Drawing.Size(73, 70);
            this.pbFavoritePlayer.TabIndex = 10;
            this.pbFavoritePlayer.TabStop = false;
            // 
            // lblGoals
            // 
            this.lblGoals.AutoSize = true;
            this.lblGoals.Location = new System.Drawing.Point(10, 223);
            this.lblGoals.Name = "lblGoals";
            this.lblGoals.Size = new System.Drawing.Size(46, 17);
            this.lblGoals.TabIndex = 11;
            this.lblGoals.Text = "label5";
            this.lblGoals.Visible = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(375, 99);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(95, 40);
            this.btnUploadImage.TabIndex = 12;
            this.btnUploadImage.Text = "Postavi sliku";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.lblGoals);
            this.Controls.Add(this.pbFavoritePlayer);
            this.Controls.Add(this.pBplayerPicture);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCaptTag);
            this.Controls.Add(this.lblPositionTag);
            this.Controls.Add(this.lblShirtNumberTag);
            this.Controls.Add(this.lblNameTag);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(485, 322);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavoritePlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameTag;
        private System.Windows.Forms.Label lblShirtNumberTag;
        private System.Windows.Forms.Label lblPositionTag;
        private System.Windows.Forms.Label lblCaptTag;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.PictureBox pBplayerPicture;
        private System.Windows.Forms.PictureBox pbFavoritePlayer;
        private System.Windows.Forms.Label lblGoals;
        private System.Windows.Forms.Button btnUploadImage;
    }
}

namespace ProjektOOP
{
    partial class FavoriteTeam
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.btnFavoriteTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountryCode = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnYellowCardsForm = new System.Windows.Forms.Button();
            this.btnGamesInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(28, 71);
            this.cbTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTeams.MaxDropDownItems = 50;
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(397, 21);
            this.cbTeams.TabIndex = 0;
            // 
            // btnFavoriteTeam
            // 
            this.btnFavoriteTeam.Location = new System.Drawing.Point(452, 54);
            this.btnFavoriteTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFavoriteTeam.Name = "btnFavoriteTeam";
            this.btnFavoriteTeam.Size = new System.Drawing.Size(92, 52);
            this.btnFavoriteTeam.TabIndex = 1;
            this.btnFavoriteTeam.Text = "Odaberi";
            this.btnFavoriteTeam.UseVisualStyleBackColor = true;
            this.btnFavoriteTeam.Click += new System.EventHandler(this.btnFavoriteTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite vaš tim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odabrana omiljena reprezentacija:";
            // 
            // lbCountryCode
            // 
            this.lbCountryCode.AutoSize = true;
            this.lbCountryCode.Location = new System.Drawing.Point(210, 115);
            this.lbCountryCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountryCode.Name = "lbCountryCode";
            this.lbCountryCode.Size = new System.Drawing.Size(70, 13);
            this.lbCountryCode.TabIndex = 4;
            this.lbCountryCode.Text = "Country code";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 175);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(387, 407);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(487, 175);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 407);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragDrop);
            this.flowLayoutPanel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragEnter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Omiljeni igrači";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(651, 33);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(121, 72);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Postavke";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnGoals
            // 
            this.btnGoals.Location = new System.Drawing.Point(838, 33);
            this.btnGoals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(122, 72);
            this.btnGoals.TabIndex = 10;
            this.btnGoals.Text = "Lista golova";
            this.btnGoals.UseVisualStyleBackColor = true;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            // 
            // btnYellowCardsForm
            // 
            this.btnYellowCardsForm.Location = new System.Drawing.Point(964, 33);
            this.btnYellowCardsForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYellowCardsForm.Name = "btnYellowCardsForm";
            this.btnYellowCardsForm.Size = new System.Drawing.Size(114, 72);
            this.btnYellowCardsForm.TabIndex = 11;
            this.btnYellowCardsForm.Text = "Lista zutih kartona";
            this.btnYellowCardsForm.UseVisualStyleBackColor = true;
            this.btnYellowCardsForm.Click += new System.EventHandler(this.btnYellowCardsForm_Click);
            // 
            // btnGamesInfo
            // 
            this.btnGamesInfo.Location = new System.Drawing.Point(964, 123);
            this.btnGamesInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGamesInfo.Name = "btnGamesInfo";
            this.btnGamesInfo.Size = new System.Drawing.Size(114, 72);
            this.btnGamesInfo.TabIndex = 12;
            this.btnGamesInfo.Text = "Podatci o utakmicama";
            this.btnGamesInfo.UseVisualStyleBackColor = true;
            this.btnGamesInfo.Click += new System.EventHandler(this.btnGamesInfo_Click);
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 774);
            this.Controls.Add(this.btnGamesInfo);
            this.Controls.Add(this.btnYellowCardsForm);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbCountryCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFavoriteTeam);
            this.Controls.Add(this.cbTeams);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FavoriteTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Button btnFavoriteTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountryCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.Button btnYellowCardsForm;
        private System.Windows.Forms.Button btnGamesInfo;
    }
}
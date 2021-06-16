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
            this.SuspendLayout();
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(37, 87);
            this.cbTeams.MaxDropDownItems = 50;
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(528, 24);
            this.cbTeams.TabIndex = 0;
            this.cbTeams.SelectedIndexChanged += new System.EventHandler(this.cbTeams_SelectedIndexChanged);
            // 
            // btnFavoriteTeam
            // 
            this.btnFavoriteTeam.Location = new System.Drawing.Point(603, 66);
            this.btnFavoriteTeam.Name = "btnFavoriteTeam";
            this.btnFavoriteTeam.Size = new System.Drawing.Size(123, 64);
            this.btnFavoriteTeam.TabIndex = 1;
            this.btnFavoriteTeam.Text = "Odaberi";
            this.btnFavoriteTeam.UseVisualStyleBackColor = true;
            this.btnFavoriteTeam.Click += new System.EventHandler(this.btnFavoriteTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite vaš tim";
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFavoriteTeam);
            this.Controls.Add(this.cbTeams);
            this.Name = "FavoriteTeam";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FavoriteTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Button btnFavoriteTeam;
        private System.Windows.Forms.Label label1;
    }
}
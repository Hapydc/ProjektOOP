﻿namespace ProjektOOP
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
            this.flowLayoutPanel2.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odabrana omiljena reprezentacija:";
            // 
            // lbCountryCode
            // 
            this.lbCountryCode.AutoSize = true;
            this.lbCountryCode.Location = new System.Drawing.Point(280, 142);
            this.lbCountryCode.Name = "lbCountryCode";
            this.lbCountryCode.Size = new System.Drawing.Size(92, 17);
            this.lbCountryCode.TabIndex = 4;
            this.lbCountryCode.Text = "Country code";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 273);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(482, 175);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(244, 273);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragDrop);
            this.flowLayoutPanel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel2_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Omiljeni igraci";
            // 
            // FavoriteTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbCountryCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFavoriteTeam);
            this.Controls.Add(this.cbTeams);
            this.Name = "FavoriteTeam";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FavoriteTeam_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
    }
}
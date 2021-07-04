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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.pBplayerPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Broj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pozicija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kapetan";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(98, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(30, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Ime";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(98, 57);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(33, 17);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Broj";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(98, 104);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(56, 17);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Pozicija";
            // 
            // lblCaptain
            // 
            this.lblCaptain.AutoSize = true;
            this.lblCaptain.Location = new System.Drawing.Point(98, 148);
            this.lblCaptain.Name = "lblCaptain";
            this.lblCaptain.Size = new System.Drawing.Size(61, 17);
            this.lblCaptain.TabIndex = 8;
            this.lblCaptain.Text = "Kapetan";
            // 
            // pBplayerPicture
            // 
            this.pBplayerPicture.Location = new System.Drawing.Point(227, 148);
            this.pBplayerPicture.Name = "pBplayerPicture";
            this.pBplayerPicture.Size = new System.Drawing.Size(166, 175);
            this.pBplayerPicture.TabIndex = 9;
            this.pBplayerPicture.TabStop = false;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBplayerPicture);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(396, 323);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerControl_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pBplayerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.PictureBox pBplayerPicture;
    }
}

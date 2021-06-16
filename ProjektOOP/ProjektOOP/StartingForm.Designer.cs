namespace ProjektOOP
{
    partial class StartingForm
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
            this.btnMaleChamp = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCroLng = new System.Windows.Forms.Button();
            this.btnEngLng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaleChamp
            // 
            this.btnMaleChamp.Location = new System.Drawing.Point(95, 137);
            this.btnMaleChamp.Name = "btnMaleChamp";
            this.btnMaleChamp.Size = new System.Drawing.Size(213, 120);
            this.btnMaleChamp.TabIndex = 0;
            this.btnMaleChamp.Text = "Muško prvenstvo";
            this.btnMaleChamp.UseVisualStyleBackColor = true;
            this.btnMaleChamp.Click += new System.EventHandler(this.btnMaleChamp_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(388, 137);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(213, 120);
            this.btn.TabIndex = 1;
            this.btn.Text = "Žensko prvenstvo";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberite prvenstvo";
            // 
            // btnCroLng
            // 
            this.btnCroLng.Location = new System.Drawing.Point(544, 13);
            this.btnCroLng.Name = "btnCroLng";
            this.btnCroLng.Size = new System.Drawing.Size(77, 28);
            this.btnCroLng.TabIndex = 3;
            this.btnCroLng.Text = "HRV";
            this.btnCroLng.UseVisualStyleBackColor = true;
            // 
            // btnEngLng
            // 
            this.btnEngLng.Location = new System.Drawing.Point(649, 13);
            this.btnEngLng.Name = "btnEngLng";
            this.btnEngLng.Size = new System.Drawing.Size(77, 28);
            this.btnEngLng.TabIndex = 4;
            this.btnEngLng.Text = "ENG";
            this.btnEngLng.UseVisualStyleBackColor = true;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.btnEngLng);
            this.Controls.Add(this.btnCroLng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnMaleChamp);
            this.Name = "StartingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaleChamp;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCroLng;
        private System.Windows.Forms.Button btnEngLng;
    }
}


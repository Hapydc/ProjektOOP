namespace ProjektOOP
{
    partial class SettingsForm
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
            this.rbMaleChampionship = new System.Windows.Forms.RadioButton();
            this.rbFemaleChampionship = new System.Windows.Forms.RadioButton();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbMaleChampionship
            // 
            this.rbMaleChampionship.AutoSize = true;
            this.rbMaleChampionship.Location = new System.Drawing.Point(20, 41);
            this.rbMaleChampionship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMaleChampionship.Name = "rbMaleChampionship";
            this.rbMaleChampionship.Size = new System.Drawing.Size(107, 17);
            this.rbMaleChampionship.TabIndex = 0;
            this.rbMaleChampionship.Text = "Muško prvenstvo";
            this.rbMaleChampionship.UseVisualStyleBackColor = true;
            // 
            // rbFemaleChampionship
            // 
            this.rbFemaleChampionship.AutoSize = true;
            this.rbFemaleChampionship.Location = new System.Drawing.Point(20, 77);
            this.rbFemaleChampionship.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFemaleChampionship.Name = "rbFemaleChampionship";
            this.rbFemaleChampionship.Size = new System.Drawing.Size(111, 17);
            this.rbFemaleChampionship.TabIndex = 1;
            this.rbFemaleChampionship.Text = "Žensko prvenstvo";
            this.rbFemaleChampionship.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            this.rbCroatian.AutoSize = true;
            this.rbCroatian.Location = new System.Drawing.Point(21, 41);
            this.rbCroatian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.Size = new System.Drawing.Size(64, 17);
            this.rbCroatian.TabIndex = 2;
            this.rbCroatian.Text = "Hrvatski";
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(21, 77);
            this.rbEnglish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(65, 17);
            this.rbEnglish.TabIndex = 3;
            this.rbEnglish.Text = "Engleski";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(18, 9);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(103, 13);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Odaberite prvenstvo";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(19, 9);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(77, 13);
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Odaberite jezik";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(474, 292);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(117, 64);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Potvrdi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(342, 292);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 64);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLanguage);
            this.panel1.Controls.Add(this.rbEnglish);
            this.panel1.Controls.Add(this.rbCroatian);
            this.panel1.Location = new System.Drawing.Point(302, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 126);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.rbMaleChampionship);
            this.panel2.Controls.Add(this.rbFemaleChampionship);
            this.panel2.Location = new System.Drawing.Point(50, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 126);
            this.panel2.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaleChampionship;
        private System.Windows.Forms.RadioButton rbFemaleChampionship;
        private System.Windows.Forms.RadioButton rbCroatian;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
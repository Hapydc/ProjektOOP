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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbMaleChampionship
            // 
            this.rbMaleChampionship.AutoSize = true;
            this.rbMaleChampionship.Location = new System.Drawing.Point(85, 71);
            this.rbMaleChampionship.Name = "rbMaleChampionship";
            this.rbMaleChampionship.Size = new System.Drawing.Size(136, 21);
            this.rbMaleChampionship.TabIndex = 0;
            this.rbMaleChampionship.TabStop = true;
            this.rbMaleChampionship.Text = "Muško prvenstvo";
            this.rbMaleChampionship.UseVisualStyleBackColor = true;
            // 
            // rbFemaleChampionship
            // 
            this.rbFemaleChampionship.AutoSize = true;
            this.rbFemaleChampionship.Location = new System.Drawing.Point(85, 116);
            this.rbFemaleChampionship.Name = "rbFemaleChampionship";
            this.rbFemaleChampionship.Size = new System.Drawing.Size(142, 21);
            this.rbFemaleChampionship.TabIndex = 1;
            this.rbFemaleChampionship.TabStop = true;
            this.rbFemaleChampionship.Text = "Žensko prvenstvo";
            this.rbFemaleChampionship.UseVisualStyleBackColor = true;
            // 
            // rbCroatian
            // 
            this.rbCroatian.AutoSize = true;
            this.rbCroatian.Location = new System.Drawing.Point(431, 71);
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.Size = new System.Drawing.Size(80, 21);
            this.rbCroatian.TabIndex = 2;
            this.rbCroatian.TabStop = true;
            this.rbCroatian.Text = "Hrvatski";
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Location = new System.Drawing.Point(431, 116);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(82, 21);
            this.rbEnglish.TabIndex = 3;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "Engleski";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Odaberite prvenstvo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odaberite jezik";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(632, 359);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 79);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Potvrdi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(456, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 79);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbCroatian);
            this.Controls.Add(this.rbFemaleChampionship);
            this.Controls.Add(this.rbMaleChampionship);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaleChampionship;
        private System.Windows.Forms.RadioButton rbFemaleChampionship;
        private System.Windows.Forms.RadioButton rbCroatian;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}
namespace ProjektOOP
{
    partial class GoalsStatistics
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
            this.flpGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpGoals
            // 
            this.flpGoals.AutoScroll = true;
            this.flpGoals.Location = new System.Drawing.Point(12, 12);
            this.flpGoals.Name = "flpGoals";
            this.flpGoals.Size = new System.Drawing.Size(426, 579);
            this.flpGoals.TabIndex = 0;
            // 
            // GoalsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(450, 603);
            this.Controls.Add(this.flpGoals);
            this.Name = "GoalsStatistics";
            this.Text = "GoalsStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGoals;
    }
}
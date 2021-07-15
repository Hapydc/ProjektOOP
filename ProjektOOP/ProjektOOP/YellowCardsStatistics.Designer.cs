namespace ProjektOOP
{
    partial class YellowCardsStatistics
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
            this.flpYellowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpYellowCards
            // 
            this.flpYellowCards.AutoScroll = true;
            this.flpYellowCards.Location = new System.Drawing.Point(9, 10);
            this.flpYellowCards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpYellowCards.Name = "flpYellowCards";
            this.flpYellowCards.Size = new System.Drawing.Size(316, 470);
            this.flpYellowCards.TabIndex = 0;
            // 
            // YellowCardsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 490);
            this.Controls.Add(this.flpYellowCards);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YellowCardsStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YellowCardsStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpYellowCards;
    }
}
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
            this.flpYellowCards.Location = new System.Drawing.Point(12, 12);
            this.flpYellowCards.Name = "flpYellowCards";
            this.flpYellowCards.Size = new System.Drawing.Size(422, 579);
            this.flpYellowCards.TabIndex = 0;
            // 
            // YellowCardsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 603);
            this.Controls.Add(this.flpYellowCards);
            this.Name = "YellowCardsStatistics";
            this.Text = "YellowCardsStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpYellowCards;
    }
}
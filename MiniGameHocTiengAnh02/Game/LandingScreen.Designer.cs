namespace MiniGameHocTiengAnh02.Game
{
    partial class LandingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingScreen));
            this.playButton = new System.Windows.Forms.Panel();
            this.playLabel = new System.Windows.Forms.Label();
            this.playButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Controls.Add(this.playLabel);
            this.playButton.Location = new System.Drawing.Point(483, 378);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(279, 255);
            this.playButton.TabIndex = 4;
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.Font = new System.Drawing.Font("Script MT Bold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playLabel.ForeColor = System.Drawing.Color.DimGray;
            this.playLabel.Location = new System.Drawing.Point(52, 56);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(172, 81);
            this.playLabel.TabIndex = 0;
            this.playLabel.Text = "Play";
            this.playLabel.Click += new System.EventHandler(this.playLabel_Click);
            this.playLabel.MouseEnter += new System.EventHandler(this.playLabel_MouseEnter);
            this.playLabel.MouseLeave += new System.EventHandler(this.playLabel_MouseLeave);
            // 
            // LandingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.playButton);
            this.Name = "LandingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.playButton, 0);
            this.playButton.ResumeLayout(false);
            this.playButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playButton;
        private System.Windows.Forms.Label playLabel;
    }
}

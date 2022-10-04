namespace MiniGameHocTiengAnh02.Game
{
    partial class HomeParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeParent));
            this.rankingButton = new System.Windows.Forms.PictureBox();
            this.listVocabButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rankingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVocabButton)).BeginInit();
            this.SuspendLayout();
            // 
            // rankingButton
            // 
            this.rankingButton.BackColor = System.Drawing.Color.Transparent;
            this.rankingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rankingButton.BackgroundImage")));
            this.rankingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rankingButton.Location = new System.Drawing.Point(114, 12);
            this.rankingButton.Name = "rankingButton";
            this.rankingButton.Size = new System.Drawing.Size(60, 60);
            this.rankingButton.TabIndex = 2;
            this.rankingButton.TabStop = false;
            this.rankingButton.MouseEnter += new System.EventHandler(this.rankingButton_MouseEnter);
            this.rankingButton.MouseLeave += new System.EventHandler(this.rankingButton_MouseLeave);
            // 
            // listVocabButton
            // 
            this.listVocabButton.BackColor = System.Drawing.Color.Transparent;
            this.listVocabButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listVocabButton.BackgroundImage")));
            this.listVocabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listVocabButton.Location = new System.Drawing.Point(28, 12);
            this.listVocabButton.Name = "listVocabButton";
            this.listVocabButton.Size = new System.Drawing.Size(60, 60);
            this.listVocabButton.TabIndex = 3;
            this.listVocabButton.TabStop = false;
            this.listVocabButton.MouseEnter += new System.EventHandler(this.listVocabButton_MouseEnter);
            this.listVocabButton.MouseLeave += new System.EventHandler(this.listVocabButton_MouseLeave);
            // 
            // HomeParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.listVocabButton);
            this.Controls.Add(this.rankingButton);
            this.Name = "HomeParent";
            this.Controls.SetChildIndex(this.rankingButton, 0);
            this.Controls.SetChildIndex(this.listVocabButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rankingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVocabButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rankingButton;
        private System.Windows.Forms.PictureBox listVocabButton;
    }
}

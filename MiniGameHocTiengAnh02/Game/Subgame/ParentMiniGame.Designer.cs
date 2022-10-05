namespace MiniGameHocTiengAnh02.Game.Subgame
{
    partial class ParentMiniGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentMiniGame));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.answerField = new System.Windows.Forms.TextBox();
            this.scoreField = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(102, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1040, 648);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeButton.BackgroundImage")));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Location = new System.Drawing.Point(28, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(60, 60);
            this.homeButton.TabIndex = 3;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseEnter += new System.EventHandler(this.homeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(114, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 60);
            this.backButton.TabIndex = 4;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // pic
            // 
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic.Location = new System.Drawing.Point(383, 129);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(530, 323);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            // 
            // answerField
            // 
            this.answerField.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerField.Location = new System.Drawing.Point(425, 503);
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(436, 64);
            this.answerField.TabIndex = 6;
            this.answerField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerField_KeyPress);
            // 
            // scoreField
            // 
            this.scoreField.AutoSize = true;
            this.scoreField.BackColor = System.Drawing.Color.White;
            this.scoreField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreField.Location = new System.Drawing.Point(84, 229);
            this.scoreField.Name = "scoreField";
            this.scoreField.Size = new System.Drawing.Size(36, 39);
            this.scoreField.TabIndex = 8;
            this.scoreField.Text = "0";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Script MT Bold", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(44, 162);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(115, 53);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "Score";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1040, 562);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ParentMiniGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreField);
            this.Controls.Add(this.answerField);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ParentMiniGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ParentMiniGame_Load);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.homeButton, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.Controls.SetChildIndex(this.pic, 0);
            this.Controls.SetChildIndex(this.answerField, 0);
            this.Controls.SetChildIndex(this.scoreField, 0);
            this.Controls.SetChildIndex(this.scoreLabel, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox answerField;
        private System.Windows.Forms.Label scoreField;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

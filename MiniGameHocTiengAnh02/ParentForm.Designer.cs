namespace MiniGameHocTiengAnh02
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Location = new System.Drawing.Point(1168, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.exitButton_MouseLeave);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox exitButton;
    }
}


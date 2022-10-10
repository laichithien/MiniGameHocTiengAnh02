namespace MiniGameHocTiengAnh02
{
    partial class VocabList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VocabList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fruitButton = new System.Windows.Forms.Label();
            this.vehicleButton = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Label();
            this.animalButton = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vocabTable = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(253, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 160);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vocabulary";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.fruitButton);
            this.panel2.Controls.Add(this.vehicleButton);
            this.panel2.Controls.Add(this.colorButton);
            this.panel2.Controls.Add(this.animalButton);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 482);
            this.panel2.TabIndex = 5;
            // 
            // fruitButton
            // 
            this.fruitButton.AutoSize = true;
            this.fruitButton.Font = new System.Drawing.Font("Goudy Stout", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fruitButton.ForeColor = System.Drawing.Color.White;
            this.fruitButton.Location = new System.Drawing.Point(120, 305);
            this.fruitButton.Name = "fruitButton";
            this.fruitButton.Size = new System.Drawing.Size(148, 30);
            this.fruitButton.TabIndex = 0;
            this.fruitButton.Text = "Fruit";
            this.fruitButton.Click += new System.EventHandler(this.fruitButton_Click);
            this.fruitButton.MouseEnter += new System.EventHandler(this.fruitButton_MouseEnter);
            this.fruitButton.MouseLeave += new System.EventHandler(this.fruitButton_MouseLeave);
            // 
            // vehicleButton
            // 
            this.vehicleButton.AutoSize = true;
            this.vehicleButton.Font = new System.Drawing.Font("Goudy Stout", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleButton.ForeColor = System.Drawing.Color.White;
            this.vehicleButton.Location = new System.Drawing.Point(86, 237);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(196, 30);
            this.vehicleButton.TabIndex = 0;
            this.vehicleButton.Text = "Vehicle";
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            this.vehicleButton.MouseEnter += new System.EventHandler(this.vehicleButton_MouseEnter);
            this.vehicleButton.MouseLeave += new System.EventHandler(this.vehicleButton_MouseLeave);
            // 
            // colorButton
            // 
            this.colorButton.AutoSize = true;
            this.colorButton.Font = new System.Drawing.Font("Goudy Stout", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorButton.ForeColor = System.Drawing.Color.White;
            this.colorButton.Location = new System.Drawing.Point(105, 149);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(145, 30);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Color";
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            this.colorButton.MouseEnter += new System.EventHandler(this.colorButton_MouseEnter);
            this.colorButton.MouseLeave += new System.EventHandler(this.colorButton_MouseLeave);
            // 
            // animalButton
            // 
            this.animalButton.AutoSize = true;
            this.animalButton.Font = new System.Drawing.Font("Goudy Stout", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalButton.ForeColor = System.Drawing.Color.White;
            this.animalButton.Location = new System.Drawing.Point(86, 71);
            this.animalButton.Name = "animalButton";
            this.animalButton.Size = new System.Drawing.Size(182, 30);
            this.animalButton.TabIndex = 0;
            this.animalButton.Text = "Animal";
            this.animalButton.Click += new System.EventHandler(this.animalButton_Click);
            this.animalButton.MouseEnter += new System.EventHandler(this.animalButton_MouseEnter);
            this.animalButton.MouseLeave += new System.EventHandler(this.animalButton_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.vocabTable);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(408, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 482);
            this.panel3.TabIndex = 6;
            // 
            // vocabTable
            // 
            this.vocabTable.BackColor = System.Drawing.SystemColors.Control;
            this.vocabTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocabTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.vocabTable.HideSelection = false;
            this.vocabTable.LabelWrap = false;
            this.vocabTable.Location = new System.Drawing.Point(115, 116);
            this.vocabTable.Name = "vocabTable";
            this.vocabTable.Size = new System.Drawing.Size(588, 270);
            this.vocabTable.TabIndex = 1;
            this.vocabTable.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(433, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vietnamese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(145, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "English";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(28, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 60);
            this.backButton.TabIndex = 8;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // VocabList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VocabList";
            this.Load += new System.EventHandler(this.VocabList_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.backButton, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label fruitButton;
        private System.Windows.Forms.Label vehicleButton;
        private System.Windows.Forms.Label colorButton;
        private System.Windows.Forms.Label animalButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView vocabTable;
        private System.Windows.Forms.PictureBox backButton;
    }
}

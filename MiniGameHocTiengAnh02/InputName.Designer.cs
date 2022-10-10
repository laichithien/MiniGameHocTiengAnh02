namespace MiniGameHocTiengAnh02
{
    partial class InputName
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
            this.userNameInputField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameInputField
            // 
            this.userNameInputField.Font = new System.Drawing.Font("Ravie", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInputField.Location = new System.Drawing.Point(371, 205);
            this.userNameInputField.Name = "userNameInputField";
            this.userNameInputField.Size = new System.Drawing.Size(415, 70);
            this.userNameInputField.TabIndex = 1;
            this.userNameInputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNameInputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameInputField_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(111, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(968, 107);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your name";
            // 
            // InputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1230, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameInputField);
            this.Name = "InputName";
            this.Controls.SetChildIndex(this.userNameInputField, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameInputField;
        private System.Windows.Forms.Label label1;
    }
}

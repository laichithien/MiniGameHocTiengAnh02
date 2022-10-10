using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02
{
    public partial class Result : MiniGameHocTiengAnh02.ParentForm
    {
        public int score;
        public Result(int score)
        {
            InitializeComponent();
            this.score = score;
            label2.Text = score.ToString();
        }

        private void Result_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["HomeScreen"];
            f.Show();
            this.Close();
        }
    }
}

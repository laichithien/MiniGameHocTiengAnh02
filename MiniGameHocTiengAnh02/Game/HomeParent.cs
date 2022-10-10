using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MiniGameHocTiengAnh02.Game
{
    public partial class HomeParent : MiniGameHocTiengAnh02.ParentForm
    {
        public HomeParent()
        {
            InitializeComponent();
        }

        private void rankingButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void rankingButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void listVocabButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void listVocabButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void backButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void backButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LandingScreen"];
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
        }

        private void listVocabButton_Click(object sender, EventArgs e)
        {
            ShowVocab showVocab = new ShowVocab();
            showVocab.Show();
            this.Hide();
        }

        private void rankingButton_Click(object sender, EventArgs e)
        {
            Rank rank = new Rank();
            rank.Show();
            this.Hide();
        }
    }
}

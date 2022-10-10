using MiniGameHocTiengAnh02.Game.Subgame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02.Game
{
    public partial class HomeScreen : MiniGameHocTiengAnh02.Game.HomeParent
    {
        public string userName;
        public HomeScreen(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void Animal_Click(object sender, EventArgs e)
        {
            ParentMiniGame parentMiniGame = new ParentMiniGame("animal", userName);
            parentMiniGame.Show();
            this.Hide();
        }

        private void Animal_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Animal_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void fruitOptionButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void fruitOptionButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void fruitOptionButton_Click(object sender, EventArgs e)
        {
            ParentMiniGame parentMiniGame = new ParentMiniGame("fruit", userName);
            parentMiniGame.Show();
            this.Hide();
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
            f.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ParentMiniGame parentMiniGame = new ParentMiniGame("color", userName);
            parentMiniGame.Show();
            this.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ParentMiniGame parentMiniGame = new ParentMiniGame("vehicle", userName);
            parentMiniGame.Show();
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

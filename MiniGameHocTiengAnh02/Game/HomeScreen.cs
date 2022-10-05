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
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Animal_Click(object sender, EventArgs e)
        {
            ParentMiniGame parentMiniGame = new ParentMiniGame("animal");
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
            ParentMiniGame parentMiniGame = new ParentMiniGame("fruit");
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
            LandingScreen landingScreen = new LandingScreen();
            landingScreen.Show();
            this.Hide();
        }
    }
}

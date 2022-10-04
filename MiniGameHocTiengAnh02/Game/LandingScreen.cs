using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02.Game
{
    public partial class LandingScreen : MiniGameHocTiengAnh02.Game.HomeParent
    {
        public LandingScreen()
        {
            InitializeComponent();
        }

        private void playButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void playLabel_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
            this.Hide();
        }

        private void playLabel_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            playLabel.ForeColor = Color.Black;
        }

        private void playLabel_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            playLabel.ForeColor = Color.DimGray;
        }
    }
}

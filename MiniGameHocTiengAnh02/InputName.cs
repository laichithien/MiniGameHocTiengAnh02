using MiniGameHocTiengAnh02.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02
{
    public partial class InputName : MiniGameHocTiengAnh02.ParentForm
    {
        public InputName()
        {
            InitializeComponent();
        }

        private void userNameInputField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                HomeScreen homeScreen = new HomeScreen(userNameInputField.Text);
                homeScreen.Show();
                this.Hide();
            }
        }
    }
}

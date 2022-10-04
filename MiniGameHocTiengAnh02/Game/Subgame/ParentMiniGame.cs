using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02.Game.Subgame
{
    public partial class ParentMiniGame : MiniGameHocTiengAnh02.ParentForm
    {
        Int32 score = 0;
        Int32 curr_ID =0;
        DataTable dt = new DataTable();
        public ParentMiniGame()
        {
            InitializeComponent();

            dt.Columns.Add("ID", typeof(Int32));
            dt.Columns.Add("Name", typeof(string));

            dt.Rows.Add(0, "rabbit");
            dt.Rows.Add(1, "horse");
            dt.Rows.Add(2, "lion");
            dt.Rows.Add(3, "chicken");
            dt.Rows.Add(4, "mouse");
            dt.Rows.Add(5, "tiger");
            dt.Rows.Add(6, "snake");
            dt.Rows.Add(7, "eagle");
            dt.Rows.Add(8, "cat");
            dt.Rows.Add(9, "dog");
            dt.Rows.Add(10, "frog");
        }

        private void changeImage(Int32 curr_ID)
        {
            switch (curr_ID)
            {

                case 0:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.rabbit;
                    break;
                case 1:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.horse;
                    break;
                case 2:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.lion;
                    break;
                case 3:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.chicken;
                    break;
                case 4:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.mouse;
                    break;
                case 5:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.tiger;
                    break;
                case 6:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.snake;
                    break;
                case 7:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.eagle;
                    break;
                case 8:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.cat;
                    break;
                case 9:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.dog;
                    break;
                case 10:
                    pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.frog;
                    break;
                default:
                    break;
            }
        }

        private string getName(Int32 ID, DataTable dt)
        {
            string curr_animal;
            curr_animal = Convert.ToString(dt.Rows[ID][1]);
            return curr_animal;
        }

        private bool isCorrect(string input, string ans)
        {
            return input == ans ;
        }

        private void ParentMiniGame_Load(object sender, EventArgs e)
        {
            string curr_name = Convert.ToString(dt.Rows[curr_ID][1]);

            pic_animal.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.rabbit;
            //answerField.Text = curr_name;
        }
        private void answerField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (curr_ID < dt.Rows.Count -1)
                {
                    if (answerField.Text.Trim().ToLower() == getName(curr_ID, dt))
                    {
                        score += 2;
                    }
                    curr_ID++;
                    scoreField.Text = Convert.ToString(score);
                    answerField.Clear();

                    changeImage(curr_ID);
                }
                else
                {
                    MessageBox.Show("Het roi!!!");
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (curr_ID < dt.Rows.Count - 1)
            {
                if (answerField.Text.Trim().ToLower() == getName(curr_ID, dt))
                {
                    score += 2;
                }
                curr_ID++;
                scoreField.Text = Convert.ToString(score);
                answerField.Clear();

                changeImage(curr_ID);
            }
            else
            {
                MessageBox.Show("Het roi!!");
            }
        }
    }
}   

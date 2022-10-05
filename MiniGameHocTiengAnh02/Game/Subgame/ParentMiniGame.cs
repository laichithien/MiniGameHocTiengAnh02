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
        Int32 curr_ID = 0;
        DataTable dt = new DataTable();
        DataTable dtAnimal = new DataTable();
        DataTable dtFruit = new DataTable();
        DataTable dtColor = new DataTable();
        DataTable dtVehicle = new DataTable();
        public ParentMiniGame(string category)
        {
            InitializeComponent();

            this.category = category;

            //-----------------------------------//
            //Animal database
            dtAnimal.Columns.Add("ID", typeof(Int32));
            dtAnimal.Columns.Add("Name", typeof(string));

            dtAnimal.Rows.Add(0, "rabbit");
            dtAnimal.Rows.Add(1, "horse");
            dtAnimal.Rows.Add(2, "lion");
            dtAnimal.Rows.Add(3, "chicken");
            dtAnimal.Rows.Add(4, "mouse");
            dtAnimal.Rows.Add(5, "tiger");
            dtAnimal.Rows.Add(6, "snake");
            dtAnimal.Rows.Add(7, "eagle");
            dtAnimal.Rows.Add(8, "cat");
            dtAnimal.Rows.Add(9, "dog");
            dtAnimal.Rows.Add(10, "frog");

            //-----------------------------------//
            //Fruit database
            dtFruit.Columns.Add("ID", typeof(Int32));
            dtFruit.Columns.Add("Name", typeof(string));

            dtFruit.Rows.Add(0, "banana");
            dtFruit.Rows.Add(1, "apple");
            dtFruit.Rows.Add(2, "pineapple");
            dtFruit.Rows.Add(3, "papaya");
            dtFruit.Rows.Add(4, "watermelon");
            dtFruit.Rows.Add(5, "grapes");
            dtFruit.Rows.Add(6, "orange");
            dtFruit.Rows.Add(7, "avocado");
            dtFruit.Rows.Add(8, "strawberry");
            dtFruit.Rows.Add(9, "kiwi");
            dtFruit.Rows.Add(10, "coconut");

            //-----------------------------------//
            //Color database
            dtColor.Columns.Add("ID", typeof(Int32));
            dtColor.Columns.Add("Name", typeof(string));

            dtColor.Rows.Add(0, "red");
            dtColor.Rows.Add(1, "green");
            dtColor.Rows.Add(2, "blue");
            dtColor.Rows.Add(3, "cyan");
            dtColor.Rows.Add(4, "purple");
            dtColor.Rows.Add(5, "gray");
            dtColor.Rows.Add(6, "white");
            dtColor.Rows.Add(7, "black");
            dtColor.Rows.Add(8, "yellow");
            dtColor.Rows.Add(9, "brown");
            dtColor.Rows.Add(10, "orange");

            //-----------------------------------//
            //Vehicle database
            dtVehicle.Columns.Add("ID", typeof(Int32));
            dtVehicle.Columns.Add("Name", typeof(string));

            dtColor.Rows.Add(0, "car");
            dtColor.Rows.Add(1, "bus");
            dtColor.Rows.Add(2, "motorcycle");
            dtColor.Rows.Add(3, "bicycle");
            dtColor.Rows.Add(4, "van");
            dtColor.Rows.Add(5, "truck");
            dtColor.Rows.Add(6, "crane");
            dtColor.Rows.Add(7, "tractor");
            dtColor.Rows.Add(8, "helicopter");
            dtColor.Rows.Add(9, "airplane");
            dtColor.Rows.Add(10, "train");

            if (category == "animal")
            {
                dt = dtAnimal;
            }
            else if (category == "fruit")
            {
                dt = dtFruit;
            }
            else if (category == "color")
            {
                dt = dtColor;
            }
        }

        public string category;

        private void changeImage(Int32 curr_ID)
        {
            if (this.category == "animal")
            {
                switch (curr_ID)
                {

                    case 0:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.rabbit;
                        break;
                    case 1:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.horse;
                        break;
                    case 2:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.lion;
                        break;
                    case 3:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.chicken;
                        break;
                    case 4:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.mouse;
                        break;
                    case 5:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.tiger;
                        break;
                    case 6:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.snake;
                        break;
                    case 7:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.eagle;
                        break;
                    case 8:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.cat;
                        break;
                    case 9:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.dog;
                        break;
                    case 10:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.frog;
                        break;
                    default:
                        break;
                }
            }
            else if (this.category == "fruit")
            { 
                switch (curr_ID)
                {

                    case 0:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.banana;
                        break;
                    case 1:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.apple;
                        break;
                    case 2:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.pineapple;
                        break;
                    case 3:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.papaya;
                        break;
                    case 4:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.watermelon;
                        break;
                    case 5:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.grapes;
                        break;
                    case 6:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.orange;
                        break;
                    case 7:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.avocado;
                        break;
                    case 8:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.strawberry;
                        break;
                    case 9:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.kiwi;
                        break;
                    case 10:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.coconut;
                        break;
                    default:
                        break;
                }
            }
            else if (this.category == "color")
            {
                switch (curr_ID)
                {

                    case 0:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.banana;
                        break;
                    case 1:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.apple;
                        break;
                    case 2:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.pineapple;
                        break;
                    case 3:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.papaya;
                        break;
                    case 4:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.watermelon;
                        break;
                    case 5:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.grapes;
                        break;
                    case 6:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.orange;
                        break;
                    case 7:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.avocado;
                        break;
                    case 8:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.strawberry;
                        break;
                    case 9:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.kiwi;
                        break;
                    case 10:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.coconut;
                        break;
                    default:
                        break;
                }
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
            if (category == "animal")
            {
                pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.rabbit;
            }
            else if (category == "fruit")
            {
                pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.banana;
            }
            //answerField.Text = curr_name;
        }

        private void answerField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) ///e.KeyChar: vua nhan phim gi 13 == "Enter"
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

        private void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.Show();
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

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            LandingScreen landingScreen = new LandingScreen();
            landingScreen.Show();
            this.Hide();
        }
    }
}   

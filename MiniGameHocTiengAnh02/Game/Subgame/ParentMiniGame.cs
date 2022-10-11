using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Media;

namespace MiniGameHocTiengAnh02.Game.Subgame
{
    public partial class ParentMiniGame : MiniGameHocTiengAnh02.ParentForm
    {
        Int32 score = 0;
        Int32 curr_ID = 0;
        Int32 count = 1;
        DataTable dt = new DataTable();
        DataTable dtAnimal = new DataTable();
        DataTable dtFruit = new DataTable();
        DataTable dtColor = new DataTable();
        DataTable dtVehicle = new DataTable();
        DataTable dtRank = new DataTable();

        bool[] isPlayed = new bool[11];

        public string category;
        public string userName;

        public ParentMiniGame(string category, string userName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            unmuteButton.Hide();
            axWindowsMediaPlayer1.settings.volume = 10;
            axWindowsMediaPlayer1.URL = "loop.mp3";
            this.category = category;
            this.userName = userName;

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

            dtVehicle.Rows.Add(0, "car");
            dtVehicle.Rows.Add(1, "bus");
            dtVehicle.Rows.Add(2, "motorcycle");
            dtVehicle.Rows.Add(3, "bicycle");
            dtVehicle.Rows.Add(4, "van");
            dtVehicle.Rows.Add(5, "truck");
            dtVehicle.Rows.Add(6, "crane");
            dtVehicle.Rows.Add(7, "tractor");
            dtVehicle.Rows.Add(8, "helicopter");
            dtVehicle.Rows.Add(9, "airplane");
            dtVehicle.Rows.Add(10, "train");

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
            else if (category == "vehicle")
            {
                dt = dtVehicle;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form homeScreen = System.Windows.Forms.Application.OpenForms["HomeScreen"];
            homeScreen.Show();
            this.Close();
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
            System.Windows.Forms.Form landingScreen = System.Windows.Forms.Application.OpenForms["LandingScreen"];
            landingScreen.Show();
            this.Hide();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }



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
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Red;
                        break;
                    case 1:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Green;
                        break;
                    case 2:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Blue;
                        break;
                    case 3:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Cyan;
                        break;
                    case 4:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Purple;
                        break;
                    case 5:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Gray;
                        break;
                    case 6:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.White;
                        break;
                    case 7:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Black;
                        break;
                    case 8:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Yellow;
                        break;
                    case 9:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Brown;
                        break;
                    case 10:
                        pic.BackgroundImage = null;
                        pic.BackColor = Color.Orange;
                        break;
                    default:
                        break;
                }
            }
            else if (this.category == "vehicle")
            {
                switch (curr_ID)
                {

                    case 0:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.car;
                        break;
                    case 1:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.bus;
                        break;
                    case 2:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.motorcycle;
                        break;
                    case 3:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.bicycle;
                        break;
                    case 4:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.van;
                        break;
                    case 5:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.truck;
                        break;
                    case 6:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.crane;
                        break;
                    case 7:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.tractor;
                        break;
                    case 8:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.helicopter;
                        break;
                    case 9:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.airplane;
                        break;
                    case 10:
                        pic.BackgroundImage = MiniGameHocTiengAnh02.Properties.Resources.train;
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

        private void ParentMiniGame_Load(object sender, EventArgs e)
        {
            progessLabelNum.Text = Convert.ToString(count) + "/" + dt.Rows.Count;
            getRandID();
            this.CenterToScreen();
        }

        private void getRandID()
        {
            //Check xem mang da day chua 
            bool flag = true;
            for (int i = 0; i < isPlayed.Count(); i++)
            {
                if (!isPlayed[i])
                    flag = false;
            }

            if (flag) 
            {
                MessageBox.Show("Het roi");
            }

            Random rand = new Random();
            Int16 rand_curr = Convert.ToInt16(rand.Next(0, 11));
            while (isPlayed[rand_curr])
            {
                rand_curr = Convert.ToInt16(rand.Next(0, 11));
            }
            curr_ID = rand_curr;
            changeImage(curr_ID);
        }

        private bool isCorrect()
        {
            return answerField.Text.Trim().ToLower() == getName(curr_ID, dt);
        }

        private void confirmAnswer(bool final_answer)
        {
            if (final_answer)
            {
                score += 2;
                axWindowsMediaPlayer2.URL = "correct.mp3";
            }
            else axWindowsMediaPlayer2.URL = "incorrect.mp3";
            if (count < dt.Rows.Count)
            {
                count++;
            }
            isPlayed[curr_ID] = true;
            scoreField.Text = Convert.ToString(score);
            progessLabelNum.Text = Convert.ToString(count) + "/" + dt.Rows.Count;
            answerField.Clear();
            
        }
        private void loadRank()
        {
            string path = "";
            switch (category)
            {
                case "animal":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\AnimalRanking.csv";
                    break;
                case "vehicle":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\VehicleRanking.csv";
                    break;
                case "color":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\ColorRanking.csv";
                    break;
                case "fruit":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\FruitRanking.csv";
                    break;
                default:
                    break;
            }
            // Open the file to read from.
            using (StreamReader sr = new StreamReader(path))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dtRank.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dtRank.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dtRank.Rows.Add(dr);
                }
            }
        }
        private void saveRank()
        {
            string path = "";
            switch (category)
            {
                case "animal":
                    path = "C:\\Users\\laich\\source\\repos\\MiniGameHocTiengAnh\\MiniGameHocTiengAnh02\\assets\\AnimalRanking.csv";
                    break;
                case "vehicle":
                    path = "C:\\Users\\laich\\source\\repos\\MiniGameHocTiengAnh\\MiniGameHocTiengAnh02\\assets\\VehicleRanking.csv";
                    break;
                case "color":
                    path = "C:\\Users\\laich\\source\\repos\\MiniGameHocTiengAnh\\MiniGameHocTiengAnh02\\assets\\ColorRanking.csv";
                    break;
                case "fruit":
                    path = "C:\\Users\\laich\\source\\repos\\MiniGameHocTiengAnh\\MiniGameHocTiengAnh02\\assets\\FruitRanking.csv";
                    break;
                default:
                    break;
            }
            dtRank.Rows.Add(userName, Convert.ToString(score), DateTime.Now.ToString("dd/MM/yyyy"));
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dtRank.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dtRank.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            System.IO.File.WriteAllText(path, sb.ToString(), System.Text.Encoding.UTF8);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            confirmAnswer(isCorrect());
            bool flag = true;
            for (int i = 0; i < isPlayed.Count(); i++)
            {
                if (!isPlayed[i])
                    flag = false;
            }

            if (flag)
            {
                //MessageBox.Show("Tổng điểm của bạn là: " + Convert.ToString(score));
                loadRank();
                saveRank(); Result result = new Result(score);
                //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["HomeScreen"];
                result.Show();
                this.Close();
            }
            else getRandID();
        }

        private void answerField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmAnswer(isCorrect());
                bool flag = true;
                for (int i = 0; i < isPlayed.Count(); i++)
                {
                    if (!isPlayed[i])
                        flag = false;
                }

                if (flag)
                {
                    //MessageBox.Show("Tổng điểm của bạn là: " + Convert.ToString(score));
                    loadRank();
                    saveRank();
                    Result result = new Result(score);
                    //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["HomeScreen"];
                    result.Show();
                    this.Close();
                }
                else getRandID();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void unmuteButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            muteButton.Show();
            unmuteButton.Hide();
        }

        private void muteButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            unmuteButton.Show();
            muteButton.Hide();
        }

        private void unmuteButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void unmuteButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void muteButton_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void muteButton_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}   

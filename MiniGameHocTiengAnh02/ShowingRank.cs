using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02
{
    public partial class ShowingRank : MiniGameHocTiengAnh02.ParentForm
    {
        static string category;
        DataTable dt = new DataTable();
        public ShowingRank()
        {
            InitializeComponent();
            category = "Animal";
        }

        private void loadDataToForm(string category)
        {
            string path = "a";
            switch (category)
            {
                case "Animal":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\AnimalRanking.csv";
                    break;
                case "Vehicle":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\VehicleRanking.csv";
                    break;
                case "Color":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\ColorRanking.csv";
                    break;
                case "Fruit":
                    path = @"C:\Users\laich\source\repos\MiniGameHocTiengAnh\MiniGameHocTiengAnh02\assets\FruitRanking.csv";
                    break;
                default:
                    break;
            }
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(path))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                dt.Columns[1].DataType = typeof(int);
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            dt.DefaultView.Sort = "Score DESC";
            dt = dt.DefaultView.ToTable();
            this.dt = dt;
        }


        private void animalButton_MouseEnter(object sender, EventArgs e)
        {
            animalButton.ForeColor = Color.Silver;
            this.Cursor = Cursors.Hand;
        }

        private void animalButton_MouseLeave(object sender, EventArgs e)
        {
            if (category != "Animal")
            {
                animalButton.ForeColor = Color.White;
            }
            else animalButton.ForeColor = Color.Bisque;
            this.Cursor = Cursors.Default;
        }

        private void colorButton_MouseEnter(object sender, EventArgs e)
        {
            colorButton.ForeColor = Color.Silver;
            this.Cursor = Cursors.Hand;
        }

        private void colorButton_MouseLeave(object sender, EventArgs e)
        {
            if (category != "Color")
            {
                colorButton.ForeColor = Color.White;
            }
            else colorButton.ForeColor = Color.Bisque;
            this.Cursor = Cursors.Default;
        }

        private void vehicleButton_MouseEnter(object sender, EventArgs e)
        {
            vehicleButton.ForeColor = Color.Silver;
            this.Cursor = Cursors.Hand;
        }

        private void vehicleButton_MouseLeave(object sender, EventArgs e)
        {
            if (category != "Vehicle")
            {
                vehicleButton.ForeColor = Color.White;
            }
            else vehicleButton.ForeColor = Color.Bisque;
            this.Cursor = Cursors.Default;
        }

        private void fruitButton_MouseEnter(object sender, EventArgs e)
        {
            fruitButton.ForeColor = Color.Silver;
            this.Cursor = Cursors.Hand;
        }

        private void fruitButton_MouseLeave(object sender, EventArgs e)
        {
            if (category != "Fruit")
            {
                fruitButton.ForeColor = Color.White;
            }
            else fruitButton.ForeColor = Color.Bisque;
            this.Cursor = Cursors.Default;
        }
        private void setButtonColor()
        {
            animalButton.ForeColor = Color.White;
            colorButton.ForeColor = Color.White;
            vehicleButton.ForeColor = Color.White;
            fruitButton.ForeColor = Color.White;
            switch (category)
            {
                case "Animal":
                    animalButton.ForeColor = Color.Bisque;
                    break;
                case "Color":
                    colorButton.ForeColor = Color.Bisque;
                    break;
                case "Vehicle":
                    vehicleButton.ForeColor = Color.Bisque;
                    break;
                case "Fruit":
                    fruitButton.ForeColor = Color.Bisque;
                    break;
                default:
                    break;
            }
        }

        private void loadRanking()
        {
            loadDataToForm(category);
            string score;
            string user;
            string date;
            if (dt.Rows.Count > 0)
            {
                score = this.dt.Rows[0]["Score"].ToString();
                user = this.dt.Rows[0]["User"].ToString();
                date = this.dt.Rows[0]["Date"].ToString();
                firstLabel.Text = user;
                firstScore.Text = score;
                firstDate.Text = date;
            }
            else
            {
                firstLabel.Text = "";
                firstScore.Text = "";
                firstDate.Text = "";
            }
            if (dt.Rows.Count > 1)
            {
                score = dt.Rows[1]["Score"].ToString();
                user = dt.Rows[1]["User"].ToString();
                date = dt.Rows[1]["Date"].ToString();
                secondLabel.Text = user;
                secondScore.Text = score;
                secondDate.Text = date;
            }
            else
            {
                secondLabel.Text = "";
                secondScore.Text = "";
                secondDate.Text = "";
            }



            if (dt.Rows.Count > 2)
            {
                score = dt.Rows[2]["Score"].ToString();
                user = dt.Rows[2]["User"].ToString();
                date = dt.Rows[2]["Date"].ToString();
                thirdLabel.Text = user;
                thirdScore.Text = score;
                thirdDate.Text = date;
            }
            else
            {
                thirdLabel.Text = "";
                thirdScore.Text = "";
                thirdDate.Text = "";
            }

            if (dt.Rows.Count > 3)
            {
                score = dt.Rows[3]["Score"].ToString();
                user = dt.Rows[3]["User"].ToString();
                date = dt.Rows[3]["Date"].ToString();
                fourthLabel.Text = user;
                fourthScore.Text = score;
                fourthDate.Text = date;
            }
            else
            {
                fourthLabel.Text = "";
                fourthScore.Text = "";
                fourthDate.Text = "";
            }
            if (dt.Rows.Count > 4)
            {
                score = dt.Rows[4]["Score"].ToString();
                user = dt.Rows[4]["User"].ToString();
                date = dt.Rows[4]["Date"].ToString();
                fifthLabel.Text = user;
                fifthScore.Text = score;
                fifthDate.Text = date;
            }
            else
            {
                fifthLabel.Text = "";
                fifthScore.Text = "";
                fifthDate.Text = "";
            }


        }

        private void ShowingRank_Load(object sender, EventArgs e)
        {
            setButtonColor();
            loadRanking();
        }
        private void animalButton_Click(object sender, EventArgs e)
        {
            category = "Animal";
            setButtonColor();
            loadRanking();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            category = "Color";
            setButtonColor();
            loadRanking();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            category = "Vehicle";
            setButtonColor();
            loadRanking();
        }

        private void fruitButton_Click(object sender, EventArgs e)
        {
            category = "Fruit";
            setButtonColor();
            loadRanking();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LandingScreen"];
            f.Show();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using MiniGameHocTiengAnh02.Game;

namespace MiniGameHocTiengAnh02
{
    public partial class Rank : Form
    {
        DataTable dtRank = new DataTable();
        public Rank()
        {
            InitializeComponent();
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
            dataGridView1.DataSource = dt;
        }
        private void Rank_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            loadDataToForm(comboBox1.SelectedItem.ToString());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["LandingScreen"];
            f.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDataToForm(comboBox1.SelectedItem.ToString());
        }
    }
}

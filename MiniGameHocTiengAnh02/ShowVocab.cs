using MiniGameHocTiengAnh02.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameHocTiengAnh02
{
    public partial class ShowVocab : Form
    {
        DataTable dt = new DataTable();
        DataTable dtAnimal = new DataTable();
        DataTable dtFruit = new DataTable();
        DataTable dtColor = new DataTable();
        DataTable dtVehicle = new DataTable();
        public ShowVocab()
        {
            InitializeComponent();

            //-----------------------------------//
            //Animal database
            dtAnimal.Columns.Add("ID", typeof(Int32));
            dtAnimal.Columns.Add("Eng", typeof(string));
            dtAnimal.Columns.Add("Viet", typeof(string));

            dtAnimal.Rows.Add(0, "rabbit", "con thỏ");
            dtAnimal.Rows.Add(1, "horse", "con ngựa");
            dtAnimal.Rows.Add(2, "lion", "con sư tử");
            dtAnimal.Rows.Add(3, "chicken", "con gà");
            dtAnimal.Rows.Add(4, "mouse", "con chuột");
            dtAnimal.Rows.Add(5, "tiger", "con hổ");
            dtAnimal.Rows.Add(6, "snake", "con rắn");
            dtAnimal.Rows.Add(7, "eagle", "con đại bàng");
            dtAnimal.Rows.Add(8, "cat", "con mèo");
            dtAnimal.Rows.Add(9, "dog", "con chó");
            dtAnimal.Rows.Add(10, "frog", "con ếch");

            //-----------------------------------//
            //Fruit database
            dtFruit.Columns.Add("ID", typeof(Int32));
            dtFruit.Columns.Add("Eng", typeof(string));
            dtFruit.Columns.Add("Viet", typeof(string));

            dtFruit.Rows.Add(0, "banana", "trái chuối");
            dtFruit.Rows.Add(1, "apple", "trái táo");
            dtFruit.Rows.Add(2, "pineapple", "trái thơm");
            dtFruit.Rows.Add(3, "papaya", "trái đu đủ");
            dtFruit.Rows.Add(4, "watermelon", "trái dưa hấu");
            dtFruit.Rows.Add(5, "grapes", "chùm nho");
            dtFruit.Rows.Add(6, "orange", "trái cam");
            dtFruit.Rows.Add(7, "avocado", "trái bơ");
            dtFruit.Rows.Add(8, "strawberry", "trái dâu");
            dtFruit.Rows.Add(9, "kiwi", "trái kiwi");
            dtFruit.Rows.Add(10, "coconut", "trái dừa");

            //-----------------------------------//
            //Color database
            dtColor.Columns.Add("ID", typeof(Int32));
            dtColor.Columns.Add("Eng", typeof(string));
            dtColor.Columns.Add("Viet", typeof(string));

            dtColor.Rows.Add(0, "red", "màu đỏ");
            dtColor.Rows.Add(1, "green", "màu xanh lá cây");
            dtColor.Rows.Add(2, "blue", "màu xanh nước biển");
            dtColor.Rows.Add(3, "cyan", "màu xanh lơ");
            dtColor.Rows.Add(4, "purple", "màu tím");
            dtColor.Rows.Add(5, "gray", "màu xám");
            dtColor.Rows.Add(6, "white", "màu trắng");
            dtColor.Rows.Add(7, "black", "màu đen");
            dtColor.Rows.Add(8, "yellow", "màu vàng");
            dtColor.Rows.Add(9, "brown", "màu nâu");
            dtColor.Rows.Add(10, "orange", "màu cam");

            //-----------------------------------//
            //Vehicle database
            dtVehicle.Columns.Add("ID", typeof(Int32));
            dtVehicle.Columns.Add("Eng", typeof(string));
            dtVehicle.Columns.Add("Viet", typeof(string));

            dtVehicle.Rows.Add(0, "car", "xe con");
            dtVehicle.Rows.Add(1, "bus", "xe buýt");
            dtVehicle.Rows.Add(2, "motorcycle", "xe gắn máy");
            dtVehicle.Rows.Add(3, "bicycle", "xe đạp");
            dtVehicle.Rows.Add(4, "van", "xe van");
            dtVehicle.Rows.Add(5, "truck", "xe tải");
            dtVehicle.Rows.Add(6, "crane", "xe cần cẩu");
            dtVehicle.Rows.Add(7, "tractor", "xe máy kéo");
            dtVehicle.Rows.Add(8, "helicopter", "máy bay trực thăng");
            dtVehicle.Rows.Add(9, "airplane", "máy bay phản lực");
            dtVehicle.Rows.Add(10, "train", "tàu hoả");

            
        }
        private void loadDataToForm(string category)
        {
            switch (category)
            {
                case "Animal":
                    dt = dtAnimal;
                    break;
                case "Vehicle":
                    dt = dtVehicle;
                    break;
                case "Color":
                    dt = dtColor;
                    break;
                case "Fruit":
                    dt = dtFruit;
                    break;
                default:
                    break;
            }
            dataGridView1.DataSource = dt;
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

        private void ShowVocab_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}

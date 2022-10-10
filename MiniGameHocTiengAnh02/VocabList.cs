using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniGameHocTiengAnh02
{
    public partial class VocabList : MiniGameHocTiengAnh02.ParentForm
    {
        DataTable dt = new DataTable();
        DataTable dtAnimal = new DataTable();
        DataTable dtFruit = new DataTable();
        DataTable dtColor = new DataTable();
        DataTable dtVehicle = new DataTable();

        public string category;
        public VocabList(string category)
        {
            InitializeComponent();
            vocabTable.BackColor = Color.FromArgb(255, 221, 217, 190);
            this.category = "Animal";
            {
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

            
        }
        public void loadVocab()
        {
            vocabTable.Clear();
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
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    string[] row = { dt.Rows[i]["Eng"].ToString() };
                //    var listViewItem = new ListViewItem(row);
                //    engColumn.Items.Add(listViewItem);
                //}
                //for (int i = 0; i < dt.Rows.Count; i++)
                //{
                //    vietColumn.Columns.Add(dt.Rows[i]["Viet"].ToString());
                //}

                vocabTable.View = View.Details;

                // Each SubItem object requires a column, so add three columns.
                this.vocabTable.Columns.Add("", 50, HorizontalAlignment.Left);
                this.vocabTable.Columns.Add("", 180, HorizontalAlignment.Left);
                this.vocabTable.Columns.Add("", 180, HorizontalAlignment.Left);


                // Add a ListItem (row1) object to the ListView.
                ListViewItem[] engColumn = new ListViewItem[dt.Rows.Count];
                for (int i = 0; i < engColumn.GetLength(0); i++)
                {
                    engColumn[i] = new ListViewItem();
                    engColumn[i].Text = Convert.ToString(i+1);
                    engColumn[i].SubItems.Add(dt.Rows[i]["Eng"].ToString());
                    engColumn[i].SubItems.Add(dt.Rows[i]["Viet"].ToString());
                    vocabTable.Items.Add(engColumn[i]);
                }
                //ListViewItem row1 = new ListViewItem();
                //row1.Text = "Row 1";
                //row1.SubItems.Add("A");
                //row1.SubItems.Add("");
                //vocabTable.Items.Add(row1);


                //// Add a ListItem (row2) object to the ListView.
                //ListViewItem row2 = new ListViewItem();
                //row2.Text = "Row 2";
                //row2.SubItems.Add("");
                //row2.SubItems.Add("B");

                //vocabTable.Items.Add(row2);


                //// Add a SubItem to existing item (row1)
                //System.Windows.Forms.ListViewItem.ListViewSubItem item1 = new ListViewItem.ListViewSubItem();
                //item1.Text = "C";

                //vocabTable.Items[0].SubItems[2] = item1;
            }

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

        private void VocabList_Load(object sender, EventArgs e)
        {
            setButtonColor();
            loadVocab();
        }

        private void animalButton_Click(object sender, EventArgs e)
        {
            category = "Animal";
            setButtonColor();
            loadVocab();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            category = "Color";
            setButtonColor();
            loadVocab();
        }

        private void vehicleButton_Click(object sender, EventArgs e)
        {
            category = "Vehicle";
            setButtonColor();
            loadVocab();
        }

        private void fruitButton_Click(object sender, EventArgs e)
        {
            category = "Fruit";
            setButtonColor();
            loadVocab();
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

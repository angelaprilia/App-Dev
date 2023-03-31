using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_ANGEL_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_filter.Enabled = false;
        }

        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        DataRow dr;
        List<string> IDProduct = new List<string>();
        List<string> NamaProduk = new List<string>();
        List<string> IDCategory = new List<string>();
        List<int> Harga = new List<int>();
        List<int> Stock = new List<int>();
        List<string> IDcat2 = new List<string>();
        List<string> Namacategory = new List<string>();
        List<string> chars = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");
            dataGridView1.DataSource = dtProdukSimpan;

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID \nCategory");
            dtCategory.Columns.Add("Nama Category");
            dataGridView2.DataSource = dtCategory;

            IDProduct.Add("J001");
            IDProduct.Add("T001");
            IDProduct.Add("T002");
            IDProduct.Add("R001");
            IDProduct.Add("J002");
            IDProduct.Add("C001");
            IDProduct.Add("C002");
            IDProduct.Add("R002");

            NamaProduk.Add("Jas Hitam");
            NamaProduk.Add("T-shirt Blackpink");
            NamaProduk.Add("T-shirt Obsessive");
            NamaProduk.Add("Rok mini");
            NamaProduk.Add("Jeans Biru");
            NamaProduk.Add("Celana pendek coklat");
            NamaProduk.Add("Cawet blink blink");
            NamaProduk.Add("Rocca Shirt");

            Harga.Add(100000);
            Harga.Add(70000);
            Harga.Add(75000);
            Harga.Add(82000);
            Harga.Add(90000);
            Harga.Add(60000);
            Harga.Add(1000000);
            Harga.Add(50000);

            Stock.Add(10);
            Stock.Add(20);
            Stock.Add(16);
            Stock.Add(26);
            Stock.Add(5);
            Stock.Add(11);
            Stock.Add(1);
            Stock.Add(8);

            IDCategory.Add("C1");
            IDCategory.Add("C2");
            IDCategory.Add("C2");
            IDCategory.Add("C3");
            IDCategory.Add("C4");
            IDCategory.Add("C4");
            IDCategory.Add("C5");
            IDCategory.Add("C2");

            IDcat2.Add("C1");
            IDcat2.Add("C2");
            IDcat2.Add("C3");
            IDcat2.Add("C4");
            IDcat2.Add("C5");

            Namacategory.Add("Jas");
            Namacategory.Add("T-shirt");
            Namacategory.Add("Rok");
            Namacategory.Add("Celana");
            Namacategory.Add("Cawat");


            foreach (string a in IDProduct)
            {
                int row = IDProduct.IndexOf(a);
                dtProdukSimpan.Rows.Add(IDProduct[row], NamaProduk[row], Harga[row], Stock[row], IDCategory[row]);
            }
            foreach (string b in IDcat2)
            {
                int row2 = IDcat2.IndexOf(b);
                dtCategory.Rows.Add(IDcat2[row2], Namacategory[row2]);
            }
            foreach (string c in Namacategory)
            {
                comboBox_category.Items.Add(c);
                comboBox_filter.Items.Add(c);
            }
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

        }

        private void button_all_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled = false;
            comboBox_filter.SelectedIndex = -1;
            dataGridView1.DataSource = dtProdukSimpan;
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled = true;
        }

        private void button_addproduct_Click(object sender, EventArgs e)
        {
            if (textBox_nama2.Text == "" || comboBox_category.Text == "" || textBox_harga.Text == "" || textBox_stock.Text == "")
            {
                MessageBox.Show("INPUT ALL THE DETAILS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nama2.Clear();
                textBox_harga.Clear();
                textBox_stock.Clear();
                comboBox_category.SelectedIndex= -1;
            }
            else
            {
                string firstletter = textBox_nama2.Text.Substring(0, 1).ToUpper();
                int ID = 0;
                foreach (string productID in IDProduct)
                {
                    char firstchar = productID[0];
                    string cs= firstchar.ToString();
                    if (cs == firstletter)
                    {
                        int ID2 = Convert.ToInt32(productID.Substring(1));
                        if (ID <= ID2)
                        {
                            ID = ID2;
                        }
                    }
                }
                string idbaru = firstletter;
                for (int i = ID.ToString().Length; i < 3; i++)
                {
                    idbaru += "0";
                }
                idbaru += (ID + 1).ToString();
                ID++;
                int indexke = comboBox_category.SelectedIndex;
                string l = IDcat2[indexke];
                IDProduct.Add(idbaru);
                NamaProduk.Add(textBox_nama2.Text);
                Harga.Add(Convert.ToInt32(textBox_harga.Text));
                Stock.Add(Convert.ToInt32(textBox_stock.Text));
                IDCategory.Add(l);
                dr = dtProdukSimpan.NewRow();
                dr[0] = idbaru;
                dr[1] = textBox_nama2.Text;
                dr[2] = textBox_harga.Text;
                dr[3] = textBox_stock.Text;
                dr[4] = l;
                dtProdukSimpan.Rows.Add(dr);
                textBox_nama2.Clear();
                textBox_harga.Clear();
                textBox_stock.Clear();
                comboBox_category.SelectedIndex = -1;
            }
        }
        private void button_editproduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string searchValue = dataGridView1.CurrentRow.Cells["ID Product"].Value.ToString();
                int index = 0;
                for (int i = 0; i < IDProduct.Count; i++)
                {
                    if (IDProduct[i].Contains(searchValue))
                    {
                        index = i;
                        break;
                    }
                }
                foreach (DataRow row in dtProdukSimpan.Rows)
                {
                    int indeks = comboBox_category.SelectedIndex;
                    string newID = "";
                    if (row[0].ToString() == IDProduct[index])
                    {
                        newID = IDcat2[indeks];
                        row[1] = textBox_nama2.Text;
                        row[2] = textBox_harga.Text;
                        row[3] = textBox_stock.Text;
                        row[4] = newID;
                        if (row[3].ToString() == "0")
                        {
                            dtProdukSimpan.Rows.Remove(row);
                            break;
                        }
                    }
                }

                textBox_nama2.Clear();
                textBox_harga.Clear();
                textBox_stock.Clear();
                comboBox_category.SelectedIndex = -1;
                dataGridView1.ClearSelection();


            }
        }
        private void button_removeproduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(selectedIndex);

                IDProduct.RemoveAt(selectedIndex);
                NamaProduk.RemoveAt(selectedIndex);
                Harga.RemoveAt(selectedIndex);
                Stock.RemoveAt(selectedIndex);
                IDCategory.RemoveAt(selectedIndex);

                dtProdukSimpan.Clear();
                for (int i = 0; i < IDProduct.Count; i++)
                {
                    dtProdukSimpan.Rows.Add(IDProduct[i], NamaProduk[i], Harga[i], Stock[i], IDCategory[i]);
                   
                }
                textBox_nama2.Clear();
                textBox_harga.Clear();
                textBox_stock.Clear();
                comboBox_category.SelectedIndex = -1;
                dataGridView1.ClearSelection();
            }
        }

        private void textBox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_addcategory_Click(object sender, EventArgs e)
        {
            if (textBox_nama1.Text == "")
            {
                MessageBox.Show("INPUT THE CATEGORY NAME!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int bts = 1;
                bool sudahada = false;
                if (Namacategory.Contains(textBox_nama1.Text))
                {
                    sudahada = true;
                }
                if (sudahada == true)
                {
                    MessageBox.Show("Name Already Exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_nama1.Clear();
                }
                else if (sudahada == false)
                {
                    foreach(string ak in IDcat2)
                    {
                        if(ak.Substring(0,1) == "C")
                        {
                            int ak2 = Convert.ToInt32(ak.Substring(1));
                            if (ak2 >= bts)
                            {
                                bts = ak2 + 1;
                            }
                        }
                    }
                    string idbaru = "C" + bts.ToString();
                    IDcat2.Add(idbaru);
                    dataGridView2.ClearSelection();
                    comboBox_category.Items.Add(textBox_nama1.Text);
                    comboBox_filter.Items.Add(textBox_nama1.Text);
                    Namacategory.Add(textBox_nama1.Text);
                    dtCategory.Rows.Add(idbaru, textBox_nama1.Text);
                    textBox_nama1.Clear();
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox_nama2.Text = dataGridView1.CurrentRow.Cells["Nama Product"].Value.ToString();

            string idCategory = dataGridView1.CurrentRow.Cells["ID Category"].Value.ToString();
            int index = IDcat2.FindIndex(a => a.Contains(idCategory));

            if (index >= 0 && index <= Namacategory.Count)
            {
                string categoryName = Namacategory[index];
                comboBox_category.Text = categoryName;
            }

            textBox_harga.Text = dataGridView1.CurrentRow.Cells["Harga"].Value.ToString();
            textBox_stock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();

        }

       

        private void button_removecategory_Click(object sender, EventArgs e)
        {
            if (dtCategory.Rows.Count == 0)
            {
                MessageBox.Show("No Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nama1.Clear();
            }
            if (dataGridView2.SelectedRows.Count != 0)
            {
                string selectedCat = IDcat2[dataGridView2.CurrentRow.Index];
                for (int i = IDProduct.Count - 1; i >= 0; i--)
                {
                    if (IDCategory[i] == selectedCat)
                    {
                        IDProduct.RemoveAt(i);
                        NamaProduk.RemoveAt(i);
                        Harga.RemoveAt(i);
                        Stock.RemoveAt(i);
                        IDCategory.RemoveAt(i);
                        dtProdukSimpan.Rows.RemoveAt(i);
                    }
                }
                IDcat2.RemoveAt(dataGridView2.CurrentRow.Index);
                Namacategory.RemoveAt(dataGridView2.CurrentRow.Index);
                dataGridView1.DataSource = dtProdukSimpan;
                comboBox_filter.Items.Remove(textBox_nama1.Text);
                comboBox_category.Items.Remove(textBox_nama1.Text);
            }
            dtCategory.Rows.Clear();
            dtProdukSimpan.Rows.Clear();
            for (int i = 0;i < IDProduct.Count;i++)
            {
                dtProdukSimpan.Rows.Add(IDProduct[i], NamaProduk[i], Harga[i], Stock[i], IDCategory[i]);
            }
            for (int j = 0; j < IDcat2.Count; j++)
            {
                dr = dtCategory.NewRow();
                dr[0] = IDcat2[j];
                dr[1] = Namacategory[j];
                dtCategory.Rows.Add(dr);
            }
            textBox_nama1.Clear();
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox_nama1.Text = dataGridView2.CurrentRow.Cells["Nama Category"].Value.ToString();
        }
        private void comboBox_filter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtProdukTampil;
            dtProdukTampil.Clear();
            string selectedcatId = "";
            bool yes = false;
            foreach(DataRow dr in dtCategory.Rows)
            {
                if (comboBox_filter.Text == dr[1].ToString())
                {
                    selectedcatId = dr[0].ToString();
                    yes = true;
                    break;
                }
            }
            if (yes == true)
            {
                foreach (DataRow dr2 in dtProdukSimpan.Rows)
                {
                    if (dr2["ID Category"].ToString() == selectedcatId)
                    {
                        dtProdukTampil.Rows.Add(dr2["ID Product"], dr2["Nama Product"], dr2["Harga"], dr2["Stock"], dr2["ID Category"]);
                    }
                }
            }
            dataGridView1.ClearSelection();
        }

    }
}

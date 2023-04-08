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

namespace THA_W7_ANGEL_L
{
    public partial class Form2 : Form
    {
        public int hinput;
        string huruftebak = "";
        int Row = 0;
        int Col = -1;
        int coba = 0;
        public bool win = false;
        string katarandom = "";
        Random random = new Random();
        List<string> list = new List<string>();
        List<Button> buttonlist = new List<Button>();
        string path = @"word.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(path);
            string content = reader.ReadToEnd();
            reader.Close();
            string[] kata = content.Split(',');
            list = kata.ToList();
            katarandom = list[random.Next(list.Count)];
            //MessageBox.Show(katarandom);
            for (int i = 0; i < hinput; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(50 * j + 60, 50 * i + 30);
                    button.Tag = i.ToString() + "," + j.ToString();
                    button.Click += new EventHandler(button_keyboard_Click);
                    buttonlist.Add(button);
                    Controls.Add(buttonlist[buttonlist.Count - 1]);
                }
            }
        }
        private void button_keyboard_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && huruftebak.Length < 5)
            {
                foreach (Button button in buttonlist)
                {
                    if (button.Text == "")
                    {
                        button.Text = btn.Text;
                        huruftebak += btn.Text;
                        Col = buttonlist.IndexOf(button) % 5;
                        break;
                    }
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            for (int i = 4; i >= 0; i--)
            {
                int a = Row * 5 + i;
                if (buttonlist[a].Text != "")
                {
                    buttonlist[a].Text = "";
                    if (i < Col)
                    {
                        Col = i;
                    }
                    break;
                }
            }
            huruftebak = "";
            for (int j = 0; j < 5; j++)
            {
                int a = Row * 5 + j;
                if (buttonlist[a].Text != "")
                {
                    huruftebak += buttonlist[a].Text;
                }
            }

        }
        private void button_Enter_Click(object sender, EventArgs e)
        {
            if (huruftebak.Length < 5 )
            {
                MessageBox.Show("Too Short!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (list.Contains(huruftebak.ToLower()))
                {
                    int hurufbenar = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        if (katarandom[i] == huruftebak.ToLower()[i])
                        {
                            buttonlist[Row * 5 + i].BackColor = Color.DarkSeaGreen;
                            hurufbenar++;
                        }
                        else if (katarandom.Contains(huruftebak.ToLower()[i]))
                        {
                            buttonlist[Row * 5 + i].BackColor = Color.LightYellow;
                        }
                        else
                        {
                            buttonlist[Row * 5 + i].BackColor = Color.White;
                        }
                    }
                    if (hurufbenar == 5)
                    {
                        MessageBox.Show("You Win!!!");
                        win = true;
                    }
                    else
                    {
                        coba++;
                        huruftebak = "";
                        win = false;
                    }

                    if (coba == hinput)
                    {
                        MessageBox.Show("You lose! The word is: " + katarandom.ToUpper());
                    }
                    Row++;
                    Col++;
                }
                else
                {
                    MessageBox.Show("The word is not in the word list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Col = -1;
                }
            }
        }

    }
}

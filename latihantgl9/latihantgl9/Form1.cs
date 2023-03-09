using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace latihantgl9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                checkBox_tmn.Enabled = false;
                checkBox_sm.Enabled = false;
                checkBox_sekolah.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false; 
                checkBox_tmn.Enabled = true;
                checkBox_sm.Enabled = true;
                checkBox_sekolah.Enabled = true;
            }
        }

        private void checkBox_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_agree.Checked)
            {
                button_submit.Enabled = true;
            }
            else
            {
                button_submit.Enabled = false;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string text = "Saya mengetahui UC dari ";
            if(checkBox_tmn.Checked == false && checkBox_sm.Checked == false && checkBox_sekolah.Checked == false && checkBox1.Checked == false)
            {
                MessageBox.Show("Checkbox harus diisi minimal satu", "Message 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (checkBox_tmn.Checked)
                {
                    text += " Teman ";
                }
                if (checkBox_sm.Checked)
                {
                    text += "Social Media ";
                }
                if (checkBox_sekolah.Checked)
                {
                    text += "Sekolah ";
                }
                if (checkBox_agree.Checked)
                {
                    text += textBox1.Text;
                }
                MessageBox.Show(text, "Tau UC darimana?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        

        private void radioButton_red_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_red.Checked)
            {
               panel1.BackColor = Color.Red;
            }
        }

        private void radioButton_blue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_blue.Checked)
            {
                panel1.BackColor = Color.LightBlue;
            }
        }

        private void radioButton_green_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_green.Checked)
            {
                panel1.BackColor = Color.LightGreen;
            }
        }

        private void radioButton_hitam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hitam.Checked)
            {
                panel1.ForeColor= Color.Black;
            }
        }

        private void radioButton_putih_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_putih.Checked)
            {
                panel1.ForeColor = Color.White;
            }
        }

        private void radioButton_pink_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_pink.Checked)
            {
                panel1.ForeColor = Color.Orange;
            }
        }

        private void radioButton_40_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_40.Checked)
            {
                MessageBox.Show("Anda bodoh", "Jawabanmu");
            }
        }

        private void radioButton_50_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_50.Checked)
            {
                MessageBox.Show("Anda Benar", "Jawabanmu");
            }
        }

        private void radioButton_60_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_60.Checked)
            {
                MessageBox.Show("Anda goblok", "Jawabanmu");
            }
        }

        private void radioButton_100_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_100.Checked)
            {
                MessageBox.Show("Anda tolol", "Jawabanmu");
            }
        }
        private void checkBox_nasgor_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox_nasgor.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            Console.WriteLine(count);
        }
        private void checkBox_Migoreng_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_Migoreng.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            Console.WriteLine(count);
        }

        private void checkBox_spageti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_spageti.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            Console.WriteLine(count);
        }

        private void checkBox_bakso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_bakso.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            Console.WriteLine(count);
        }
    }
}

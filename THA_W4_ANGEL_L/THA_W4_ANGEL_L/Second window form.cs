using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_ANGEL_L
{
    public partial class Second_window_form : Form
    {
        public Second_window_form()
        {
            InitializeComponent();
            button_magic.Enabled = false;
        }
        public string LabelPernyataan
        {
            get { return label_pernyataan.Text; }
            set { label_pernyataan.Text = value; }
        }
        private void button_magic_Click(object sender, EventArgs e)
        {
            Main_Window_Form form1 = Application.OpenForms["Main_Window_Form"] as Main_Window_Form;
            if (radioButton_pink.Checked == false && radioButton_blue.Checked == false && radioButton_yellow.Checked == false && radioButton_purple.Checked == false &&
               radioButton_black.Checked == false && radioButton_gray.Checked == false && radioButton_Olive.Checked == false && radioButton_Turqoise.Checked == false)
            {
                MessageBox.Show("Choose 1 of the choices!!");
            }
            else
            {
                if (radioButton_pink.Checked)
                {
                    form1.BackColor = Color.LightPink;
                }
                if (radioButton_blue.Checked)
                {
                    form1.BackColor = Color.LightBlue;
                }
                if (radioButton_yellow.Checked)
                {
                    form1.BackColor = Color.LightYellow;
                }
                if (radioButton_purple.Checked)
                {
                    form1.BackColor = Color.MediumSlateBlue;
                }
                if (radioButton_gray.Checked)
                {
                    form1.BackColor = Color.Silver;
                }
                if (radioButton_Turqoise.Checked)
                {
                    form1.ForeColor = Color.Turquoise;
                }
                if (radioButton_Olive.Checked)
                {
                    form1.ForeColor = Color.Olive;
                }
                if (radioButton_black.Checked)
                {
                    form1.ForeColor = Color.Black;
                }
                if (form1 != null)
                {
                    form1.Refresh();
                }
            }
        }
        private void checkBox_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_agree.Checked && checkBox_true.Checked)
            {
                button_magic.Enabled = true;
            }
            else
            {
                button_magic.Enabled = false;
            }
        }
        private void checkBox_true_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_agree.Checked && checkBox_true.Checked)
            {
                button_magic.Enabled = true;
            }
            else
            {
                button_magic.Enabled = false;
            }
        }

    }
}
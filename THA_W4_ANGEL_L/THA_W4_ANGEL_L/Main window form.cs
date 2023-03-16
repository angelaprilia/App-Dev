using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_ANGEL_L
{

    public partial class Main_Window_Form : Form
    {
         
        public Main_Window_Form()
        {
            InitializeComponent();
            button_submit.Enabled = false;
        }
        bool buttonclick = false;
        private void button_submit_Click(object sender, EventArgs e)
        {
            Second_window_form form2 = Application.OpenForms["Second_window_form"] as Second_window_form;
            if (textBox_name.Text == "" || textBox_favartist.Text == "")
            {
                MessageBox.Show("Input Correctly!!!!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string kalimat = $"Hi, my name  is " + textBox_name.Text + " and my favourite artist is " + textBox_favartist.Text;
                form2.LabelPernyataan = kalimat;
                form2.Refresh();
            }
        }

        private void button_nextform_Click(object sender, EventArgs e)
        {
            buttonclick = true;
            Second_window_form form2 = new Second_window_form();
            if (checkBox1.Checked && buttonclick == true)
            {
                button_submit.Enabled = true;
            }
            else
            {
                buttonclick = false;
            }
            form2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && button_nextform.Enabled== true)
            {
                button_submit.Enabled = true;
            }
        }
    }
}

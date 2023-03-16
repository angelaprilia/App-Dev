using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_ANGEL_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox_age.Text);
            string umur;
            if (age < 18)
            {
                umur = "You are a minor";
            }
            else
            {
                umur = "You are an adult";
            }
            MessageBox.Show($"Name : { textBox_name.Text} \nEmail :  {textBox_email.Text} \nPhone Number : {textBox_phonenumber.Text} \n{umur}");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_email.Clear();
            textBox_phonenumber.Clear();
        }
    }
}

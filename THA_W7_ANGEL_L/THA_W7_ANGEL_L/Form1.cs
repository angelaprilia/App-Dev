using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_ANGEL_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(textBox_input.Text);
            if (input > 3 )
            {
                Form2 form2 = new Form2();
                form2.hinput = input;
                form2.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Input harus lebih dari angka 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_input.Clear();
            }
        }
    }
}

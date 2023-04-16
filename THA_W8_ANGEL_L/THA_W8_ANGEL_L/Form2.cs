using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W8_ANGEL_L
{
    public partial class Form2 : Form
    {
        Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
        private int index;
        public PictureBox PictureBoxForm2;
        private List<string> piclist;
        private List<string> judullist;
        private List<string> sinopsislist;
        public Form2(int index, List<string> judullist, List<string> sinopsislist, List<string> piclist, Dictionary<string, List<string>> list)
        {
            InitializeComponent();
            this.index = index;
            this.judullist = judullist;
            this.sinopsislist = sinopsislist;
            this.piclist = piclist;
            this.list = list;
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(250, 250);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Location = new Point(12, 12);
            string imagePath = $@".\MOVIE LIST\{index}.jpg";
            Image image = Image.FromFile(imagePath);
            pictureBox.Image = image;
            this.panel1.Controls.Add(pictureBox);

            Label label = new Label();
            label.Text = judullist[index];
            label.AutoSize = true;
            label.Font = new Font("Serif", 25, FontStyle.Bold);
            label.Location = new Point(275, 12);
            this.panel1.Controls.Add(label);

            Label labeltipe = new Label();
            labeltipe.Text = "2D";
            labeltipe.AutoSize = true;
            labeltipe.Font = new Font("Serif", 20, FontStyle.Bold);
            labeltipe.Location = new Point(label.Right + 20, 15);
            this.panel1.Controls.Add(labeltipe);

            Label labelsinopsis = new Label();
            labelsinopsis.Text = sinopsislist[index];
            labelsinopsis.AutoSize = true;
            labelsinopsis.Font = new Font("Serif", 10, FontStyle.Regular);
            labelsinopsis.Location = new Point(280, 60);
            labelsinopsis.MaximumSize = new Size(450, 250);
            labelsinopsis.TextAlign = ContentAlignment.TopLeft;
            this.panel1.Controls.Add(labelsinopsis);

            Button buttonback = new Button();
            buttonback.Text = "Back";
            buttonback.Size = new Size(100, 40);
            buttonback.BackColor = Color.Gray;
            buttonback.Location = new Point(650, label.Bottom + 300);
            buttonback.Click += ButtonBack_Click;
            this.panel1.Controls.Add(buttonback);

            Button btn = new Button();
            btn.Text = "12.35";
            btn.Size = new Size(100, 40);
            btn.Tag = 1;
            btn.Location = new Point(50, pictureBox.Bottom + 30);
            btn.Click += Button_Click;
            this.panel1.Controls.Add(btn);

            Button btn1 = new Button();
            btn1.Text = "15.45";
            btn1.Size = new Size(100, 40);
            btn1.Tag = 2;
            btn1.Location = new Point(160, pictureBox.Bottom + 30);
            btn1.Click += Button_Click;
            this.panel1.Controls.Add(btn1);

            Button btn2 = new Button();
            btn2.Text = "18.20";
            btn2.Size = new Size(100, 40);
            btn2.Tag = 3;
            btn2.Location = new Point(270, pictureBox.Bottom + 30);
            btn2.Click += Button_Click;
            this.panel1.Controls.Add(btn2);


        }
        private void ButtonBack_Click (object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Dock = DockStyle.Fill;
            form1.FormBorderStyle = FormBorderStyle.None;
            form1.TopLevel = false;
            form1.ControlBox = false;
            form1.list = this.list;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form1);
            form1.Show();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string jamtayang = btn.Text;
            string jamke = Convert.ToString(btn.Tag);
            Form3 form3 = new Form3(index, judullist, sinopsislist, jamtayang, jamke, list);
            form3.Dock = DockStyle.Fill;
            form3.TopLevel = false;
            form3.AutoScroll = true;
            form3.ControlBox = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form3);
            form3.Show();
            
        }
    }
}

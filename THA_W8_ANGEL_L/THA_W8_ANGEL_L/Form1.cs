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
using static System.Windows.Forms.LinkLabel;

namespace THA_W8_ANGEL_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @".\MOVIE LIST\list movie.txt";
        List<string> sinopsislist = new List<string>();
        List<string> judullist = new List<string>();
        List<string> piclist = new List<string>();
        public Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
        public static string ratedmovie;
        public void Form1_Load(object sender, EventArgs e)
        {
            StreamReader movie = new StreamReader(path);
            string lines;
            while ((lines = movie.ReadLine()) != null)
            {
                string[] parts = lines.Split('_');
                string sinopsis = parts[0];
                sinopsislist.Add(sinopsis);
                if (parts.Length >= 2)
                {
                    string[] detail = parts[1].Split('*');
                    if (detail.Length >= 2)
                    {
                        string judul = detail[0];
                        judullist.Add(judul);
                        string pic = detail[1];
                        piclist.Add(pic);
                    }
                }
            }

            Label labelnp = new Label();
            labelnp.Text = "Now Playing";
            labelnp.AutoSize = true;
            labelnp.Font = new Font("Serif", 20, FontStyle.Bold);
            labelnp.ForeColor = Color.White;
            labelnp.BackColor = Color.DarkGreen;
            labelnp.Location = new Point(12, 12);
            this.panel1.Controls.Add(labelnp);

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int i = row * 4 + col;
                    if (i >= piclist.Count)
                    {
                        break;
                    }

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile($@".\MOVIE LIST\{i}.jpg");
                    pictureBox.Size = new Size(200, 200);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(col * 175 + 70, row * 275 + 70);
                    pictureBox.Click += PictureBox_Click;
                    pictureBox.Tag = i;
                    this.panel1.Controls.Add(pictureBox);

                    Label labeljudul = new Label();
                    labeljudul.Text = judullist[i];
                    labeljudul.AutoSize = true;
                    labeljudul.Font = new Font("Serif", 12, FontStyle.Bold);
                    labeljudul.Location = new Point(col * 175 + 125, row * 275 + 275);
                    this.panel1.Controls.Add(labeljudul);

                    Label labelrated = new Label();
                    labelrated.AutoSize = true;
                    labelrated.Font = new Font("Serif", 12, FontStyle.Bold);
                    labelrated.Location = new Point(col * 175 + 130, row * 275 + 300);
                    this.panel1.Controls.Add(labelrated);
                    if (i <= 4)
                    {
                        labelrated.Text = "PG-13";
                        labelrated.BackColor = Color.SlateGray;
                        ratedmovie = labelrated.Text;
                    }

                    Label label2 = new Label();
                    label2.AutoSize = true;
                    label2.Font = new Font("Serif", 12, FontStyle.Bold);
                    label2.Location = new Point(col * 175 + 150, row * 275 + 300);
                    this.panel1.Controls.Add(label2);
                    if (i == 5|| i ==6 || i ==  7 || i==8 || i==9 || i ==10 )
                    {
                        label2.Text = "PG";
                        label2.BackColor = Color.DarkGray;
                    }
                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            int index = (int)pictureBox.Tag;
            Form2 form2 = new Form2(index, judullist, sinopsislist, piclist, list);
            form2.TopLevel = false;
            form2.ControlBox = false;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
            form2.PictureBoxForm2 = pictureBox;
            form2.AutoScroll = true;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form2);
            form2.Show();
        }

    }
}

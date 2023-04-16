using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W8_ANGEL_L
{
    public partial class Form3 : Form
    {
        Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
        private List<Button> buttonList = new List<Button>();
        private List<Button> unavailable = new List<Button>();
        private List<Button> pilih = new List<Button>();
        private int index;
        public PictureBox pictureboxform2;
        private List<string> judullist;
        private List<string> sinopsislist;
        private List<string> piclist;
        string jamtayang;
        string jamke;
        public Form3(int index, List<string> judullist, List<string> sinopsislist, string jamtayang, string jamke, Dictionary<string, List<string>> list )
        {
            InitializeComponent();
            this.index = index;
            this.judullist = judullist;
            this.sinopsislist = sinopsislist;
            this.jamtayang = jamtayang;
            this.jamke = jamke;
            this.list = list;
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            string filmjam = $"{Convert.ToString(index)} {jamke}";
            Label labeltayang = new Label();
            labeltayang.Location = new Point(12, 12);
            labeltayang.Text = $" {judullist[index]} {jamtayang}";
            labeltayang.Font = new Font("Serif", 15, FontStyle.Bold);
            labeltayang.AutoSize = true;
            this.panel1.Controls.Add(labeltayang);

            

            for (int i = 0; i < 10; i++)
            {
                char col = (char)('A' + i);
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Text = $"{col} {j + 1}";
                    button.Click += Button_Click;
                    button.Location = new Point(50 * j + 180, 50 * i + 30);
                    this.panel1.Controls.Add(button);
                    this.buttonList.Add(button);
                }
            }
            if (list.ContainsKey(filmjam))
            {
                List<string> seatmerah = list[filmjam];
                foreach (string seat in seatmerah)
                {
                    int index = buttonList.FindIndex(button => button.Text == seat);
                    buttonList[index].BackColor = Color.Red;
                }
            }
            else
            {
                List<string> seatmerah = new List<string>();
                Random random = new Random();
                int acak = random.Next(0, 71);
                for (int i = 0; i < acak; i++)
                {
                    int mindex = random.Next(0, 100);
                    buttonList[mindex].BackColor = Color.Red;
                    seatmerah.Add(buttonList[mindex].Text);
                }
                list[filmjam] = seatmerah;
            }
            foreach (Button button in buttonList)
            {
                if (button.BackColor != Color.Red)
                {
                    button.BackColor = Color.Green;
                }
            }
            

            Label labelscreen = new Label();
            labelscreen.Size = new Size(300, 50);
            labelscreen.Location = new Point(350, 600);
            labelscreen.Text = "Screen Area";
            labelscreen.Font = new Font("Serif", 15, FontStyle.Bold);
            this.panel1.Controls.Add(labelscreen);

            Button buttonreserve = new Button();
            buttonreserve.Size = new Size(100, 50);
            buttonreserve.Location = new Point(20, 650);
            buttonreserve.BackColor = Color.Green;
            buttonreserve.Text = "Reserve";
            buttonreserve.Font = new Font("Serif", 15, FontStyle.Bold);
            buttonreserve.Click += new EventHandler(ButtonReserve_Click);
            this.panel1.Controls.Add(buttonreserve);

            Button buttonreset = new Button();
            buttonreset.Size = new Size(100, 50);
            buttonreset.Location = new Point(700, 650);
            buttonreset.BackColor = Color.Gray;
            buttonreset.Text = "Reset";
            buttonreset.Font = new Font("Serif", 15, FontStyle.Bold);
            buttonreset.Click += new EventHandler(ButtonReset_Click);
            this.panel1.Controls.Add(buttonreset);

            Button buttonback2 = new Button();
            buttonback2.Size = new Size(100, 50);
            buttonback2.Location = new Point(700, 12);
            buttonback2.BackColor = Color.Gray;
            buttonback2.Text = "Back";
            buttonback2.Font = new Font("Serif", 12, FontStyle.Bold);
            buttonback2.Click += new EventHandler(ButtonBack2_Click);
            this.panel1.Controls.Add(buttonback2);


        }

        private void Button_Click (object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            if (clickedButton.BackColor == Color.Green)
            {
                clickedButton.BackColor = Color.Yellow;
                pilih.Add(clickedButton);
                
            }
            else if (clickedButton.BackColor == Color.Yellow)
            {
                clickedButton.BackColor = Color.Green;
                pilih.Remove(clickedButton);
            }
            else if (clickedButton.BackColor == Color.Red)
            {
                MessageBox.Show("This seat is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            List<string> seatmerah = new List<string>();
            foreach (Button button in buttonList)
            {
                if (button.BackColor == Color.Red || button.BackColor == Color.Yellow)
                {
                    button.BackColor = Color.Green;
                    pilih.Clear();
                    unavailable.Clear();
                }
            }
            foreach (Button button in buttonList)
            {
                if (button.BackColor == Color.Red)
                {
                    seatmerah.Add(button.Text);
                }
            }
            string filmjam = $"{Convert.ToString(index)} {jamke}";
            list[filmjam] = seatmerah;
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            List<string> seatmerah = new List<string>();
            
            if (pilih.Count == 0)
            {
                MessageBox.Show("No seats selected for reservation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                string pilihseat = string.Join(", ", pilih.Select(button => button.Text));
                DialogResult result = MessageBox.Show($"Are you sure you want to reserve {pilihseat} ?", "Order Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Seats reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Button button in pilih)
                    {
                        button.BackColor = Color.Red;
                    }
                    foreach (Button button in buttonList)
                    {
                        if (button.BackColor == Color.Red)
                        {
                            seatmerah.Add(button.Text);
                        }
                    }
                    string filmjam = $"{Convert.ToString(index)} {jamke}";
                    list[filmjam] = seatmerah;
                    pilih.Clear();
                    
                }
                else
                {
                    foreach (Button button in pilih)
                    {
                        button.BackColor = Color.Green;
                    }
                    pilih.Clear();

                }
            }
            

        }
        private void ButtonBack2_Click (object sender, EventArgs e)
        {
            Form2 form2 = new Form2(index, judullist, sinopsislist, piclist, list);
            form2.Dock = DockStyle.Fill;
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.TopLevel = false;
            form2.ControlBox = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(form2);
            form2.Show();
        }
    }
}

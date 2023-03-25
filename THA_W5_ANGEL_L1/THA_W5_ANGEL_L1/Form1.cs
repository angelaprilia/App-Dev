using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W5_ANGEL_L1
{
    public partial class Form1 : Form
    {
        string choosencountry;
        string itembaru;
        string selectedplayer = "";
        public Form1()
        {
            InitializeComponent();
        }
        public class TeamClass
        {
            public string teamName { get; set; }
            public string teamCountry { get; set; }
            public string teamCity { get; set; }

            private List<PlayerClass> players = new List<PlayerClass>();
            public void addplayer(string playernum, string playername,  string playerpos)
            {
                PlayerClass playerClass = new PlayerClass();
                playerClass.playernum = playernum;
                playerClass.playername = playername;
                playerClass.playerpos = playerpos;
                Players.Add(playerClass);
            }
            public List<PlayerClass> Players
            {
                get { return players; }
                set { players = value; }
            }
        }
        public class PlayerClass
        {
            public string playername { get; set; }
            public string playernum { get; set; }
            public string playerpos { get; set; }

        }

        public List<TeamClass> teams = new List<TeamClass>();

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox_hasil.Sorted = true;
            TeamClass teamone = new TeamClass();
            teamone.teamName = "Manchester United";
            teamone.teamCountry = "England";
            teamone.teamCity = "Manchester";
            TeamClass isi = teamone;
            teamone.addplayer("01", "David De Gea", "GK");
            teamone.addplayer("02", "Victor Lindelof", "DF");
            teamone.addplayer("03", "Eric Bailly", "DF");
            teamone.addplayer("05", "Marry Maguire", "DF");
            teamone.addplayer("08", "Bruno Fernandez", "MF");
            teamone.addplayer("09", "Anthony Martial", "FW");
            teamone.addplayer("10", "Marcus Rashford", "FW");
            teamone.addplayer("12", "Tyrell Malacia", "DF");
            teamone.addplayer("14", "Christian Eriksen", "MF");
            teamone.addplayer("18", "Casemiro", "MF");
            teamone.addplayer("33", "Brandon Williams ", "DF");
            teams.Add(isi);

            TeamClass teamtwo = new TeamClass();
            teamtwo.teamName = "Totthenham Hotspur F.C";
            teamtwo.teamCountry = "England";
            teamtwo.teamCity = "Tottenham";
            isi = teamtwo;
            teamtwo.addplayer("01", "Hugo Lloris", "GK");
            teamtwo.addplayer("04", "Oliver Skipp", "MF");
            teamtwo.addplayer("06", "Pape Sarr", "MF");
            teamtwo.addplayer("07", "Son Heung Min", "FW");
            teamtwo.addplayer("10", "Harry Kane", "FW");
            teamtwo.addplayer("16", "Yago Alonso", "MF");
            teamtwo.addplayer("17", "Cristian Romero", "DF");
            teamtwo.addplayer("23", "Pedro Porro", "DF");
            teamtwo.addplayer("25", "Japhet Tanganga", "DF");
            teamtwo.addplayer("34", "Clement Lenglet", "DF");
            teamtwo.addplayer("48", "Maksim Paskotsi", "DF");
            teams.Add(isi);

            TeamClass team3 = new TeamClass();
            team3.teamName = "Paris Saint-Germain";
            team3.teamCountry = "France";
            team3.teamCity = "Paris";
            isi = team3;
            team3.addplayer("02", "Achrad Hakimi", "DF");
            team3.addplayer("04", "Sergio Ramos", "DF");
            team3.addplayer("06", "Marco Verratti", "MF");
            team3.addplayer("10", "Neymar Jr", "FW");
            team3.addplayer("14", "Juan Bernat", "DF");
            team3.addplayer("16", "Sergio Rico", "GK");
            team3.addplayer("17", "Vitinha", "MF");
            team3.addplayer("26", "Nordi Mukiele", "DF");
            team3.addplayer("28", "Carlos Soler", "MF");
            team3.addplayer("30", "Lionel Messi", "FW");
            team3.addplayer("44", "Hugo Ekitike", "FW");
            teams.Add(isi);
        }
        private void comboBox_choosecountry_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            comboBox_chooseteam.Text = "";
            comboBox_chooseteam.Items.Clear();
            choosencountry = comboBox_choosecountry.SelectedItem.ToString();
            foreach (TeamClass team in teams)
            {
                if (team.teamCountry == choosencountry)
                {
                    comboBox_chooseteam.Items.Add(team.teamName);
                }
            }
        }

        private void comboBox_chooseteam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            listBox_hasil.Items.Clear();
            itembaru = comboBox_chooseteam.SelectedItem.ToString();
            TeamClass team = null;
            foreach (TeamClass choosencountry in teams)
            {
                if (choosencountry.teamName == itembaru)
                {
                    team = choosencountry;
                }
            }
            foreach (PlayerClass player in team.Players)
            {
                listBox_hasil.Items.Add($"( {player.playernum} )  {player.playername} , {player.playerpos}");
            }
        }

        private void button_add1_Click_1(object sender, EventArgs e)
        {
            if (textBox_teamcountry.Text == "" || textBox_teamcity.Text == "" || textBox_teamname.Text == "")
            {
                MessageBox.Show("ALL FIELDS NEED TO BE FILLED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool teamsudahada = false;
                foreach (TeamClass team in teams)
                {
                    if (team.teamName == textBox_teamname.Text)
                    {
                        teamsudahada = true;
                        MessageBox.Show("Team Cannot Be The Same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                if (!teamsudahada)
                {
                    TeamClass team = new TeamClass();
                    team.teamName = textBox_teamname.Text;
                    team.teamCountry = textBox_teamcountry.Text;
                    team.teamCity = textBox_teamcity.Text;
                    teams.Add(team);
                }


                foreach (TeamClass team in teams)
                {
                    if (comboBox_choosecountry.Items.Contains(team.teamCountry) == false)
                    {
                        comboBox_choosecountry.Items.Add(team.teamCountry);
                    }
                }
                textBox_teamname.Clear();
                textBox_teamcountry.Clear();
                textBox_teamcity.Clear();
            }
        }

        private void button_add2_Click_1(object sender, EventArgs e)
        {

            if (textBox_playername.Text == "" || textBox_playernumber.Text == "" || comboBox_playerposition.SelectedIndex < 0)
            {
                MessageBox.Show("All Fields Need to be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox_hasil.Sorted = true;
                string teampilih = comboBox_chooseteam.SelectedItem.ToString();
                foreach (TeamClass teams in teams)
                {
                    if (teams.teamName == teampilih)
                    {
                        bool nomorsudahada = false;
                        bool namasudahada = false;
                        foreach (PlayerClass player in teams.Players)
                        {
                            if (player.playernum == textBox_playernumber.Text)
                            {
                                nomorsudahada = true;
                                break;
                            }
                            if (player.playername == textBox_playername.Text)
                            {
                                namasudahada = true;
                                break;
                            }
                        }
                        if (namasudahada == false && nomorsudahada == false)
                        {
                            teams.addplayer(textBox_playernumber.Text, textBox_playername.Text, comboBox_playerposition.SelectedItem.ToString());
                        }
                        else if(namasudahada == true)
                        {
                            MessageBox.Show("Player with same name is found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            MessageBox.Show("Player with same number is found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                listBox_hasil.Items.Clear();
                string namapilih = comboBox_chooseteam.SelectedItem.ToString();
                TeamClass team = new TeamClass();
                foreach (TeamClass teamss in teams)
                {
                    if (teamss.teamName == namapilih)
                    {
                        team = teamss;
                        foreach (PlayerClass player in teamss.Players)
                        {
                            listBox_hasil.Items.Add($"( {player.playernum} )  {player.playername} , {player.playerpos}");
                        }
                    }
                   

                }
                textBox_playernumber.Clear();
                textBox_playername.Clear();
            }
        }
        private void button_remove_Click(object sender, EventArgs e)
        {
            foreach (TeamClass team in teams)
            {
                if (team.teamName == comboBox_chooseteam.SelectedItem.ToString())
                {
                    if (team.Players.Count <= 11)
                    {
                        MessageBox.Show("Too Little Players", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    for (int i = 0; i < team.Players.Count; i++)
                    {
                        if ($"( {team.Players[i].playernum} )  {team.Players[i].playername} , {team.Players[i].playerpos}" == selectedplayer)
                        {
                            team.Players.RemoveAt(i);
                            listBox_hasil.Items.Clear();
                            TeamClass teamss = null;
                            foreach (TeamClass choosencountry in teams)
                            {
                                if (choosencountry.teamName == itembaru)
                                {
                                    teamss = choosencountry;
                                }
                            }
                            foreach (PlayerClass player in team.Players)
                            {
                                listBox_hasil.Items.Add($"( {player.playernum} )  {player.playername} , {player.playerpos}");
                            }
                        }
                    }
                    break;
                }
            }

        }

        private void listBox_hasil_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedplayer = listBox_hasil.SelectedItem.ToString();
        }
    }
}

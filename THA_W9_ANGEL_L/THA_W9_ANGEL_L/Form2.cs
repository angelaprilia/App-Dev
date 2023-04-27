using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace THA_W9_ANGEL_L
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        string connectionstring = "server=localhost;uid=root;pwd=r123;database=premier_league";
        MySqlConnection sqlconnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string query;

        DataTable dtteam = new DataTable();
        DataTable dtplayer = new DataTable();
        DataTable dtinfo = new DataTable();
        DataTable dtdmatch = new DataTable();

        private void Form2_Load(object sender, EventArgs e)
        {
            
            query = "SELECT team_name from premier_league.team;";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);

            comboBox_team.DataSource = dtteam;
            comboBox_team.DisplayMember = "team_name";
            if (comboBox_player.Text == "" || comboBox_team.Text == "")
            {
                button1.Enabled = false;
            }
            comboBox_team.Text = "";
            comboBox_player.Text = "";
        }

        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtplayer = new DataTable();
            query = $"SELECT p.player_id as 'ID', p.player_name as 'Player' \r\nfrom player p, team t \r\nwhere t.team_id = p.team_id and t.team_name = '{comboBox_team.Text}' order by 1 asc;";
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtplayer);

            comboBox_player.DataSource = dtplayer;
            comboBox_player.ValueMember = "ID";
            comboBox_player.DisplayMember = "Player";
            
            comboBox_player.Text = "";
            button1.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            dtinfo = new DataTable();
            query = $"SELECT p.player_name, t.team_name, if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'position', n.nation as 'nationality', p.team_number \r\nfrom player p, team t, nationality n \r\nwhere t.team_id = p.team_id and t.team_name = '{comboBox_team.Text}' and p.player_name = '{comboBox_player.Text}' and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtinfo);
            
            dtdmatch = new DataTable();
            query = $"SELECT d.type, count(*) as count \r\nfrom dmatch d \r\nwhere d.player_id = '{comboBox_player.SelectedValue}' group by d.type;";
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtdmatch);

            string playername = dtinfo.Rows[0]["player_name"].ToString();
            string teamname = dtinfo.Rows[0]["team_name"].ToString();
            string position = dtinfo.Rows[0]["position"].ToString();
            string nationality = dtinfo.Rows[0]["nationality"].ToString();
            string squadnumber = dtinfo.Rows[0]["team_number"].ToString();

            int yellowcard = 0;
            int redcard = 0;
            int goalscored = 0;
            int penaltymissed = 0;

            foreach (DataRow row in dtdmatch.Rows)
            {
                string tipe = row["type"].ToString();
                int count = Convert.ToInt32(row["count"]);
                if (tipe == "CY")
                {
                    yellowcard = count;
                }
                else if (tipe == "CR")
                {
                    redcard = count;
                }
                else if (tipe == "GO")
                {
                    goalscored = count;
                }
                else if (tipe == "PM")
                {
                    penaltymissed = count;
                }
            }
            label_name.Text = "Player Name       : " + playername;
            label_team.Text = "Team Name        : " + teamname;
            label_position.Text = "Position              : " + position;
            label_nationality.Text = "Nationality          : " + nationality;
            label_squadnum.Text = "Squad Number   : " + squadnumber;
            label_yellowcard.Text = "Yellow Card       : " + yellowcard.ToString();
            label_redcard.Text = "Red Card           : " + redcard.ToString();
            label_goal.Text = "Goal Scored       : " + goalscored.ToString();
            label_pinalty.Text = "Penalty Missed   : " + penaltymissed.ToString();
        }

        private void comboBox_player_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}

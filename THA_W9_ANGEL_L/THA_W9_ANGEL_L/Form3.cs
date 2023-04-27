using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace THA_W9_ANGEL_L
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string connectionstring = "server=localhost;uid=root;pwd=r123;database=premier_league";
        MySqlConnection sqlconnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string query;

        DataTable dtteam = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dttgl = new DataTable();
        DataTable dtHomeTeam = new DataTable();
        DataTable dtAwayTeam = new DataTable();
        DataTable dtdetail = new DataTable();

        private void Form3_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name from premier_league.team;";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtteam);

            comboBox_team.DataSource = dtteam;
            comboBox_team.DisplayMember = "team_name";
            if (comboBox_match.Text == "" || comboBox_team.Text == "")
            {
                button1.Enabled = false;
            }
            
            comboBox_team.Text = "";
            comboBox_match.Text = "";

            lhomeplayer.Text = "";
            lawayplayer.Text = "";
            labelteam1.Text = "";
        }

        private void comboBox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtmatch = new DataTable();
            query = $"SELECT m.match_date as 'Match Date', t.team_name as 'Team Home', t1.team_name as 'Team Away', m.match_id as 'ID' \r\nfrom team t, team t1, premier_league.match m \r\nwhere (t.team_name = '{comboBox_team.Text}' or t1.team_name = '{comboBox_team.Text}') and t.team_id = m.team_home and t1.team_id = m.team_away;";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmatch);

            comboBox_match.DataSource = dtmatch;
            comboBox_match.ValueMember = "ID";
            comboBox_match.DisplayMember = "Match Date";
            comboBox_match.Text = "";
            button1.Enabled = false;
            if (comboBox_match.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox_match.SelectedItem;
                lhomeplayer.Text = selectedRow["Team Home"].ToString();
                lawayplayer.Text = selectedRow["Team Away"].ToString();
                labelteam1.Text = selectedRow["Team Home"].ToString() + "   VS   " + selectedRow["Team Away"].ToString();
            }
            lhomeplayer.Text = "";
            lawayplayer.Text = "";
            labelteam1.Text = "";
            

        }
        private void comboBox_match_SelectedIndexChanged(object sender, EventArgs e)
        {
            dttgl = new DataTable();
            query = $"select t.team_name as 'Home Team', t1.team_name as 'Away Team' \r\nfrom premier_league.match m, team t, team t1 \r\nwhere m.team_home = t.team_id and m.team_away = t1.team_id and m.match_id = '{comboBox_team.SelectedValue}';";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dttgl);
            button1.Enabled = true;
            if (comboBox_match.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)comboBox_match.SelectedItem;
                lhomeplayer.Text = selectedRow["Team Home"].ToString();
                lawayplayer.Text = selectedRow["Team Away"].ToString();
                labelteam1.Text = selectedRow["Team Home"].ToString() + "   VS   " + selectedRow["Team Away"].ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtHomeTeam = new DataTable();
            query = $"SELECT t.team_name as 'Team Name', p.player_name as 'Player Name', if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'Position' \r\nfrom player p, team t \r\nwhere p.team_id = t.team_id AND t.team_name = '{lhomeplayer.Text}';";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHomeTeam);
            dataGridView_homeplayer.DataSource = dtHomeTeam;

            dtAwayTeam = new DataTable();
            query = $"SELECT t.team_name as 'Team Name', p.player_name as 'Player Name', if (p.playing_pos = 'D', 'Defender', if (p.playing_pos = 'G', 'GoalKeeper', if (p.playing_pos = 'M', 'MidFielder', 'Forward'))) as 'Position' \r\nfrom player p, team t \r\nwhere p.team_id=t.team_id AND t.team_name='{lawayplayer.Text}';";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtAwayTeam);
            dataGridView_awayplayer.DataSource = dtAwayTeam;

            dtdetail = new DataTable();
            query = $"SELECT d.minute as 'Minute', t.team_name as'Team Name',  p.player_name as 'Player Name', if(d.type = 'CY', 'Yellow Card (CY)', if (d.type = 'CR', 'Red Card (CR)',if (d.type = 'GO', 'Goal (GO)', if (d.type = 'GW', 'Own Goal (GW)', if (d.type = 'GP', 'Goal Penalty (GP)', 'Penalty Missed (PM)'))))) as 'Type'\r\nfrom dmatch d, team t, player p\r\nwhere t.team_id = d.team_id and p.player_id = d.player_id and d.match_id = '{comboBox_match.SelectedValue}' order by 1 asc;";
            sqlconnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlconnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtdetail);
            dataGridView_detail.DataSource = dtdetail;
        }

       
    }
}

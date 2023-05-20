using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace CA_W13_ANGEL_L
{
    public partial class Form1 : Form
    {
        string connectionstring = "server=localhost;uid=root;pwd=r123;database=premier_league";
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dt = new DataTable();
        DataTable nation = new DataTable();
        DataTable teamname = new DataTable();
        DataTable teamname2 = new DataTable();
        DataTable teamname3 = new DataTable();
        DataTable dtmanager = new DataTable();  
        DataTable dtcurrentmanager = new DataTable();   
        string query;
        public Form1()
        {
            try
            {
                string connection = "server=localhost;uid=root;pwd=r123;database=premier_league";
                sqlConnection = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
        }
        private void updateDgv1()
        {
            dt.Clear();
            try
            {
                query = "select p.player_name , n.nation , p.playing_pos , p.team_number, p.height as Height, p.weight as Weight, p.birthdate \r\nfrom player p \r\njoin nationality n on p.nationality_id = n.nationality_id\r\njoin team t on t.team_id = p.team_id\r\nwhere p.status = 1\r\norder by p.player_name;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDgv2()
        {
            dt.Clear();
            try
            {
                query = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate\r\nfrom player p, nationality n\r\nwhere p.nationality_id = n.nationality_id and p.status = '1' order by player_name;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateDgvManager()
        {
            
            try
            {
                dtcurrentmanager.Clear();
                query = $"select m.manager_name, t.team_name, m.birthdate, n.nation, m.manager_id \r\nfrom manager m \r\njoin team t on t.manager_id = m.manager_id \r\n join nationality n on n.nationality_id = m.nationality_id and t.team_id = '{comboBox_teamname3.SelectedValue}' and t.team_name is not null;";
                sqlConnection = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtcurrentmanager);
                dataGridView3.DataSource = dtcurrentmanager;
                dataGridView3.ClearSelection();

                dtmanager.Clear();
                query = $"select  m.manager_name, n.nation, m.birthdate, m.manager_id \r\nfrom manager m \r\njoin nationality n on n.nationality_id = m.nationality_id \r\nwhere m.working = 0;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtmanager);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void executeSQL(string query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                updateDgv2();
            }
        }
        private void executeSQL2(string query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                updateDgv1();
            }
        }
        private void executeSQL3(string query)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            updateDgv1();
            comboBox_teamname2.SelectedIndexChanged -= comboBox_teamname2_SelectedIndexChanged;
            dt = new DataTable();
            query = "select p.player_name, p.team_number, n.nation, p.playing_pos, p.height, p.weight, p.birthdate\r\nfrom player p \r\njoin nationality n on p.nationality_id = n.nationality_id \r\nwhere p.status = 1 \r\norder by player_name;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            nation = new DataTable();
            query = "SELECT n.nation, n.nationality_id from nationality n;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(nation);
            comboBox_nationality.DataSource = nation;
            comboBox_nationality.DisplayMember = "nation";
            comboBox_nationality.ValueMember = "nationality_id";
            comboBox_nationality.SelectedItem = null;

            teamname = new DataTable();
            query = "select t.team_name, t.team_id from team t;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(teamname);
            comboBox_teamname.DataSource = teamname;
            comboBox_teamname.DisplayMember = "team_name";
            comboBox_teamname.ValueMember = "team_id";
            comboBox_teamname.SelectedItem = null;


            teamname2 = new DataTable();
            query = "SELECT team_name , team_id from premier_league.team t;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(teamname2);
            comboBox_teamname2.DataSource = teamname2;
            comboBox_teamname2.DisplayMember = "team_name";
            comboBox_teamname2.ValueMember = "team_id";
            comboBox_teamname2.SelectedItem = null;

            teamname3 = new DataTable();
            query = "SELECT team_name , team_id from premier_league.team t;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(teamname3);
            comboBox_teamname3.DataSource = teamname3;
            comboBox_teamname3.DisplayMember = "team_name";
            comboBox_teamname3.ValueMember = "team_id";
            comboBox_teamname3.SelectedItem = null;

            dtmanager = new DataTable();
            query = "select m.manager_name, n.nation, m.birthdate, m.manager_id\r\nfrom manager m\r\njoin nationality n on n.nationality_id = m.nationality_id\r\nwhere m.working = 0;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtmanager);
            dataGridView2.DataSource = dtmanager;
            dataGridView2.ClearSelection();

            comboBox_teamname2.SelectedIndexChanged += comboBox_teamname2_SelectedIndexChanged;
            dataGridView1.ClearSelection(); 
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_playerid.Text == "" || textBox_teamnumber.Text == "" || comboBox_nationality.Text == "" || textBox_position.Text == "" || textBox_height.Text == "" || textBox_height.Text == "" || string.IsNullOrEmpty(dateTimePicker1.Value.ToString()) || comboBox_teamname.Text == "")
            {
                MessageBox.Show("INPUT YANG LENGKAP!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = textBox_name.Text;
                string id = textBox_playerid.Text;
                string teamnumber = textBox_teamnumber.Text;
                string nationality = comboBox_nationality.SelectedValue.ToString();
                string playingpos = textBox_position.Text;
                string height = textBox_height.Text;
                string weight = textBox_weight.Text;
                string birthdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string teamid = comboBox_teamname.SelectedValue.ToString();
                query = $"insert into player values ('{id}', '{teamnumber}', '{name}', '{nationality}', '{playingpos}', '{height}', '{weight}', '{birthdate}', '{teamid}', '1', '0');";
                executeSQL(query);
                textBox_playerid.Text = "";
                textBox_name.Text = "";
                textBox_teamnumber.Text = "";
                comboBox_nationality.SelectedItem = null;
                textBox_position.Text = "";
                textBox_height.Text = "";
                textBox_weight.Text = "";
                comboBox_teamname.SelectedItem = null;
                dataGridView1.ClearSelection();
            }

        }
        private void comboBox_teamname2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (comboBox_teamname2.SelectedItem != null)
            {
                query = $"select p.player_name , n.nation , p.playing_pos, p.team_number, p.height as Height, p.weight as Weight, p.birthdate as Birthdate\r\nfrom player p \r\njoin nationality n on p.nationality_id = n.nationality_id\r\njoin team t on t.team_id = p.team_id\r\nwhere p.status = 1 and t.team_id = '{comboBox_teamname2.SelectedValue}' \r\norder by p.player_name;";
                sqlConnection = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
            }
            
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                if (dt.Rows.Count >= 11)
                {
                    query = $"update player set status = 0 where player_name = '{dataGridView1.SelectedRows[0].Cells["player_name"].Value}';";
                    executeSQL2(query);
                    dataGridView1.ClearSelection();
                    comboBox_teamname2.SelectedIndexChanged -= comboBox_teamname2_SelectedIndexChanged;
                    comboBox_teamname2.SelectedItem = null;
                    comboBox_teamname2.SelectedIndexChanged += comboBox_teamname2_SelectedIndexChanged;
                }
                else
                {
                    MessageBox.Show("Must Have 11 Players", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Select the player", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBox_teamname3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtcurrentmanager.Clear();
            if (comboBox_teamname3.SelectedItem != null)
            {
                query = $"select m.manager_name, t.team_name, m.birthdate, n.nation, m.manager_id\r\nfrom manager m\r\njoin nationality n on n.nationality_id = m.nationality_id\r\njoin team t on t.manager_id = m.manager_id \r\nwhere t.team_id = '{comboBox_teamname3.SelectedValue}' and t.team_name is not null;";
                sqlConnection = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtcurrentmanager);
                dataGridView3.DataSource = dtcurrentmanager;
                dataGridView3.ClearSelection();
            }

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                query = $"update team set manager_id =  '{dataGridView2.CurrentRow.Cells[3].Value}' where team_id = '{comboBox_teamname3.SelectedValue}';";
                executeSQL3(query);
                query = $"update manager set working = 0 where manager_id = '{dataGridView3.CurrentRow.Cells[4].Value}'";
                executeSQL3(query);
                query = $"update manager set working = 1 WHERE manager_id =  '{dataGridView2.CurrentRow.Cells[3].Value}';";
                executeSQL3(query);
                updateDgvManager();
                dataGridView2.ClearSelection();

            }
            else
            {
                MessageBox.Show("Pick one Manager!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

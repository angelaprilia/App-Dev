namespace THA_W5_ANGEL_L1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_add2 = new System.Windows.Forms.Button();
            this.button_add1 = new System.Windows.Forms.Button();
            this.listBox_hasil = new System.Windows.Forms.ListBox();
            this.comboBox_playerposition = new System.Windows.Forms.ComboBox();
            this.textBox_playernumber = new System.Windows.Forms.TextBox();
            this.textBox_playername = new System.Windows.Forms.TextBox();
            this.textBox_teamcity = new System.Windows.Forms.TextBox();
            this.textBox_teamcountry = new System.Windows.Forms.TextBox();
            this.textBox_teamname = new System.Windows.Forms.TextBox();
            this.comboBox_chooseteam = new System.Windows.Forms.ComboBox();
            this.comboBox_choosecountry = new System.Windows.Forms.ComboBox();
            this.label_addingplayers = new System.Windows.Forms.Label();
            this.label_playerposition = new System.Windows.Forms.Label();
            this.label_playernumber = new System.Windows.Forms.Label();
            this.label_playername = new System.Windows.Forms.Label();
            this.label_addingteam = new System.Windows.Forms.Label();
            this.label_teamcity = new System.Windows.Forms.Label();
            this.label_teamcountry = new System.Windows.Forms.Label();
            this.label_teamname = new System.Windows.Forms.Label();
            this.label_chooseteam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_soccerlist = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add2
            // 
            this.button_add2.Location = new System.Drawing.Point(882, 206);
            this.button_add2.Name = "button_add2";
            this.button_add2.Size = new System.Drawing.Size(105, 34);
            this.button_add2.TabIndex = 45;
            this.button_add2.Text = "Add";
            this.button_add2.UseVisualStyleBackColor = true;
            this.button_add2.Click += new System.EventHandler(this.button_add2_Click_1);
            // 
            // button_add1
            // 
            this.button_add1.Location = new System.Drawing.Point(497, 206);
            this.button_add1.Name = "button_add1";
            this.button_add1.Size = new System.Drawing.Size(103, 34);
            this.button_add1.TabIndex = 44;
            this.button_add1.Text = "Add";
            this.button_add1.UseVisualStyleBackColor = true;
            this.button_add1.Click += new System.EventHandler(this.button_add1_Click_1);
            // 
            // listBox_hasil
            // 
            this.listBox_hasil.FormattingEnabled = true;
            this.listBox_hasil.ItemHeight = 20;
            this.listBox_hasil.Location = new System.Drawing.Point(20, 193);
            this.listBox_hasil.Name = "listBox_hasil";
            this.listBox_hasil.Size = new System.Drawing.Size(311, 164);
            this.listBox_hasil.TabIndex = 42;
            this.listBox_hasil.SelectedValueChanged += new System.EventHandler(this.listBox_hasil_SelectedValueChanged);
            // 
            // comboBox_playerposition
            // 
            this.comboBox_playerposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_playerposition.FormattingEnabled = true;
            this.comboBox_playerposition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBox_playerposition.Location = new System.Drawing.Point(882, 146);
            this.comboBox_playerposition.Name = "comboBox_playerposition";
            this.comboBox_playerposition.Size = new System.Drawing.Size(194, 28);
            this.comboBox_playerposition.TabIndex = 41;
            // 
            // textBox_playernumber
            // 
            this.textBox_playernumber.Location = new System.Drawing.Point(882, 106);
            this.textBox_playernumber.Name = "textBox_playernumber";
            this.textBox_playernumber.Size = new System.Drawing.Size(194, 26);
            this.textBox_playernumber.TabIndex = 40;
            // 
            // textBox_playername
            // 
            this.textBox_playername.Location = new System.Drawing.Point(882, 66);
            this.textBox_playername.Name = "textBox_playername";
            this.textBox_playername.Size = new System.Drawing.Size(194, 26);
            this.textBox_playername.TabIndex = 39;
            // 
            // textBox_teamcity
            // 
            this.textBox_teamcity.Location = new System.Drawing.Point(497, 151);
            this.textBox_teamcity.Name = "textBox_teamcity";
            this.textBox_teamcity.Size = new System.Drawing.Size(181, 26);
            this.textBox_teamcity.TabIndex = 38;
            // 
            // textBox_teamcountry
            // 
            this.textBox_teamcountry.Location = new System.Drawing.Point(497, 104);
            this.textBox_teamcountry.Name = "textBox_teamcountry";
            this.textBox_teamcountry.Size = new System.Drawing.Size(181, 26);
            this.textBox_teamcountry.TabIndex = 37;
            // 
            // textBox_teamname
            // 
            this.textBox_teamname.Location = new System.Drawing.Point(497, 66);
            this.textBox_teamname.Name = "textBox_teamname";
            this.textBox_teamname.Size = new System.Drawing.Size(181, 26);
            this.textBox_teamname.TabIndex = 36;
            // 
            // comboBox_chooseteam
            // 
            this.comboBox_chooseteam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chooseteam.FormattingEnabled = true;
            this.comboBox_chooseteam.Items.AddRange(new object[] {
            "Manchester United",
            "Totthenham Hotspur F.C",
            "Paris Saint-Germain"});
            this.comboBox_chooseteam.Location = new System.Drawing.Point(158, 104);
            this.comboBox_chooseteam.Name = "comboBox_chooseteam";
            this.comboBox_chooseteam.Size = new System.Drawing.Size(173, 28);
            this.comboBox_chooseteam.TabIndex = 35;
            this.comboBox_chooseteam.SelectedIndexChanged += new System.EventHandler(this.comboBox_chooseteam_SelectedIndexChanged_1);
            // 
            // comboBox_choosecountry
            // 
            this.comboBox_choosecountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_choosecountry.FormattingEnabled = true;
            this.comboBox_choosecountry.Items.AddRange(new object[] {
            "England",
            "France"});
            this.comboBox_choosecountry.Location = new System.Drawing.Point(158, 66);
            this.comboBox_choosecountry.Name = "comboBox_choosecountry";
            this.comboBox_choosecountry.Size = new System.Drawing.Size(173, 28);
            this.comboBox_choosecountry.TabIndex = 34;
            this.comboBox_choosecountry.SelectedIndexChanged += new System.EventHandler(this.comboBox_choosecountry_SelectedIndexChanged_2);
            // 
            // label_addingplayers
            // 
            this.label_addingplayers.AutoSize = true;
            this.label_addingplayers.Location = new System.Drawing.Point(891, 23);
            this.label_addingplayers.Name = "label_addingplayers";
            this.label_addingplayers.Size = new System.Drawing.Size(114, 20);
            this.label_addingplayers.TabIndex = 33;
            this.label_addingplayers.Text = "Adding Players";
            // 
            // label_playerposition
            // 
            this.label_playerposition.AutoSize = true;
            this.label_playerposition.Location = new System.Drawing.Point(728, 154);
            this.label_playerposition.Name = "label_playerposition";
            this.label_playerposition.Size = new System.Drawing.Size(116, 20);
            this.label_playerposition.TabIndex = 32;
            this.label_playerposition.Text = "Player Position:";
            // 
            // label_playernumber
            // 
            this.label_playernumber.AutoSize = true;
            this.label_playernumber.Location = new System.Drawing.Point(728, 112);
            this.label_playernumber.Name = "label_playernumber";
            this.label_playernumber.Size = new System.Drawing.Size(116, 20);
            this.label_playernumber.TabIndex = 31;
            this.label_playernumber.Text = "Player Number:";
            // 
            // label_playername
            // 
            this.label_playername.AutoSize = true;
            this.label_playername.Location = new System.Drawing.Point(728, 66);
            this.label_playername.Name = "label_playername";
            this.label_playername.Size = new System.Drawing.Size(102, 20);
            this.label_playername.TabIndex = 30;
            this.label_playername.Text = "Player Name:";
            // 
            // label_addingteam
            // 
            this.label_addingteam.AutoSize = true;
            this.label_addingteam.Location = new System.Drawing.Point(532, 23);
            this.label_addingteam.Name = "label_addingteam";
            this.label_addingteam.Size = new System.Drawing.Size(103, 20);
            this.label_addingteam.TabIndex = 29;
            this.label_addingteam.Text = "Adding Team";
            // 
            // label_teamcity
            // 
            this.label_teamcity.AutoSize = true;
            this.label_teamcity.Location = new System.Drawing.Point(358, 154);
            this.label_teamcity.Name = "label_teamcity";
            this.label_teamcity.Size = new System.Drawing.Size(83, 20);
            this.label_teamcity.TabIndex = 28;
            this.label_teamcity.Text = "Team City:";
            // 
            // label_teamcountry
            // 
            this.label_teamcountry.AutoSize = true;
            this.label_teamcountry.Location = new System.Drawing.Point(358, 112);
            this.label_teamcountry.Name = "label_teamcountry";
            this.label_teamcountry.Size = new System.Drawing.Size(112, 20);
            this.label_teamcountry.TabIndex = 27;
            this.label_teamcountry.Text = "Team Country:";
            // 
            // label_teamname
            // 
            this.label_teamname.AutoSize = true;
            this.label_teamname.Location = new System.Drawing.Point(358, 69);
            this.label_teamname.Name = "label_teamname";
            this.label_teamname.Size = new System.Drawing.Size(99, 20);
            this.label_teamname.TabIndex = 26;
            this.label_teamname.Text = "Team Name:";
            // 
            // label_chooseteam
            // 
            this.label_chooseteam.AutoSize = true;
            this.label_chooseteam.Location = new System.Drawing.Point(16, 112);
            this.label_chooseteam.Name = "label_chooseteam";
            this.label_chooseteam.Size = new System.Drawing.Size(112, 20);
            this.label_chooseteam.TabIndex = 25;
            this.label_chooseteam.Text = "Choose Team:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Choose Country:";
            // 
            // label_soccerlist
            // 
            this.label_soccerlist.AutoSize = true;
            this.label_soccerlist.Location = new System.Drawing.Point(16, 23);
            this.label_soccerlist.Name = "label_soccerlist";
            this.label_soccerlist.Size = new System.Drawing.Size(132, 20);
            this.label_soccerlist.TabIndex = 23;
            this.label_soccerlist.Text = "Soccer Team List";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(20, 375);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(115, 33);
            this.button_remove.TabIndex = 43;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 450);
            this.Controls.Add(this.button_add2);
            this.Controls.Add(this.button_add1);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.listBox_hasil);
            this.Controls.Add(this.comboBox_playerposition);
            this.Controls.Add(this.textBox_playernumber);
            this.Controls.Add(this.textBox_playername);
            this.Controls.Add(this.textBox_teamcity);
            this.Controls.Add(this.textBox_teamcountry);
            this.Controls.Add(this.textBox_teamname);
            this.Controls.Add(this.comboBox_chooseteam);
            this.Controls.Add(this.comboBox_choosecountry);
            this.Controls.Add(this.label_addingplayers);
            this.Controls.Add(this.label_playerposition);
            this.Controls.Add(this.label_playernumber);
            this.Controls.Add(this.label_playername);
            this.Controls.Add(this.label_addingteam);
            this.Controls.Add(this.label_teamcity);
            this.Controls.Add(this.label_teamcountry);
            this.Controls.Add(this.label_teamname);
            this.Controls.Add(this.label_chooseteam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_soccerlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add2;
        private System.Windows.Forms.Button button_add1;
        private System.Windows.Forms.ListBox listBox_hasil;
        private System.Windows.Forms.ComboBox comboBox_playerposition;
        private System.Windows.Forms.TextBox textBox_playernumber;
        private System.Windows.Forms.TextBox textBox_playername;
        private System.Windows.Forms.TextBox textBox_teamcity;
        private System.Windows.Forms.TextBox textBox_teamcountry;
        private System.Windows.Forms.TextBox textBox_teamname;
        private System.Windows.Forms.ComboBox comboBox_chooseteam;
        private System.Windows.Forms.ComboBox comboBox_choosecountry;
        private System.Windows.Forms.Label label_addingplayers;
        private System.Windows.Forms.Label label_playerposition;
        private System.Windows.Forms.Label label_playernumber;
        private System.Windows.Forms.Label label_playername;
        private System.Windows.Forms.Label label_addingteam;
        private System.Windows.Forms.Label label_teamcity;
        private System.Windows.Forms.Label label_teamcountry;
        private System.Windows.Forms.Label label_teamname;
        private System.Windows.Forms.Label label_chooseteam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_soccerlist;
        private System.Windows.Forms.Button button_remove;
    }
}


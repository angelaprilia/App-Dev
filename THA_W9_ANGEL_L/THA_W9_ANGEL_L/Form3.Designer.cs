namespace THA_W9_ANGEL_L
{
    partial class Form3
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
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.labelteam = new System.Windows.Forms.Label();
            this.labelmatch = new System.Windows.Forms.Label();
            this.comboBox_match = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_homeplayer = new System.Windows.Forms.DataGridView();
            this.dataGridView_awayplayer = new System.Windows.Forms.DataGridView();
            this.dataGridView_detail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lhomeplayer = new System.Windows.Forms.Label();
            this.lawayplayer = new System.Windows.Forms.Label();
            this.labelteam1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_homeplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_awayplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(119, 24);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(173, 28);
            this.comboBox_team.TabIndex = 0;
            this.comboBox_team.SelectedIndexChanged += new System.EventHandler(this.comboBox_team_SelectedIndexChanged);
            // 
            // labelteam
            // 
            this.labelteam.AutoSize = true;
            this.labelteam.Location = new System.Drawing.Point(22, 32);
            this.labelteam.Name = "labelteam";
            this.labelteam.Size = new System.Drawing.Size(49, 20);
            this.labelteam.TabIndex = 1;
            this.labelteam.Text = "Team";
            // 
            // labelmatch
            // 
            this.labelmatch.AutoSize = true;
            this.labelmatch.Location = new System.Drawing.Point(22, 72);
            this.labelmatch.Name = "labelmatch";
            this.labelmatch.Size = new System.Drawing.Size(53, 20);
            this.labelmatch.TabIndex = 2;
            this.labelmatch.Text = "Match";
            // 
            // comboBox_match
            // 
            this.comboBox_match.FormattingEnabled = true;
            this.comboBox_match.Location = new System.Drawing.Point(119, 64);
            this.comboBox_match.Name = "comboBox_match";
            this.comboBox_match.Size = new System.Drawing.Size(173, 28);
            this.comboBox_match.TabIndex = 3;
            this.comboBox_match.SelectedIndexChanged += new System.EventHandler(this.comboBox_match_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_homeplayer
            // 
            this.dataGridView_homeplayer.AllowUserToAddRows = false;
            this.dataGridView_homeplayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_homeplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_homeplayer.Location = new System.Drawing.Point(26, 154);
            this.dataGridView_homeplayer.Name = "dataGridView_homeplayer";
            this.dataGridView_homeplayer.RowHeadersVisible = false;
            this.dataGridView_homeplayer.RowHeadersWidth = 62;
            this.dataGridView_homeplayer.RowTemplate.Height = 28;
            this.dataGridView_homeplayer.Size = new System.Drawing.Size(515, 187);
            this.dataGridView_homeplayer.TabIndex = 5;
            // 
            // dataGridView_awayplayer
            // 
            this.dataGridView_awayplayer.AllowUserToAddRows = false;
            this.dataGridView_awayplayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_awayplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_awayplayer.Location = new System.Drawing.Point(554, 154);
            this.dataGridView_awayplayer.Name = "dataGridView_awayplayer";
            this.dataGridView_awayplayer.RowHeadersVisible = false;
            this.dataGridView_awayplayer.RowHeadersWidth = 62;
            this.dataGridView_awayplayer.RowTemplate.Height = 28;
            this.dataGridView_awayplayer.Size = new System.Drawing.Size(512, 187);
            this.dataGridView_awayplayer.TabIndex = 6;
            // 
            // dataGridView_detail
            // 
            this.dataGridView_detail.AllowUserToAddRows = false;
            this.dataGridView_detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detail.Location = new System.Drawing.Point(26, 395);
            this.dataGridView_detail.Name = "dataGridView_detail";
            this.dataGridView_detail.RowHeadersVisible = false;
            this.dataGridView_detail.RowHeadersWidth = 62;
            this.dataGridView_detail.RowTemplate.Height = 28;
            this.dataGridView_detail.Size = new System.Drawing.Size(1040, 281);
            this.dataGridView_detail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Match Details :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Home Team : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Away Team :";
            // 
            // lhomeplayer
            // 
            this.lhomeplayer.AutoSize = true;
            this.lhomeplayer.Location = new System.Drawing.Point(147, 122);
            this.lhomeplayer.Name = "lhomeplayer";
            this.lhomeplayer.Size = new System.Drawing.Size(14, 20);
            this.lhomeplayer.TabIndex = 11;
            this.lhomeplayer.Text = "-";
            // 
            // lawayplayer
            // 
            this.lawayplayer.AutoSize = true;
            this.lawayplayer.Location = new System.Drawing.Point(668, 120);
            this.lawayplayer.Name = "lawayplayer";
            this.lawayplayer.Size = new System.Drawing.Size(14, 20);
            this.lawayplayer.TabIndex = 12;
            this.lawayplayer.Text = "-";
            // 
            // labelteam1
            // 
            this.labelteam1.AutoSize = true;
            this.labelteam1.Location = new System.Drawing.Point(151, 359);
            this.labelteam1.Name = "labelteam1";
            this.labelteam1.Size = new System.Drawing.Size(14, 20);
            this.labelteam1.TabIndex = 13;
            this.labelteam1.Text = "-";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 781);
            this.Controls.Add(this.labelteam1);
            this.Controls.Add(this.lawayplayer);
            this.Controls.Add(this.lhomeplayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_detail);
            this.Controls.Add(this.dataGridView_awayplayer);
            this.Controls.Add(this.dataGridView_homeplayer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_match);
            this.Controls.Add(this.labelmatch);
            this.Controls.Add(this.labelteam);
            this.Controls.Add(this.comboBox_team);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_homeplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_awayplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.Label labelteam;
        private System.Windows.Forms.Label labelmatch;
        private System.Windows.Forms.ComboBox comboBox_match;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_homeplayer;
        private System.Windows.Forms.DataGridView dataGridView_awayplayer;
        private System.Windows.Forms.DataGridView dataGridView_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lhomeplayer;
        private System.Windows.Forms.Label lawayplayer;
        private System.Windows.Forms.Label labelteam1;
    }
}
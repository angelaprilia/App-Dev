namespace THA_W9_ANGEL_L
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.comboBox_player = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_team = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label_nationality = new System.Windows.Forms.Label();
            this.label_squadnum = new System.Windows.Forms.Label();
            this.label_yellowcard = new System.Windows.Forms.Label();
            this.label_redcard = new System.Windows.Forms.Label();
            this.label_goal = new System.Windows.Forms.Label();
            this.label_pinalty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Player :";
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(149, 6);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(188, 28);
            this.comboBox_team.TabIndex = 2;
            this.comboBox_team.SelectedIndexChanged += new System.EventHandler(this.comboBox_team_SelectedIndexChanged);
            // 
            // comboBox_player
            // 
            this.comboBox_player.FormattingEnabled = true;
            this.comboBox_player.Location = new System.Drawing.Point(149, 43);
            this.comboBox_player.Name = "comboBox_player";
            this.comboBox_player.Size = new System.Drawing.Size(188, 28);
            this.comboBox_player.TabIndex = 3;
            this.comboBox_player.SelectedIndexChanged += new System.EventHandler(this.comboBox_player_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 134);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(14, 20);
            this.label_name.TabIndex = 14;
            this.label_name.Text = "-";
            // 
            // label_team
            // 
            this.label_team.AutoSize = true;
            this.label_team.Location = new System.Drawing.Point(12, 186);
            this.label_team.Name = "label_team";
            this.label_team.Size = new System.Drawing.Size(14, 20);
            this.label_team.TabIndex = 15;
            this.label_team.Text = "-";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(12, 244);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(14, 20);
            this.label_position.TabIndex = 16;
            this.label_position.Text = "-";
            // 
            // label_nationality
            // 
            this.label_nationality.AutoSize = true;
            this.label_nationality.Location = new System.Drawing.Point(12, 299);
            this.label_nationality.Name = "label_nationality";
            this.label_nationality.Size = new System.Drawing.Size(14, 20);
            this.label_nationality.TabIndex = 17;
            this.label_nationality.Text = "-";
            // 
            // label_squadnum
            // 
            this.label_squadnum.AutoSize = true;
            this.label_squadnum.Location = new System.Drawing.Point(12, 356);
            this.label_squadnum.Name = "label_squadnum";
            this.label_squadnum.Size = new System.Drawing.Size(14, 20);
            this.label_squadnum.TabIndex = 18;
            this.label_squadnum.Text = "-";
            // 
            // label_yellowcard
            // 
            this.label_yellowcard.AutoSize = true;
            this.label_yellowcard.Location = new System.Drawing.Point(371, 134);
            this.label_yellowcard.Name = "label_yellowcard";
            this.label_yellowcard.Size = new System.Drawing.Size(14, 20);
            this.label_yellowcard.TabIndex = 19;
            this.label_yellowcard.Text = "-";
            // 
            // label_redcard
            // 
            this.label_redcard.AutoSize = true;
            this.label_redcard.Location = new System.Drawing.Point(371, 186);
            this.label_redcard.Name = "label_redcard";
            this.label_redcard.Size = new System.Drawing.Size(14, 20);
            this.label_redcard.TabIndex = 20;
            this.label_redcard.Text = "-";
            // 
            // label_goal
            // 
            this.label_goal.AutoSize = true;
            this.label_goal.Location = new System.Drawing.Point(371, 244);
            this.label_goal.Name = "label_goal";
            this.label_goal.Size = new System.Drawing.Size(14, 20);
            this.label_goal.TabIndex = 21;
            this.label_goal.Text = "-";
            // 
            // label_pinalty
            // 
            this.label_pinalty.AutoSize = true;
            this.label_pinalty.Location = new System.Drawing.Point(371, 299);
            this.label_pinalty.Name = "label_pinalty";
            this.label_pinalty.Size = new System.Drawing.Size(14, 20);
            this.label_pinalty.TabIndex = 22;
            this.label_pinalty.Text = "-";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_pinalty);
            this.Controls.Add(this.label_goal);
            this.Controls.Add(this.label_redcard);
            this.Controls.Add(this.label_yellowcard);
            this.Controls.Add(this.label_squadnum);
            this.Controls.Add(this.label_nationality);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_team);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_player);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.ComboBox comboBox_player;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_team;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_nationality;
        private System.Windows.Forms.Label label_squadnum;
        private System.Windows.Forms.Label label_yellowcard;
        private System.Windows.Forms.Label label_redcard;
        private System.Windows.Forms.Label label_goal;
        private System.Windows.Forms.Label label_pinalty;
    }
}
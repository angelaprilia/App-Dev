namespace THA_W4_ANGEL_L
{
    partial class Main_Window_Form
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
            this.button_nextform = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_favartist = new System.Windows.Forms.Label();
            this.textBox_favartist = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_nextform
            // 
            this.button_nextform.Location = new System.Drawing.Point(281, 190);
            this.button_nextform.Name = "button_nextform";
            this.button_nextform.Size = new System.Drawing.Size(146, 47);
            this.button_nextform.TabIndex = 0;
            this.button_nextform.Text = "Open Next Form";
            this.button_nextform.UseVisualStyleBackColor = true;
            this.button_nextform.Click += new System.EventHandler(this.button_nextform_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(20, 23);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(51, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(187, 20);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(240, 26);
            this.textBox_name.TabIndex = 2;
            // 
            // label_favartist
            // 
            this.label_favartist.AutoSize = true;
            this.label_favartist.Location = new System.Drawing.Point(20, 73);
            this.label_favartist.Name = "label_favartist";
            this.label_favartist.Size = new System.Drawing.Size(140, 20);
            this.label_favartist.TabIndex = 3;
            this.label_favartist.Text = "My Favourite Artist";
            // 
            // textBox_favartist
            // 
            this.textBox_favartist.Location = new System.Drawing.Point(187, 73);
            this.textBox_favartist.Name = "textBox_favartist";
            this.textBox_favartist.Size = new System.Drawing.Size(240, 26);
            this.textBox_favartist.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(289, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "All of the content I put above is true!";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(108, 190);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(101, 47);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Main_Window_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_favartist);
            this.Controls.Add(this.label_favartist);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_nextform);
            this.Name = "Main_Window_Form";
            this.Text = "Main Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nextform;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_favartist;
        private System.Windows.Forms.TextBox textBox_favartist;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button_submit;
    }
}


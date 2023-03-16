namespace THA_W3_ANGEL_L
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phonenumber = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(21, 28);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(69, 25);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name ";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(21, 96);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(48, 25);
            this.label_age.TabIndex = 1;
            this.label_age.Text = "Age";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(21, 169);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(60, 25);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email";
            // 
            // label_phonenumber
            // 
            this.label_phonenumber.AutoSize = true;
            this.label_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phonenumber.Location = new System.Drawing.Point(21, 242);
            this.label_phonenumber.Name = "label_phonenumber";
            this.label_phonenumber.Size = new System.Drawing.Size(143, 25);
            this.label_phonenumber.TabIndex = 3;
            this.label_phonenumber.Text = "Phone Number";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(231, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(373, 35);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(231, 97);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(373, 35);
            this.textBox_age.TabIndex = 5;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(231, 168);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(373, 35);
            this.textBox_email.TabIndex = 6;
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phonenumber.Location = new System.Drawing.Point(232, 232);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(372, 35);
            this.textBox_phonenumber.TabIndex = 7;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_clear.Location = new System.Drawing.Point(53, 355);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(111, 45);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_submit.Location = new System.Drawing.Point(584, 355);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(119, 45);
            this.button_submit.TabIndex = 9;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_phonenumber);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_phonenumber);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phonenumber;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_submit;
    }
}


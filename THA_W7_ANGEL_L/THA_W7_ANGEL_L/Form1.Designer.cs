namespace THA_W7_ANGEL_L
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "WORDLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set How Much You Can Guess!";
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(91, 176);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(162, 26);
            this.textBox_input.TabIndex = 2;
            this.textBox_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(113, 218);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(115, 47);
            this.button_play.TabIndex = 3;
            this.button_play.Text = "Play!";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(359, 363);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_play;
    }
}


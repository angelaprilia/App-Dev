namespace THA_W6_ANGEL_L
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_product = new System.Windows.Forms.Label();
            this.button_all = new System.Windows.Forms.Button();
            this.button_filter = new System.Windows.Forms.Button();
            this.comboBox_filter = new System.Windows.Forms.ComboBox();
            this.label_category = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nama1 = new System.Windows.Forms.TextBox();
            this.button_addcategory = new System.Windows.Forms.Button();
            this.button_removecategory = new System.Windows.Forms.Button();
            this.label_details = new System.Windows.Forms.Label();
            this.label_nama = new System.Windows.Forms.Label();
            this.label_category2 = new System.Windows.Forms.Label();
            this.label_harga = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.textBox_nama2 = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.button_addproduct = new System.Windows.Forms.Button();
            this.button_editproduct = new System.Windows.Forms.Button();
            this.button_removeproduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(12, 18);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(87, 20);
            this.label_product.TabIndex = 1;
            this.label_product.Text = "PRODUCT";
            // 
            // button_all
            // 
            this.button_all.Location = new System.Drawing.Point(217, 12);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(78, 36);
            this.button_all.TabIndex = 2;
            this.button_all.Text = "All";
            this.button_all.UseVisualStyleBackColor = true;
            this.button_all.Click += new System.EventHandler(this.button_all_Click);
            // 
            // button_filter
            // 
            this.button_filter.Location = new System.Drawing.Point(301, 12);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(85, 36);
            this.button_filter.TabIndex = 3;
            this.button_filter.Text = "Filter:";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // comboBox_filter
            // 
            this.comboBox_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter.FormattingEnabled = true;
            this.comboBox_filter.Location = new System.Drawing.Point(392, 17);
            this.comboBox_filter.Name = "comboBox_filter";
            this.comboBox_filter.Size = new System.Drawing.Size(121, 28);
            this.comboBox_filter.TabIndex = 4;
            this.comboBox_filter.SelectionChangeCommitted += new System.EventHandler(this.comboBox_filter_SelectionChangeCommitted);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(787, 28);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(99, 20);
            this.label_category.TabIndex = 5;
            this.label_category.Text = "CATEGORY";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(791, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(329, 183);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nama :";
            // 
            // textBox_nama1
            // 
            this.textBox_nama1.Location = new System.Drawing.Point(882, 263);
            this.textBox_nama1.Name = "textBox_nama1";
            this.textBox_nama1.Size = new System.Drawing.Size(238, 26);
            this.textBox_nama1.TabIndex = 8;
            // 
            // button_addcategory
            // 
            this.button_addcategory.BackColor = System.Drawing.Color.LightSalmon;
            this.button_addcategory.Location = new System.Drawing.Point(891, 307);
            this.button_addcategory.Name = "button_addcategory";
            this.button_addcategory.Size = new System.Drawing.Size(93, 61);
            this.button_addcategory.TabIndex = 9;
            this.button_addcategory.Text = "Add Category";
            this.button_addcategory.UseVisualStyleBackColor = false;
            this.button_addcategory.Click += new System.EventHandler(this.button_addcategory_Click);
            // 
            // button_removecategory
            // 
            this.button_removecategory.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_removecategory.Location = new System.Drawing.Point(1006, 307);
            this.button_removecategory.Name = "button_removecategory";
            this.button_removecategory.Size = new System.Drawing.Size(91, 61);
            this.button_removecategory.TabIndex = 10;
            this.button_removecategory.Text = "Remove Category";
            this.button_removecategory.UseVisualStyleBackColor = false;
            this.button_removecategory.Click += new System.EventHandler(this.button_removecategory_Click);
            // 
            // label_details
            // 
            this.label_details.AutoSize = true;
            this.label_details.Location = new System.Drawing.Point(20, 376);
            this.label_details.Name = "label_details";
            this.label_details.Size = new System.Drawing.Size(77, 20);
            this.label_details.TabIndex = 11;
            this.label_details.Text = "DETAILS";
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(20, 408);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(59, 20);
            this.label_nama.TabIndex = 12;
            this.label_nama.Text = "Nama :";
            // 
            // label_category2
            // 
            this.label_category2.AutoSize = true;
            this.label_category2.Location = new System.Drawing.Point(20, 444);
            this.label_category2.Name = "label_category2";
            this.label_category2.Size = new System.Drawing.Size(81, 20);
            this.label_category2.TabIndex = 13;
            this.label_category2.Text = "Category :";
            // 
            // label_harga
            // 
            this.label_harga.AutoSize = true;
            this.label_harga.Location = new System.Drawing.Point(20, 478);
            this.label_harga.Name = "label_harga";
            this.label_harga.Size = new System.Drawing.Size(61, 20);
            this.label_harga.TabIndex = 14;
            this.label_harga.Text = "Harga :";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(20, 516);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(58, 20);
            this.label_stock.TabIndex = 15;
            this.label_stock.Text = "Stock :";
            // 
            // textBox_nama2
            // 
            this.textBox_nama2.Location = new System.Drawing.Point(128, 408);
            this.textBox_nama2.Name = "textBox_nama2";
            this.textBox_nama2.Size = new System.Drawing.Size(453, 26);
            this.textBox_nama2.TabIndex = 16;
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(128, 441);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(167, 28);
            this.comboBox_category.TabIndex = 17;
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(128, 478);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(167, 26);
            this.textBox_harga.TabIndex = 18;
            this.textBox_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_harga_KeyPress);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(128, 516);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(167, 26);
            this.textBox_stock.TabIndex = 19;
            this.textBox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_stock_KeyPress);
            // 
            // button_addproduct
            // 
            this.button_addproduct.BackColor = System.Drawing.Color.LightSalmon;
            this.button_addproduct.Location = new System.Drawing.Point(311, 462);
            this.button_addproduct.Name = "button_addproduct";
            this.button_addproduct.Size = new System.Drawing.Size(85, 56);
            this.button_addproduct.TabIndex = 20;
            this.button_addproduct.Text = "Add Product";
            this.button_addproduct.UseVisualStyleBackColor = false;
            this.button_addproduct.Click += new System.EventHandler(this.button_addproduct_Click);
            // 
            // button_editproduct
            // 
            this.button_editproduct.BackColor = System.Drawing.Color.Gold;
            this.button_editproduct.Location = new System.Drawing.Point(402, 462);
            this.button_editproduct.Name = "button_editproduct";
            this.button_editproduct.Size = new System.Drawing.Size(88, 56);
            this.button_editproduct.TabIndex = 21;
            this.button_editproduct.Text = "Edit Product";
            this.button_editproduct.UseVisualStyleBackColor = false;
            this.button_editproduct.Click += new System.EventHandler(this.button_editproduct_Click);
            // 
            // button_removeproduct
            // 
            this.button_removeproduct.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_removeproduct.Location = new System.Drawing.Point(496, 462);
            this.button_removeproduct.Name = "button_removeproduct";
            this.button_removeproduct.Size = new System.Drawing.Size(85, 56);
            this.button_removeproduct.TabIndex = 22;
            this.button_removeproduct.Text = "Remove Product";
            this.button_removeproduct.UseVisualStyleBackColor = false;
            this.button_removeproduct.Click += new System.EventHandler(this.button_removeproduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(917, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1237, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_removeproduct);
            this.Controls.Add(this.button_editproduct);
            this.Controls.Add(this.button_addproduct);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.textBox_harga);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_nama2);
            this.Controls.Add(this.label_stock);
            this.Controls.Add(this.label_harga);
            this.Controls.Add(this.label_category2);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.label_details);
            this.Controls.Add(this.button_removecategory);
            this.Controls.Add(this.button_addcategory);
            this.Controls.Add(this.textBox_nama1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.comboBox_filter);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_all);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Button button_all;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox comboBox_filter;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nama1;
        private System.Windows.Forms.Button button_addcategory;
        private System.Windows.Forms.Button button_removecategory;
        private System.Windows.Forms.Label label_details;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.Label label_category2;
        private System.Windows.Forms.Label label_harga;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.TextBox textBox_nama2;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Button button_addproduct;
        private System.Windows.Forms.Button button_editproduct;
        private System.Windows.Forms.Button button_removeproduct;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


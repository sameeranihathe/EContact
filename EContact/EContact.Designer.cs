namespace EContact
{
    partial class EContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EContact));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbl_contact_id = new System.Windows.Forms.Label();
            this.txt_box_contact_id = new System.Windows.Forms.TextBox();
            this.txt_box_last_name = new System.Windows.Forms.TextBox();
            this.lbl_last_name = new System.Windows.Forms.Label();
            this.txt_box_first_name = new System.Windows.Forms.TextBox();
            this.lbl_first_name = new System.Windows.Forms.Label();
            this.txt_box_contact_no = new System.Windows.Forms.TextBox();
            this.lbl_contact_no = new System.Windows.Forms.Label();
            this.txt_box_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_gendar = new System.Windows.Forms.Label();
            this.cmb_box_gendar = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_box_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(454, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(203, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_contact_id
            // 
            this.lbl_contact_id.AutoSize = true;
            this.lbl_contact_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact_id.Location = new System.Drawing.Point(38, 104);
            this.lbl_contact_id.Name = "lbl_contact_id";
            this.lbl_contact_id.Size = new System.Drawing.Size(104, 25);
            this.lbl_contact_id.TabIndex = 1;
            this.lbl_contact_id.Text = "Contact ID";
            this.lbl_contact_id.Click += new System.EventHandler(this.lbl_contact_id_Click);
            // 
            // txt_box_contact_id
            // 
            this.txt_box_contact_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_contact_id.Location = new System.Drawing.Point(181, 101);
            this.txt_box_contact_id.Name = "txt_box_contact_id";
            this.txt_box_contact_id.ReadOnly = true;
            this.txt_box_contact_id.Size = new System.Drawing.Size(218, 30);
            this.txt_box_contact_id.TabIndex = 2;
            // 
            // txt_box_last_name
            // 
            this.txt_box_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_last_name.Location = new System.Drawing.Point(181, 234);
            this.txt_box_last_name.Name = "txt_box_last_name";
            this.txt_box_last_name.Size = new System.Drawing.Size(218, 30);
            this.txt_box_last_name.TabIndex = 8;
            // 
            // lbl_last_name
            // 
            this.lbl_last_name.AutoSize = true;
            this.lbl_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last_name.Location = new System.Drawing.Point(38, 234);
            this.lbl_last_name.Name = "lbl_last_name";
            this.lbl_last_name.Size = new System.Drawing.Size(106, 25);
            this.lbl_last_name.TabIndex = 7;
            this.lbl_last_name.Text = "Last Name";
            // 
            // txt_box_first_name
            // 
            this.txt_box_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_first_name.Location = new System.Drawing.Point(181, 166);
            this.txt_box_first_name.Name = "txt_box_first_name";
            this.txt_box_first_name.Size = new System.Drawing.Size(218, 30);
            this.txt_box_first_name.TabIndex = 10;
            // 
            // lbl_first_name
            // 
            this.lbl_first_name.AutoSize = true;
            this.lbl_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first_name.Location = new System.Drawing.Point(38, 169);
            this.lbl_first_name.Name = "lbl_first_name";
            this.lbl_first_name.Size = new System.Drawing.Size(106, 25);
            this.lbl_first_name.TabIndex = 9;
            this.lbl_first_name.Text = "First Name";
            // 
            // txt_box_contact_no
            // 
            this.txt_box_contact_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_contact_no.Location = new System.Drawing.Point(181, 301);
            this.txt_box_contact_no.Name = "txt_box_contact_no";
            this.txt_box_contact_no.Size = new System.Drawing.Size(218, 30);
            this.txt_box_contact_no.TabIndex = 12;
            // 
            // lbl_contact_no
            // 
            this.lbl_contact_no.AutoSize = true;
            this.lbl_contact_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact_no.Location = new System.Drawing.Point(38, 304);
            this.lbl_contact_no.Name = "lbl_contact_no";
            this.lbl_contact_no.Size = new System.Drawing.Size(110, 25);
            this.lbl_contact_no.TabIndex = 11;
            this.lbl_contact_no.Text = "Contact No";
            // 
            // txt_box_address
            // 
            this.txt_box_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_address.Location = new System.Drawing.Point(181, 363);
            this.txt_box_address.Multiline = true;
            this.txt_box_address.Name = "txt_box_address";
            this.txt_box_address.Size = new System.Drawing.Size(218, 102);
            this.txt_box_address.TabIndex = 14;
            this.txt_box_address.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(38, 366);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(85, 25);
            this.lbl_address.TabIndex = 13;
            this.lbl_address.Text = "Address";
            this.lbl_address.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_gendar
            // 
            this.lbl_gendar.AutoSize = true;
            this.lbl_gendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gendar.Location = new System.Drawing.Point(38, 511);
            this.lbl_gendar.Name = "lbl_gendar";
            this.lbl_gendar.Size = new System.Drawing.Size(77, 25);
            this.lbl_gendar.TabIndex = 15;
            this.lbl_gendar.Text = "Gendar";
            this.lbl_gendar.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmb_box_gendar
            // 
            this.cmb_box_gendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_box_gendar.FormattingEnabled = true;
            this.cmb_box_gendar.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_box_gendar.Location = new System.Drawing.Point(181, 512);
            this.cmb_box_gendar.Name = "cmb_box_gendar";
            this.cmb_box_gendar.Size = new System.Drawing.Size(218, 33);
            this.cmb_box_gendar.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(181, 581);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 33);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(521, 581);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 33);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Blue;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(355, 581);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(120, 33);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.DimGray;
            this.btn_clear.Location = new System.Drawing.Point(688, 581);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 33);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(441, 169);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(680, 376);
            this.dataGridView.TabIndex = 21;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_RowHeaderMouseClick);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(436, 104);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(75, 25);
            this.lbl_search.TabIndex = 22;
            this.lbl_search.Text = "Search";
            // 
            // txt_box_search
            // 
            this.txt_box_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_box_search.Location = new System.Drawing.Point(557, 99);
            this.txt_box_search.Name = "txt_box_search";
            this.txt_box_search.Size = new System.Drawing.Size(293, 30);
            this.txt_box_search.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // EContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1191, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_box_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_box_gendar);
            this.Controls.Add(this.lbl_gendar);
            this.Controls.Add(this.txt_box_address);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_box_contact_no);
            this.Controls.Add(this.lbl_contact_no);
            this.Controls.Add(this.txt_box_first_name);
            this.Controls.Add(this.lbl_first_name);
            this.Controls.Add(this.txt_box_last_name);
            this.Controls.Add(this.lbl_last_name);
            this.Controls.Add(this.txt_box_contact_id);
            this.Controls.Add(this.lbl_contact_id);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EContact";
            this.Text = "EContact";
            this.Load += new System.EventHandler(this.EContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lbl_contact_id;
        private System.Windows.Forms.TextBox txt_box_contact_id;
        private System.Windows.Forms.TextBox txt_box_last_name;
        private System.Windows.Forms.Label lbl_last_name;
        private System.Windows.Forms.TextBox txt_box_first_name;
        private System.Windows.Forms.Label lbl_first_name;
        private System.Windows.Forms.TextBox txt_box_contact_no;
        private System.Windows.Forms.Label lbl_contact_no;
        private System.Windows.Forms.TextBox txt_box_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_gendar;
        private System.Windows.Forms.ComboBox cmb_box_gendar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox txt_box_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



namespace cobacrud
{
    partial class sidebg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sidebg));
            this.label1 = new System.Windows.Forms.Label();
            this.tampil = new System.Windows.Forms.DataGridView();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_guru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.restore = new System.Windows.Forms.Button();
            this.jumlah = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.side = new System.Windows.Forms.Panel();
            this.topbg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.side.SuspendLayout();
            this.topbg.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(232, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Guru";
            // 
            // tampil
            // 
            this.tampil.AllowUserToAddRows = false;
            this.tampil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tampil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nip,
            this.nama_guru,
            this.jenis_kelamin,
            this.ttl,
            this.mapel,
            this.gaji});
            this.tampil.Location = new System.Drawing.Point(240, 211);
            this.tampil.Name = "tampil";
            this.tampil.ReadOnly = true;
            this.tampil.RowHeadersVisible = false;
            this.tampil.Size = new System.Drawing.Size(759, 265);
            this.tampil.TabIndex = 1;
            this.tampil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tampil_CellContentClick);
            // 
            // nip
            // 
            this.nip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nip.DataPropertyName = "nip";
            this.nip.HeaderText = "NIP";
            this.nip.Name = "nip";
            this.nip.ReadOnly = true;
            this.nip.Width = 56;
            // 
            // nama_guru
            // 
            this.nama_guru.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nama_guru.DataPropertyName = "nama_guru";
            this.nama_guru.HeaderText = "Nama guru";
            this.nama_guru.Name = "nama_guru";
            this.nama_guru.ReadOnly = true;
            this.nama_guru.Width = 107;
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.jenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.jenis_kelamin.HeaderText = "Jenis kelamin";
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.ReadOnly = true;
            this.jenis_kelamin.Width = 123;
            // 
            // ttl
            // 
            this.ttl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ttl.DataPropertyName = "ttl";
            this.ttl.HeaderText = "Tanggal lahir";
            this.ttl.Name = "ttl";
            this.ttl.ReadOnly = true;
            this.ttl.Width = 123;
            // 
            // mapel
            // 
            this.mapel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mapel.DataPropertyName = "mapel";
            this.mapel.HeaderText = "Mapel";
            this.mapel.Name = "mapel";
            this.mapel.ReadOnly = true;
            this.mapel.Width = 79;
            // 
            // gaji
            // 
            this.gaji.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gaji.DataPropertyName = "gaji";
            this.gaji.HeaderText = "Gaji";
            this.gaji.Name = "gaji";
            this.gaji.ReadOnly = true;
            this.gaji.Width = 62;
            // 
            // refresh
            // 
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(694, 16);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(35, 30);
            this.refresh.TabIndex = 2;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // create
            // 
            this.create.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Image = ((System.Drawing.Image)(resources.GetObject("create.Image")));
            this.create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.create.Location = new System.Drawing.Point(0, 64);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(200, 55);
            this.create.TabIndex = 3;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // restore
            // 
            this.restore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.restore.FlatAppearance.BorderSize = 0;
            this.restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restore.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restore.Image = ((System.Drawing.Image)(resources.GetObject("restore.Image")));
            this.restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.restore.Location = new System.Drawing.Point(0, 9);
            this.restore.Name = "restore";
            this.restore.Size = new System.Drawing.Size(200, 55);
            this.restore.TabIndex = 5;
            this.restore.Text = "restore";
            this.restore.UseVisualStyleBackColor = true;
            this.restore.Click += new System.EventHandler(this.restore_Click);
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(359, 92);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(18, 17);
            this.jumlah.TabIndex = 6;
            this.jumlah.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jumlah data : ";
            // 
            // searchtext
            // 
            this.searchtext.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(13, 16);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(627, 30);
            this.searchtext.TabIndex = 8;
            // 
            // search
            // 
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(658, 16);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(30, 30);
            this.search.TabIndex = 9;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(867, 520);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(39, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(912, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(934, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.restore);
            this.panel2.Controls.Add(this.create);
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 119);
            this.panel2.TabIndex = 15;
            // 
            // side
            // 
            this.side.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.side.Controls.Add(this.pictureBox1);
            this.side.Controls.Add(this.panel1);
            this.side.Controls.Add(this.panel2);
            this.side.Location = new System.Drawing.Point(0, 0);
            this.side.Name = "side";
            this.side.Size = new System.Drawing.Size(200, 555);
            this.side.TabIndex = 13;
            this.side.Paint += new System.Windows.Forms.PaintEventHandler(this.side_Paint);
            // 
            // topbg
            // 
            this.topbg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.topbg.Controls.Add(this.search);
            this.topbg.Controls.Add(this.refresh);
            this.topbg.Controls.Add(this.searchtext);
            this.topbg.Location = new System.Drawing.Point(240, 137);
            this.topbg.Name = "topbg";
            this.topbg.Size = new System.Drawing.Size(759, 58);
            this.topbg.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 67);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Userr 1234";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(977, -13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 56);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(833, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // sidebg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 555);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topbg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.side);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jumlah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tampil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sidebg";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tampil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.side.ResumeLayout(false);
            this.topbg.ResumeLayout(false);
            this.topbg.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tampil;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button restore;
        private System.Windows.Forms.Label jumlah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_guru;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapel;
        private System.Windows.Forms.DataGridViewTextBoxColumn gaji;
        private System.Windows.Forms.TextBox searchtext;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel side;
        private System.Windows.Forms.Panel topbg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}


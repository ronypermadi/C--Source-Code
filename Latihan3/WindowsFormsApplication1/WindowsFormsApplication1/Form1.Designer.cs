﻿namespace WindowsFormsApplication1
{
    partial class frmSederhana
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNohp = new System.Windows.Forms.TextBox();
            this.richtxtAlamat = new System.Windows.Forms.RichTextBox();
            this.rdbPerempuan = new System.Windows.Forms.RadioButton();
            this.rdbLakiLaki = new System.Windows.Forms.RadioButton();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.cmbProdi = new System.Windows.Forms.ComboBox();
            this.cmbProgramStudi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCetakKrs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lsbMatkul2 = new System.Windows.Forms.ListBox();
            this.lsbMatkul1 = new System.Windows.Forms.ListBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNohp);
            this.groupBox1.Controls.Add(this.richtxtAlamat);
            this.groupBox1.Controls.Add(this.rdbPerempuan);
            this.groupBox1.Controls.Add(this.rdbLakiLaki);
            this.groupBox1.Controls.Add(this.txtNim);
            this.groupBox1.Controls.Add(this.cmbProdi);
            this.groupBox1.Controls.Add(this.cmbProgramStudi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 300);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Biodata ( Wajib Diisi )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "No Hp";
            // 
            // txtNohp
            // 
            this.txtNohp.Location = new System.Drawing.Point(94, 255);
            this.txtNohp.Name = "txtNohp";
            this.txtNohp.Size = new System.Drawing.Size(172, 20);
            this.txtNohp.TabIndex = 27;
            // 
            // richtxtAlamat
            // 
            this.richtxtAlamat.Location = new System.Drawing.Point(94, 184);
            this.richtxtAlamat.Name = "richtxtAlamat";
            this.richtxtAlamat.Size = new System.Drawing.Size(172, 56);
            this.richtxtAlamat.TabIndex = 26;
            this.richtxtAlamat.Text = "";
            // 
            // rdbPerempuan
            // 
            this.rdbPerempuan.AutoSize = true;
            this.rdbPerempuan.Location = new System.Drawing.Point(181, 146);
            this.rdbPerempuan.Name = "rdbPerempuan";
            this.rdbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdbPerempuan.TabIndex = 25;
            this.rdbPerempuan.Text = "Perempuan";
            this.rdbPerempuan.UseVisualStyleBackColor = true;
            // 
            // rdbLakiLaki
            // 
            this.rdbLakiLaki.AutoSize = true;
            this.rdbLakiLaki.Checked = true;
            this.rdbLakiLaki.Location = new System.Drawing.Point(94, 146);
            this.rdbLakiLaki.Name = "rdbLakiLaki";
            this.rdbLakiLaki.Size = new System.Drawing.Size(74, 17);
            this.rdbLakiLaki.TabIndex = 24;
            this.rdbLakiLaki.TabStop = true;
            this.rdbLakiLaki.Text = "Laki - Laki";
            this.rdbLakiLaki.UseVisualStyleBackColor = true;
            // 
            // txtNim
            // 
            this.txtNim.Location = new System.Drawing.Point(94, 48);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(172, 20);
            this.txtNim.TabIndex = 23;
            // 
            // cmbProdi
            // 
            this.cmbProdi.FormattingEnabled = true;
            this.cmbProdi.Items.AddRange(new object[] {
            "Informatika"});
            this.cmbProdi.Location = new System.Drawing.Point(94, 111);
            this.cmbProdi.Name = "cmbProdi";
            this.cmbProdi.Size = new System.Drawing.Size(172, 21);
            this.cmbProdi.TabIndex = 22;
            // 
            // cmbProgramStudi
            // 
            this.cmbProgramStudi.FormattingEnabled = true;
            this.cmbProgramStudi.Items.AddRange(new object[] {
            "S1"});
            this.cmbProgramStudi.Location = new System.Drawing.Point(94, 79);
            this.cmbProgramStudi.Name = "cmbProgramStudi";
            this.cmbProgramStudi.Size = new System.Drawing.Size(172, 21);
            this.cmbProgramStudi.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Alamat";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(94, 16);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(172, 20);
            this.txtNama.TabIndex = 19;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Program Studi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "NIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama";
            // 
            // btnCetakKrs
            // 
            this.btnCetakKrs.Location = new System.Drawing.Point(295, 294);
            this.btnCetakKrs.Name = "btnCetakKrs";
            this.btnCetakKrs.Size = new System.Drawing.Size(75, 23);
            this.btnCetakKrs.TabIndex = 27;
            this.btnCetakKrs.Text = "Cetak KRS";
            this.btnCetakKrs.UseVisualStyleBackColor = true;
            this.btnCetakKrs.Click += new System.EventHandler(this.btnCetakKrs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lsbMatkul2);
            this.groupBox2.Controls.Add(this.lsbMatkul1);
            this.groupBox2.Location = new System.Drawing.Point(289, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 271);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daftar Mata Kuliah";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(251, 243);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(26, 23);
            this.btnHapus.TabIndex = 25;
            this.btnHapus.Text = "<";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(61, 243);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(30, 23);
            this.btnTambah.TabIndex = 24;
            this.btnTambah.Text = ">";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mata Kuliah Dipilih";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mata Kuliah Wajib";
            // 
            // lsbMatkul2
            // 
            this.lsbMatkul2.FormattingEnabled = true;
            this.lsbMatkul2.Location = new System.Drawing.Point(186, 48);
            this.lsbMatkul2.Name = "lsbMatkul2";
            this.lsbMatkul2.Size = new System.Drawing.Size(162, 186);
            this.lsbMatkul2.TabIndex = 21;
            // 
            // lsbMatkul1
            // 
            this.lsbMatkul1.FormattingEnabled = true;
            this.lsbMatkul1.Items.AddRange(new object[] {
            "Algoritma dan Pemrograman",
            "Kalkulus",
            "Logika Informatika",
            "Manajemen Umum",
            "Pendidikan Agama",
            "Pendidikan Kewarganegaraan",
            "Etika Profesi",
            "Aljabar Linear",
            "Pengantar Ilmu Komputer"});
            this.lsbMatkul1.Location = new System.Drawing.Point(6, 48);
            this.lsbMatkul1.Name = "lsbMatkul1";
            this.lsbMatkul1.Size = new System.Drawing.Size(155, 186);
            this.lsbMatkul1.TabIndex = 20;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(560, 294);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 30;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // frmSederhana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(647, 344);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCetakKrs);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSederhana";
            this.Text = "Sistem KRS Mahasiswa Baru Sederhana";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNohp;
        private System.Windows.Forms.RichTextBox richtxtAlamat;
        private System.Windows.Forms.RadioButton rdbPerempuan;
        private System.Windows.Forms.RadioButton rdbLakiLaki;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.ComboBox cmbProdi;
        private System.Windows.Forms.ComboBox cmbProgramStudi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCetakKrs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lsbMatkul2;
        private System.Windows.Forms.ListBox lsbMatkul1;
        private System.Windows.Forms.Button btnKeluar;
    }
}


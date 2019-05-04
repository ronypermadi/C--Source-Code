namespace WindowsFormsApplication1
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.radioLakiLaki = new System.Windows.Forms.RadioButton();
            this.radioPerempuan = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(98, 26);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(212, 20);
            this.txtNama.TabIndex = 0;
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(26, 33);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(29, 116);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(132, 116);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(234, 116);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 4;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // radioLakiLaki
            // 
            this.radioLakiLaki.AutoSize = true;
            this.radioLakiLaki.Location = new System.Drawing.Point(98, 70);
            this.radioLakiLaki.Name = "radioLakiLaki";
            this.radioLakiLaki.Size = new System.Drawing.Size(74, 17);
            this.radioLakiLaki.TabIndex = 5;
            this.radioLakiLaki.TabStop = true;
            this.radioLakiLaki.Text = "Laki - Laki";
            this.radioLakiLaki.UseVisualStyleBackColor = true;
            // 
            // radioPerempuan
            // 
            this.radioPerempuan.AutoSize = true;
            this.radioPerempuan.Location = new System.Drawing.Point(203, 70);
            this.radioPerempuan.Name = "radioPerempuan";
            this.radioPerempuan.Size = new System.Drawing.Size(79, 17);
            this.radioPerempuan.TabIndex = 6;
            this.radioPerempuan.TabStop = true;
            this.radioPerempuan.Text = "Perempuan";
            this.radioPerempuan.UseVisualStyleBackColor = true;
            // 
            // frmSederhana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 180);
            this.Controls.Add(this.radioPerempuan);
            this.Controls.Add(this.radioLakiLaki);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.txtNama);
            this.Name = "frmSederhana";
            this.Text = "Form Sederhana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.RadioButton radioLakiLaki;
        private System.Windows.Forms.RadioButton radioPerempuan;
    }
}


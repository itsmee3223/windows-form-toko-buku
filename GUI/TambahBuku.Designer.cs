namespace Toko_Buku.GUI
{
    partial class TambahBuku
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaBuku = new System.Windows.Forms.TextBox();
            this.txtKodeBuku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPenulis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPenerbit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTerbit = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 81);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Buku";
            // 
            // txtNamaBuku
            // 
            this.txtNamaBuku.Location = new System.Drawing.Point(106, 113);
            this.txtNamaBuku.Name = "txtNamaBuku";
            this.txtNamaBuku.Size = new System.Drawing.Size(136, 20);
            this.txtNamaBuku.TabIndex = 3;
            // 
            // txtKodeBuku
            // 
            this.txtKodeBuku.Location = new System.Drawing.Point(106, 149);
            this.txtKodeBuku.Name = "txtKodeBuku";
            this.txtKodeBuku.Size = new System.Drawing.Size(136, 20);
            this.txtKodeBuku.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kode Buku";
            // 
            // txtNamaPenulis
            // 
            this.txtNamaPenulis.Location = new System.Drawing.Point(106, 187);
            this.txtNamaPenulis.Name = "txtNamaPenulis";
            this.txtNamaPenulis.Size = new System.Drawing.Size(136, 20);
            this.txtNamaPenulis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Penulis";
            // 
            // txtNamaPenerbit
            // 
            this.txtNamaPenerbit.Location = new System.Drawing.Point(347, 116);
            this.txtNamaPenerbit.Name = "txtNamaPenerbit";
            this.txtNamaPenerbit.Size = new System.Drawing.Size(100, 20);
            this.txtNamaPenerbit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nama Penerbit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tanggal terbit";
            // 
            // dtTerbit
            // 
            this.dtTerbit.Location = new System.Drawing.Point(347, 187);
            this.dtTerbit.Name = "dtTerbit";
            this.dtTerbit.Size = new System.Drawing.Size(161, 20);
            this.dtTerbit.TabIndex = 11;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTambah.Location = new System.Drawing.Point(106, 227);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(87, 34);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = " Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(347, 152);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Harga Buku";
            // 
            // TambahBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 273);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dtTerbit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamaPenerbit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamaPenulis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKodeBuku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamaBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "TambahBuku";
            this.Text = "TambahBuku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaBuku;
        private System.Windows.Forms.TextBox txtKodeBuku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPenulis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaPenerbit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTerbit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label7;
    }
}
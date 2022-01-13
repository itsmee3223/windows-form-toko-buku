
namespace Toko_Buku.GUI
{
    partial class EditBuku
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtTerbit = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNamaPenerbit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamaPenulis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaBuku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
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
            this.panel1.Size = new System.Drawing.Size(300, 81);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Buku";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(42, 248);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 34);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtTerbit
            // 
            this.dtTerbit.Location = new System.Drawing.Point(111, 207);
            this.dtTerbit.Name = "dtTerbit";
            this.dtTerbit.Size = new System.Drawing.Size(161, 20);
            this.dtTerbit.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tanggal terbit";
            // 
            // txtNamaPenerbit
            // 
            this.txtNamaPenerbit.Location = new System.Drawing.Point(111, 155);
            this.txtNamaPenerbit.Name = "txtNamaPenerbit";
            this.txtNamaPenerbit.Size = new System.Drawing.Size(100, 20);
            this.txtNamaPenerbit.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nama Penerbit";
            // 
            // txtNamaPenulis
            // 
            this.txtNamaPenulis.Location = new System.Drawing.Point(111, 129);
            this.txtNamaPenulis.Name = "txtNamaPenulis";
            this.txtNamaPenulis.Size = new System.Drawing.Size(136, 20);
            this.txtNamaPenulis.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nama Penulis";
            // 
            // txtNamaBuku
            // 
            this.txtNamaBuku.Location = new System.Drawing.Point(111, 103);
            this.txtNamaBuku.Name = "txtNamaBuku";
            this.txtNamaBuku.Size = new System.Drawing.Size(136, 20);
            this.txtNamaBuku.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nama Buku";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBatal.Location = new System.Drawing.Point(170, 248);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(87, 34);
            this.btnBatal.TabIndex = 25;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(111, 181);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Harga Buku";
            // 
            // EditBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 309);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtTerbit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNamaPenerbit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamaPenulis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaBuku);
            this.Controls.Add(this.label2);
            this.Name = "EditBuku";
            this.Text = "EditBuku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dtTerbit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNamaPenerbit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaPenulis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamaBuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label7;
    }
}
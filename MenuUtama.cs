using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Buku
{
    public partial class MenuUtama : Form
    {
        public string kodeBuku;
        public MenuUtama()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            Kelas.Koneksi.DisplayAndSearch("SELECT * FROM tbl_buku", grdBuku);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            GUI.TambahBuku tambah = new GUI.TambahBuku();
            tambah.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void grdBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                kodeBuku = grdBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
                GUI.EditBuku editMovie = new GUI.EditBuku(kodeBuku, this);
                editMovie.ShowDialog();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure want to delete!!!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Kelas.Koneksi.DeleteBuku(grdBuku.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Kelas.Koneksi.DisplayAndSearch("SELECT * FROM tbl_buku WHERE nama_buku LIKE '%" + textBox1.Text + "%'", grdBuku);
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void beliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.MenuBeli menuBeli = new GUI.MenuBeli();
            this.SetVisibleCore(false);
            menuBeli.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void detailTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.MenuTransaksi menuTransaksi = new GUI.MenuTransaksi();
            this.SetVisibleCore(false);
            menuTransaksi.Show();
        }
    }
}

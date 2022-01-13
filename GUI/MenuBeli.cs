using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Toko_Buku.GUI
{
    public partial class MenuBeli : Form
    {
        string kodeBuku = "";
        
        public void Clear()
        {
            txtKodeBuku.Text = comboBox1.Text = txtKodeTransaksi.Text = txtNamaPembeli.Text = txtJumlah.Text = string.Empty;
            txtKodeTransaksi.ReadOnly = false;
        }
        public void getBuku()
        {

            using (MySqlConnection con = Kelas.Koneksi.getConn())
            {
                con.Open();
                var query = "SELECT nama_buku FROM tbl_buku";
                using (var command = new MySqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("nama_buku"));
                        }
                    }
                }
            }

        }
        public MenuBeli()
        {
            InitializeComponent();
            Display();
            getBuku();
            txtKodeBuku.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void Display()
        {
            Kelas.Koneksi.DisplayAndSearch("SELECT tbl_pembeli.kode_transaksi, tbl_pembeli.nama_pembeli, tbl_buku.nama_buku, tbl_buku.Harga, tbl_pembeli.jumlah, tbl_buku.kode_buku FROM tbl_pembeli INNER JOIN tbl_buku ON tbl_pembeli.kode_buku = tbl_buku.kode_buku; ", grdBuku);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Kelas.Koneksi.DisplayAndSearch("SELECT tbl_pembeli.kode_transaksi, tbl_pembeli.nama_pembeli, tbl_buku.nama_buku, tbl_buku.Harga, tbl_pembeli.jumlah, tbl_buku.kode_buku FROM tbl_pembeli INNER JOIN tbl_buku ON tbl_pembeli.kode_buku = tbl_buku.kode_buku WHERE tbl_pembeli.nama_pembeli LIKE '%" + textBox1.Text + "%'", grdBuku);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }


        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            this.SetVisibleCore(false);
            menuUtama.Show();
        }


        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void detailTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuTransaksi menuDetail = new MenuTransaksi();
            this.Hide();
            menuDetail.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kelas.Pembeli pembeli = new Kelas.Pembeli(txtKodeBuku.Text, txtKodeTransaksi.Text.Trim(), txtNamaPembeli.Text.Trim(), Int32.Parse(txtJumlah.Text));
            Kelas.Koneksi.tambahPembeli(pembeli);
            Display();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string sql = "SELECT kode_buku FROM tbl_buku WHERE nama_buku = @idddd;";

            MySqlConnection con = Kelas.Koneksi.getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idddd", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            try
            {
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtKodeBuku.Text = reader.GetString("kode_buku");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void grdBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = grdBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtKodeTransaksi.Text = grdBuku.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaPembeli.Text = grdBuku.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtKodeBuku.Text = grdBuku.Rows[e.RowIndex].Cells[5].Value.ToString();
            kodeBuku = grdBuku.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtJumlah.Text = grdBuku.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtKodeTransaksi.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kelas.Pembeli ubah = new Kelas.Pembeli(txtKodeBuku.Text, txtKodeTransaksi.Text, txtNamaPembeli.Text, Int32.Parse(txtJumlah.Text));
            Kelas.Koneksi.ubahPembeli(ubah, kodeBuku);
            Display();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Kelas.Koneksi.DeletePembeli(txtKodeBuku.Text, txtKodeTransaksi.Text);
            Display();
        }
    }
}

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
    public partial class MenuTransaksi : Form
    {
        public void getPembeli()
        {
            using (MySqlConnection con = Kelas.Koneksi.getConn())
            {
                con.Open();
                var query = "SELECT kode_transaksi FROM tbl_pembeli GROUP BY kode_transaksi";
                using (var command = new MySqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString("kode_transaksi"));
                        }
                    }
                }
            }
        }

        public void Clear()
        {
            comboBox1.Text = txtNamaPembeli.Text = txtTelpon.Text = txtAlamat.Text = string.Empty;
        }

        public MenuTransaksi()
        {
            InitializeComponent();
            Display();
            getPembeli();
            txtNamaPembeli.ReadOnly = true;
        }
        public void Display()
        {
            Kelas.Koneksi.DisplayAndSearch("SELECT tbl_pembeli.kode_transaksi, tbl_pembeli.nama_pembeli, tbl_detailtransaksi.telpon, tbl_detailtransaksi.alamat, tbl_detailtransaksi.tanggal_dibayar, SUM(tbl_buku.`Harga` * tbl_pembeli.jumlah) AS total_harga FROM tbl_pembeli INNER JOIN tbl_buku ON tbl_pembeli.kode_buku = tbl_buku.kode_buku INNER JOIN tbl_detailtransaksi ON tbl_pembeli.`kode_transaksi` = tbl_detailtransaksi.kode_transaksi GROUP BY `tbl_detailtransaksi`.`kode_transaksi`;", grdBuku);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Kelas.Koneksi.DisplayAndSearch("SELECT tbl_pembeli.kode_transaksi, tbl_pembeli.nama_pembeli, tbl_detailtransaksi.telpon, tbl_detailtransaksi.alamat, tbl_detailtransaksi.tanggal_dibayar, SUM(tbl_buku.`Harga` * tbl_pembeli.jumlah) AS total_harga  FROM tbl_pembeli INNER JOIN tbl_buku ON tbl_pembeli.kode_buku = tbl_buku.kode_buku INNER JOIN tbl_detailtransaksi ON tbl_pembeli.`kode_transaksi` = tbl_detailtransaksi.kode_transaksi WHERE tbl_pembeli.nama_pembeli LIKE '%" + textBox1.Text + "%'" + "GROUP BY tbl_detailtransaksi.kode_transaksi", grdBuku);
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            this.SetVisibleCore(false);
            menuUtama.Show();
        }

        private void beliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBeli menuBeli = new MenuBeli();
            this.Hide();
            menuBeli.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string sql = "SELECT nama_pembeli FROM tbl_pembeli WHERE kode_transaksi = @idddd;";

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
                    txtNamaPembeli.Text = reader.GetString("nama_pembeli");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtBayar.CustomFormat = "yyyy/dd/MM";
            Kelas.DetailTransaksi transaksi = new Kelas.DetailTransaksi(comboBox1.Text.Trim(), txtTelpon.Text.Trim(), txtAlamat.Text.Trim(), dtBayar.Value.Date);
            Kelas.Koneksi.tambahTransaksi(transaksi);
            Display();
        }

        private void grdBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = grdBuku.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaPembeli.Text = grdBuku.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelpon.Text = grdBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAlamat.Text = grdBuku.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kelas.DetailTransaksi pmb = new Kelas.DetailTransaksi(comboBox1.Text.Trim(), txtTelpon.Text.Trim(), txtAlamat.Text.Trim(), dtBayar.Value.Date);
            Kelas.Koneksi.ubahTransaksi(pmb);
            Display();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Kelas.Koneksi.DeleteTransaksi(comboBox1.Text);
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

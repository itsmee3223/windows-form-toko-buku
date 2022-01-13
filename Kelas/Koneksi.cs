using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Toko_Buku.Kelas
{
    class Koneksi
    {

        public static MySqlConnection getConn()
        {
            string host = "localhost";
            string user = "root";
            string password = "";
            string database = "tokobuku";
            string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = getConn();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void AddBuku(Buku buku)
        {
            string sql = "INSERT INTO tbl_buku values(@kode_buku, @penulis, @penerbit, @nama_buku, @tanggal, @harga)";
            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kode_buku", MySqlDbType.VarChar).Value = buku.Kode_buku;
            cmd.Parameters.Add("@penulis", MySqlDbType.VarChar).Value = buku.Penulis;
            cmd.Parameters.Add("@penerbit", MySqlDbType.VarChar).Value = buku.Penerbit;
            cmd.Parameters.Add("@nama_buku", MySqlDbType.VarChar).Value = buku.Nama_buku;
            cmd.Parameters.Add("@tanggal", MySqlDbType.VarChar).Value = buku.Tanggal.ToString("yyyy-MM-dd HH:mm");
            cmd.Parameters.Add("@harga", MySqlDbType.Int32).Value = buku.Harga;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil tambah buku.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        public static void DeleteBuku(string id)
        {
            string sql = "DELETE FROM tbl_buku WHERE kode_buku = @idddd;";

            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idddd", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil hapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        public static void UpdateBuku(Buku buku, string id)
        {
            string sql = "UPDATE tbl_buku SET penulis = @Penulis, penerbit = @Penerbit, nama_buku = @namaBuku, tanggal_terbit = @Tanggal, Harga = @harga WHERE kode_buku = @kodeBuku";
            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kodeBuku", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Penulis", MySqlDbType.VarChar).Value = buku.Penulis;
            cmd.Parameters.Add("@Penerbit", MySqlDbType.VarChar).Value = buku.Penerbit;
            cmd.Parameters.Add("@namaBuku", MySqlDbType.VarChar).Value = buku.Nama_buku;
            cmd.Parameters.Add("@harga", MySqlDbType.Int32).Value = buku.Harga;
            cmd.Parameters.Add("@Tanggal", MySqlDbType.DateTime).Value = buku.Tanggal.ToString("yyyy-MM-dd HH:mm");

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil ubah.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        public static void tambahPembeli(Pembeli pembeli)
        {
            string sql = "INSERT INTO tbl_pembeli values(@kode_buku, @nama_pembeli, @kode_transaksi, @jumlah)";
            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kode_buku", MySqlDbType.VarChar).Value = pembeli.Kode_Buku;
            cmd.Parameters.Add("@nama_pembeli", MySqlDbType.VarChar).Value = pembeli.NamaPembeli;
            cmd.Parameters.Add("@kode_transaksi", MySqlDbType.VarChar).Value = pembeli.Kode_Transaksi;
            cmd.Parameters.Add("@jumlah", MySqlDbType.Int32).Value = pembeli.Jumlah;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil tambah pembeli.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        public static void ubahPembeli(Pembeli pembeli, string kode)
        {
            string sql = "UPDATE tbl_pembeli SET kode_buku = @Kode, nama_pembeli = @Nama, jumlah = @Jumlah WHERE kode_transaksi = @Trx AND kode_buku = @Kodee";
            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Kode", MySqlDbType.VarChar).Value = pembeli.Kode_Buku;
            cmd.Parameters.Add("@Nama", MySqlDbType.VarChar).Value = pembeli.NamaPembeli;
            cmd.Parameters.Add("@Jumlah", MySqlDbType.Int32).Value = pembeli.Jumlah;
            cmd.Parameters.Add("@Trx", MySqlDbType.VarChar).Value = pembeli.Kode_Transaksi;
            cmd.Parameters.Add("@Kodee", MySqlDbType.VarChar).Value = kode;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil ubah.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        public static void DeletePembeli(string id, string trx)
        {
            string sql = "DELETE FROM tbl_pembeli WHERE kode_buku = @idddd AND kode_transaksi = @Trx";

            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idddd", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@Trx", MySqlDbType.VarChar).Value = trx;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil hapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        public static void tambahTransaksi(DetailTransaksi transaksi)
        {
            string sql = "INSERT INTO tbl_detailtransaksi values(@kode_transaksi, @telpon, @alamat, @tanggalBayar)";
            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kode_transaksi", MySqlDbType.VarChar).Value = transaksi.Kode_Transaksi;
            cmd.Parameters.Add("@telpon", MySqlDbType.VarChar).Value = transaksi.Telpon;
            cmd.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = transaksi.Alamat;
            cmd.Parameters.Add("@tanggalBayar", MySqlDbType.DateTime).Value = transaksi.TanggalBayar.ToString("yyyy-MM-dd HH:mm");



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil tambah transaksi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        public static void DeleteTransaksi(string id)
        {
            string sql = "DELETE FROM tbl_detailtransaksi WHERE kode_transaksi = @idddd";

            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@idddd", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil hapus.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed.\n" + ex, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        public static void ubahTransaksi(DetailTransaksi pembeli)
        {
            string sql = "UPDATE tbl_detailtransaksi SET telpon = @Tlp, alamat = @Alt, tanggal_dibayar = @tgl WHERE kode_transaksi = @Trx";
            MySqlConnection con = getConn();
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Tlp", MySqlDbType.VarChar).Value = pembeli.Telpon;
            cmd.Parameters.Add("@Alt", MySqlDbType.VarChar).Value = pembeli.Alamat;
            cmd.Parameters.Add("@tgl", MySqlDbType.VarChar).Value = pembeli.TanggalBayar.ToString("yyyy-MM-dd HH:mm");
            cmd.Parameters.Add("@Trx", MySqlDbType.VarChar).Value = pembeli.Kode_Transaksi;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil ubah.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data gagal disimpan\n" + ex, "info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }
    }
}

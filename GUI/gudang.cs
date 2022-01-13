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
    public partial class gudang : Form
    {
        Kelas.Koneksi koneksi = new Kelas.Koneksi();
        public gudang()
        {
            InitializeComponent();
            loadDaftar();
        }
        void header()
        {
            grid_gudang.Columns[0].Visible = false;
            grid_gudang.Columns[1].HeaderText = "Penulis";
            grid_gudang.Columns[2].HeaderText = "Penerbit";  
            grid_gudang.Columns[3].HeaderText = "Nama Buku";
            grid_gudang.Columns[4].HeaderText = "Tanggal Terbit";  



        }
        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT * FROM tbl_gudang";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koneksi.getConn();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "tbl_gudang");
            }
            catch (Exception e)
            {
                MessageBox.Show("get\n" + e.ToString());
            }
            return dts;
        }
        public void loadDaftar()
        {
            DataSet data = getData();
            grid_gudang.DataSource = data;
            grid_gudang.DataMember = "tbl_gudang";
            header();
        }
        }

        private void grid_gudang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


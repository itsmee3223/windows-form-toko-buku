using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Buku.GUI
{
    public partial class TambahBuku : Form
    {
        public TambahBuku()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtKodeBuku.Text = txtNamaBuku.Text = txtNamaPenerbit.Text = txtNamaPenulis.Text = txtHarga.Text = string.Empty;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            dtTerbit.CustomFormat = "yyyy/dd/MM";
            Kelas.Buku buku = new Kelas.Buku(txtKodeBuku.Text.Trim(), txtNamaPenulis.Text.Trim(), txtNamaPenerbit.Text.Trim(), txtNamaBuku.Text.Trim(), dtTerbit.Value.Date, Int32.Parse(txtHarga.Text.Trim()));
            Kelas.Koneksi.AddBuku(buku);
            Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            GUI.TambahBuku menuBuku = new GUI.TambahBuku();
            menuBuku.Show();
            this.Hide();
        }
    }
}

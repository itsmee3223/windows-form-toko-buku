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
    public partial class EditBuku : Form
    {
        public string _kodeBukuu;
        private readonly MenuUtama _parent;
        public EditBuku(string kodeBukuu, MenuUtama parent)
        {
            InitializeComponent();
            _parent = parent;
            _kodeBukuu = kodeBukuu;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dtTerbit.CustomFormat = "yyyy/dd/MM";
            Kelas.Buku buku = new Kelas.Buku(_kodeBukuu, txtNamaPenulis.Text.Trim(), txtNamaPenerbit.Text.Trim(), txtNamaBuku.Text.Trim(), dtTerbit.Value.Date, Int32.Parse(txtHarga.Text.Trim()));
            if (MessageBox.Show("Are you sure want to update!!!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Kelas.Koneksi.UpdateBuku(buku, _kodeBukuu);
                _parent.Display();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

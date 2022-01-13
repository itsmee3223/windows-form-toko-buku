using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toko_Buku.Kelas
{
    class Pembeli
    {
        public Pembeli(string kode_buku, string kode_transaksi, string namaPembeli, int jumlah)
        {
            Kode_Buku = kode_buku;
            Kode_Transaksi = kode_transaksi;
            NamaPembeli = namaPembeli;
            Jumlah = jumlah;
        }

        public string Kode_Buku { get; set; }
        public string Kode_Transaksi { get; set; }
        public string NamaPembeli { get; set; }
        public int Jumlah { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toko_Buku.Kelas
{
    class DetailTransaksi
    {
        public DetailTransaksi(string kode_transaksi, string telpon, string alamat, DateTime tanggalBayar)
        {
            Kode_Transaksi = kode_transaksi;
            Telpon = telpon;
            Alamat = alamat;
            TanggalBayar = tanggalBayar;
        }

        public string Kode_Transaksi { get; set; }
        public string Telpon { get; set; }
        public string Alamat { get; set; }
        public DateTime TanggalBayar { get; set; }

    }
}

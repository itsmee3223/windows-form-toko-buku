using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toko_Buku.Kelas
{
    class Buku
    {
        public Buku(string kode_buku, string penulis, string penerbit, string nama_buku, DateTime tanggal, int harga)
        {
            Kode_buku = kode_buku;
            Penulis = penulis;
            Penerbit = penerbit;
            Nama_buku = nama_buku;
            Tanggal = tanggal;
            Harga = harga;
        }

        public string Kode_buku { get; set; }
        public string Penulis { get; set; }
        public string Penerbit{ get; set; }
        public string Nama_buku { get; set; }
        public DateTime Tanggal { get; set; }
        public int Harga { get; set; }

    }
}

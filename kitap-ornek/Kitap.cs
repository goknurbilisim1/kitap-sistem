using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_ornek
{
    internal class Kitap
    {
        int id;
        string kitapAdi;
        string yazar;
        string sayfaSayisi;
        string tur;
        DateTime tarih;
        bool cilt;

        public int Id { get => id; set => id = value; }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }
        public string Tur { get => tur; set => tur = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Cilt { get => cilt; set => cilt = value; }

        public Kitap(int id, string kitapAdi, string yazar, string sayfaSayisi, string tur, DateTime tarih, bool cilt)
        {
            this.id = id;
            this.kitapAdi = kitapAdi;
            this.yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
            this.tur = tur;
            this.tarih = tarih;
            this.cilt = cilt;
        }
    }
}

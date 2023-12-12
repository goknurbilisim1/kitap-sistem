using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitap;
        List<Kitap> kitapListesi=new List<Kitap>();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListesi.Add(new Kitap(1, "Kardeşimin Koruyucusu", "Julie Lee", "362","Roman",new DateTime(2020,01,20),false));
            kitapListesi.Add(new Kitap(2, "Donmuş Bir Kalp", "Elizabeth Rudnick", "380", "Roman", new DateTime(2016, 8, 21), true));
            kitapListesi.Add(new Kitap(3, "Kar Küresi", "Beyza Alkoç", "562", "Roman", new DateTime(2022, 5, 12), true));

            dvgListe.DataSource= kitapListesi;
        }

        private void dvgListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dvgListe.CurrentRow.Cells["id"].Value.ToString();
            txtKitapAdi.Text = dvgListe.CurrentRow.Cells["kitapAdi"].Value.ToString();
            txtYazar.Text = dvgListe.CurrentRow.Cells["yazar"].Value.ToString();
            txtSayfaSayisi.Text = dvgListe.CurrentRow.Cells["sayfaSayisi"].Value.ToString();
            cmbTur.Text = dvgListe.CurrentRow.Cells["tur"].Value.ToString();
            chkCilt.Checked = (bool)dvgListe.CurrentRow.Cells["cilt"].Value;
            dtpTarih.Value = (DateTime)dvgListe.CurrentRow.Cells["tarih"].Value;
           

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string sayfaSayisi=txtSayfaSayisi.Text;
            string tur=cmbTur.Text;
            bool cilt=chkCilt.Checked;
            DateTime tarih=dtpTarih.Value;
            


            Kitap yeniKitap = new Kitap(id, kitapAdi, yazar, sayfaSayisi, tur, tarih, cilt);
            kitapListesi.Add(yeniKitap);

            dvgListe.DataSource = kitapListesi.ToList();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dvgListe.SelectedRows[0];
            Kitap secilenKitap=secilenSatir.DataBoundItem as Kitap;
            DialogResult=MessageBox.Show("Seçilen kitap silinsin mi?","Kitap Sil",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                kitapListesi.Remove(secilenKitap);
            }

             dvgListe.DataSource = kitapListesi;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir=dvgListe.SelectedRows[0];
            Kitap secilenKitap = secilenSatir.DataBoundItem as Kitap;
            int id = Convert.ToInt32(txtId.Text);
            string kitapAdi = txtKitapAdi.Text;
            string yazar = txtYazar.Text;
            string sayfaSayisi=txtSayfaSayisi.Text;
            string tur=cmbTur.Text;
            bool cilt = chkCilt.Checked;
            DateTime tarih = dtpTarih.Value;
            


            secilenKitap.Id= id;
            secilenKitap.KitapAdi = kitapAdi;
            secilenKitap.Yazar= yazar;
            secilenKitap.SayfaSayisi=sayfaSayisi;
            secilenKitap.Tur= tur;
            secilenKitap.Cilt = cilt;
            secilenKitap.Tarih = tarih;
            

            dvgListe.DataSource = null;
            dvgListe.DataSource = kitapListesi.ToList(); ;


        }

    }
}

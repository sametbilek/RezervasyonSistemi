using System;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class FormOdeme : Form
    {
        private int seciliKoltuk; 

        public FormOdeme(int seciliKoltuk)
        {
            InitializeComponent();
            this.seciliKoltuk = seciliKoltuk;
        }

        private void buttonOdemeYap_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string TcNo = textBoxTcNo.Text;
            string dogumTarihi = textBoxDogumTarihi.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(TcNo) || string.IsNullOrEmpty(dogumTarihi))
            {
                MessageBox.Show("Lütfen tüm ödeme bilgilerini girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rezervasyonBilgileri = $"Rezervasyon tamamlandı!\nAd: {ad}\nSoyad: {soyad}\nTcNo: {TcNo}\nDogumTarihi: {dogumTarihi}\n";
            rezervasyonBilgileri += $"Koltuklar: {string.Join(", ", seciliKoltuk)}";
            MessageBox.Show(rezervasyonBilgileri);

            this.Close();
        }
    }
}
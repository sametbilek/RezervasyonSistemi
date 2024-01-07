using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace RezervasyonSistemi
{
    public partial class FormUser : Form
    {
        private RouteManager routeManager;
        private int seciliKoltukSayisi = 0;
        private List<Button> secilenKoltuklar = new List<Button>();

        public FormUser(RouteManager routeManager)
        {
            InitializeComponent();
            this.routeManager = routeManager;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            comboBox5.DataSource = GetTasitlar();
            OtomatikKoltukDoldur(80);

            for (DateTime date = new DateTime(2023, 12, 4); date <= new DateTime(2023, 12, 10); date = date.AddDays(1))
            {
                comboBoxTarih.Items.Add(date.ToString("dd.MM.yyyy"));
            }

            for (int i = 1; i <= 3; i++)
            {
                comboBoxYolcuSayisi.Items.Add(i);
            }

            List<string> allCities = routeManager.GetAllCities();
            foreach (var city in allCities)
            {
                comboBoxKalkis.Items.Add(city);
                comboBoxVaris.Items.Add(city);
            }
        }

        private void OtomatikKoltukDoldur(int yuzde)
        {
            string secilenTasit = comboBox5.SelectedItem?.ToString();

            if (secilenTasit != null)
            {
                KoltuklariGosterDinamik(secilenTasit, yuzde);
            }
        }

        private void KoltuklariGosterDinamik(string tasitAdi, int dolulukYuzdesi)
        {
            flowLayoutPanelKoltuklar.Controls.Clear();

            Vehicle selectedVehicle = routeManager.CompanyManager.CompanyVehicles
                .FirstOrDefault(v => v.araçId == tasitAdi);

            if (selectedVehicle != null)
            {
                int koltukSayisi = selectedVehicle.kapasite;

                for (int i = 1; i <= koltukSayisi; i++)
                {
                    Button koltuk = new Button();
                    koltuk.Text = $"Koltuk {i} - {tasitAdi}";
                    Passenger randomPassenger = GetRandomPassenger();

                    if (KoltukDoluMu(tasitAdi, i, dolulukYuzdesi))
                    {
                        koltuk.BackColor = Color.Green;
                        koltuk.Enabled = false;
                    }
                    else
                    {
                        koltuk.Click += KoltukSecildi;
                    }
                    flowLayoutPanelKoltuklar.Controls.Add(koltuk);
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenTasit = comboBox5.SelectedItem?.ToString();
            int dolulukYuzdesi = 80;
            KoltuklariGosterDinamik(secilenTasit, dolulukYuzdesi);
        }

        private void KoltukSecildi(object sender, EventArgs e)
        {
            Button secilenKoltuk = (Button)sender;

            if (secilenKoltuk.BackColor == Color.Green)
            {
                MessageBox.Show("Bu koltuk dolu!", "Dolu Koltuk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (secilenKoltuk.BackColor == Color.Yellow)
            {
                MessageBox.Show("Bu koltuk zaten seçildi!", "Zaten Seçildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                secilenKoltuk.BackColor = Color.Yellow;
                secilenKoltuklar.Add(secilenKoltuk);

                seciliKoltukSayisi++;

                if (seciliKoltukSayisi == comboBoxYolcuSayisi.SelectedIndex + 1)
                {
                    MessageBox.Show($"Toplam {seciliKoltukSayisi} koltuk seçildi. Devam etmek için rezervasyon yap butonuna tıklayın.");

                    int koltukNo = int.Parse(secilenKoltuklar[0].Text.Split(' ')[1]);
                    FormOdeme formOdeme = new FormOdeme(koltukNo);
                    formOdeme.ShowDialog();

                    
                    for (int i = 1; i < secilenKoltuklar.Count; i++)
                    {
                        MessageBox.Show($"Lütfen bir sonraki koltuğu seçin.");
                        koltukNo = int.Parse(secilenKoltuklar[i].Text.Split(' ')[1]);
                        FormOdeme formOdeme2 = new FormOdeme(koltukNo);
                        formOdeme2.ShowDialog();
                    }

                    secilenKoltuklar.Clear();
                    seciliKoltukSayisi = 0;
                }
                else
                {
                    MessageBox.Show($"Koltuk {secilenKoltuk.Text} seçildi. Bir sonraki koltuğu seçmek için devam edin.");
                }
            }
        }


        private void comboBoxYolcuSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxYolcuSayisi.SelectedItem?.ToString(), out seciliKoltukSayisi))
            {
                RezervasyonYap(seciliKoltukSayisi);
            }
        }

        private void RezervasyonYap(int koltukSayisi)
        {
            string secilenTasit = comboBox5.SelectedItem?.ToString();
            int dolulukYuzdesi = 80;

            List<int> bosKoltuklar = GetBosKoltuklar(secilenTasit, dolulukYuzdesi);

            seciliKoltukSayisi = 0;
            secilenKoltuklar.Clear();

            for (int i = 0; i < koltukSayisi && i < bosKoltuklar.Count; i++)
            {
                int rezervasyonYapilanKoltuk = bosKoltuklar[i];
                Button secilenKoltuk = flowLayoutPanelKoltuklar.Controls
                    .OfType<Button>()
                    .FirstOrDefault(k => k.Text.Contains($"Koltuk {rezervasyonYapilanKoltuk} - {secilenTasit}"));

                if (secilenKoltuk != null)
                {
                    secilenKoltuk.BackColor = Color.Blue;
                    secilenKoltuk.Enabled = false;
                    MessageBox.Show($"Koltuk {secilenKoltuk.Text} başarıyla rezerve edildi.");
                }
            }
        }

        private List<int> GetBosKoltuklar(string tasitAdi, int dolulukYuzdesi)
        {
            Vehicle selectedVehicle = routeManager.CompanyManager.CompanyVehicles
                .FirstOrDefault(v => v.araçId == tasitAdi);

            List<int> bosKoltuklar = new List<int>();

            if (selectedVehicle != null)
            {
                int koltukSayisi = selectedVehicle.kapasite;

                for (int i = 1; i <= koltukSayisi; i++)
                {
                    if (!KoltukDoluMu(tasitAdi, i, dolulukYuzdesi))
                    {
                        bosKoltuklar.Add(i);
                    }
                }
            }

            return bosKoltuklar;
        }

        private bool KoltukDoluMu(string tasitAdi, int koltukNo, int dolulukYuzdesi)
        {
            Vehicle selectedVehicle = routeManager.CompanyManager.CompanyVehicles
                .FirstOrDefault(v => v.araçId == tasitAdi);

            if (selectedVehicle != null)
            {
                Random random = new Random($"{tasitAdi}_{koltukNo}".GetHashCode());
                int randomDoluluk = random.Next(0, 101);

                return randomDoluluk <= dolulukYuzdesi;
            }

            return false;
        }

        private Passenger GetRandomPassenger()
        {
            Random random = new Random();
            return new Passenger($"Passenger_{random.Next(1, 100)}", $"Surname_{random.Next(1, 100)}");
        }

        private List<string> GetTasitlar()
        {
            return new List<string> { "ABus1", "ABus2", "BBus1", "BBus2", "CBus1", "CAirplane1", "CAirplane2", "DTrain1", "DTrain2", "DTrain3", "FAirplane1", "FAirplane2" };
        }

        private void buttonSeferBul_Click(object sender, EventArgs e)
        {
            if (comboBoxTarih.SelectedItem == null || comboBoxKalkis.SelectedItem == null || comboBoxVaris.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tarih, kalkış ve varış noktalarını seçin.");
                return;
            }

            DateTime seciliTarih = DateTime.ParseExact(comboBoxTarih.SelectedItem.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string kalkisNoktasi = comboBoxKalkis.SelectedItem.ToString();
            string varisNoktasi = comboBoxVaris.SelectedItem.ToString();

            List<string> uygunSeferler = SeferleriBul(seciliTarih, kalkisNoktasi, varisNoktasi);

            listBoxUygunSeferler.Items.Clear();
            foreach (var seferBilgisi in uygunSeferler)
            {
                listBoxUygunSeferler.Items.Add(seferBilgisi);
            }
        }

        private List<string> SeferleriBul(DateTime seciliTarih, string kalkis, string varis)
        {
            List<string> seferBilgileri = new List<string>();

            foreach (var route in routeManager.Routes)
            {
                if (route.DepartureDate.Date == seciliTarih.Date &&
                    ((route.DepartureCity == kalkis && route.ArrivalCity == varis) ||
                     (route.ViaCities.Contains(kalkis) && route.ViaCities.Contains(varis))))
                {
                    string seferBilgisi = $"{route.DepartureCity} - {route.ArrivalCity}, Tarih: {route.FormattedDepartureDate}";

                    if (route.ViaCities.Count > 0)
                    {
                        seferBilgisi += $", Ara Şehirler: {string.Join(", ", route.ViaCities)}";
                    }

                    var eslesmisAraclar = routeManager.CompanyManager.CompanyVehicles
                        .Where(arac => arac.seferNo == route.RouteNumber);

                    if (eslesmisAraclar.Any())
                    {
                        var aracBilgileri = eslesmisAraclar.Select(arac => $"{arac.companyName} - {arac.araçId}");
                        seferBilgisi += $", Araçlar: {string.Join(", ", aracBilgileri)}";
                    }

                    seferBilgileri.Add(seferBilgisi);
                }
            }

            return seferBilgileri;
        }

    }
}

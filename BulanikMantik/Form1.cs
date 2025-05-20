using BulanikMantikOdev;
using System.Drawing.Drawing2D;

namespace BulanikMantik

{
    public partial class Form1 : Form
    {
        private List<int> _sonTetiklenenIdx = new List<int>();
        private List<double> _sonAlphaList = new List<double>();
        private BulanikDegisken degHassaslik;
        private BulanikDegisken degMiktar;
        private BulanikDegisken degKirlilik;
        private BulanikDegisken degDonusHizi;
        private double sonHiz = 0.0;


        // 2) Kural listesi
        private List<BulanikKural> kurallar;
        public Form1()
        {
            InitializeComponent();
            InitializeFuzzyVariables();   // üyelik kümelerini hazırla
            InitializeRules();            // kural tablosunu oluştur
            this.nudHassaslik.ValueChanged += new System.EventHandler(this.nudHassaslik_ValueChanged);
            this.nudHassaslik.ValueChanged += nudHassaslik_ValueChanged;

            this.pbHassaslik.Paint += new PaintEventHandler(pbHassaslik_Paint);
            this.nudHassaslik.ValueChanged += (s, e) => this.pbHassaslik.Invalidate();

            this.pbMiktar.Paint += new PaintEventHandler(pbMiktar_Paint);
            this.nudMiktar.ValueChanged += (s, e) => this.pbMiktar.Invalidate();

            this.pbKirlilik.Paint += new PaintEventHandler(pbKirlilik_Paint);
            this.nudKirlilik.ValueChanged += (s, e) => this.pbKirlilik.Invalidate();

            // Sonuç grafiği için de isterseniz:
            
            this.pbSonucGrafik.Paint += new PaintEventHandler(pbSonucGrafik_Paint);

            // (Eğer henüz eklemediyseniz)
            this.nudHassaslik.ValueChanged += (s, e) => pbSonucGrafik.Invalidate();
            this.nudMiktar.ValueChanged += (s, e) => pbSonucGrafik.Invalidate();
            this.nudKirlilik.ValueChanged += (s, e) => pbSonucGrafik.Invalidate();
            
            lvwMamdani.View = View.Details;
       
           
            dgvKurallar.MultiSelect = true;
            dgvKurallar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKurallar.RowHeadersVisible = false;  // isterseniz kapatın
            pbSonucGrafik.Paint += pbSonucGrafik_Paint;


        }
        private void InitializeFuzzyVariables()
        {
            // 1) Hassaslık değişkeni ve kümeleri
            degHassaslik = new BulanikDegisken("Hassaslık");
            degHassaslik.KumeEkle(new YamukKume("Sağlam", -4, -1.5, 2, 4));
            degHassaslik.KumeEkle(new UcgenKume("Orta", 3, 5, 7));
            degHassaslik.KumeEkle(new YamukKume("Hassas", 5.5, 8, 12.5, 14));

            // 2) Miktar değişkeni ve kümeleri
            degMiktar = new BulanikDegisken("Miktar");
            degMiktar.KumeEkle(new YamukKume("Küçük", -4, -1.5, 2, 4));
            degMiktar.KumeEkle(new UcgenKume("Orta", 3, 5, 7));
            degMiktar.KumeEkle(new YamukKume("Büyük", 5.5, 8, 12.5, 14));

            // 3) Kirlilik değişkeni ve kümeleri
            degKirlilik = new BulanikDegisken("Kirlilik");
            degKirlilik.KumeEkle(new YamukKume("Küçük", -4.5, -2.5, 2, 4.5));
            degKirlilik.KumeEkle(new UcgenKume("Orta", 3, 5, 7));
            degKirlilik.KumeEkle(new YamukKume("Büyük", 5.5, 8, 12.5, 15));

            degDonusHizi = new BulanikDegisken("Dönüş Hızı");
            degDonusHizi.KumeEkle(new YamukKume("hassas", -5.8, -2.8, 0.5, 1.5));
            degDonusHizi.KumeEkle(new UcgenKume("normal_hassas", 0.5, 2.75, 5.0));
            degDonusHizi.KumeEkle(new UcgenKume("orta", 2.75, 5.0, 7.25));
            degDonusHizi.KumeEkle(new UcgenKume("normal_güçlü", 5.0, 7.25, 9.5));
            degDonusHizi.KumeEkle(new YamukKume("güçlü", 8.5, 9.5, 12.8, 15.2));

        }
        private void InitializeRules()
        {
            kurallar = new List<BulanikKural>();

            // 1–9: Hassaslık = "Hassas"
            kurallar.Add(new BulanikKural("Hassas", "Küçük", "Küçük", "hassas", "kısa", "çok_az"));
            kurallar.Add(new BulanikKural("Hassas", "Küçük", "Orta", "normal_hassas", "kısa", "az"));
            kurallar.Add(new BulanikKural("Hassas", "Küçük", "Büyük", "orta", "normal_kısa", "orta"));
            kurallar.Add(new BulanikKural("Hassas", "Orta", "Küçük", "hassas", "kısa", "orta"));
            kurallar.Add(new BulanikKural("Hassas", "Orta", "Orta", "normal_hassas", "normal_kısa", "orta"));
            kurallar.Add(new BulanikKural("Hassas", "Orta", "Büyük", "orta", "orta", "fazla"));
            kurallar.Add(new BulanikKural("Hassas", "Büyük", "Küçük", "normal_hassas", "normal_kısa", "orta"));
            kurallar.Add(new BulanikKural("Hassas", "Büyük", "Orta", "normal_hassas", "orta", "fazla"));
            kurallar.Add(new BulanikKural("Hassas", "Büyük", "Büyük", "orta", "normal_uzun", "fazla"));

            // 10–18: Hassaslık = "Orta"
            kurallar.Add(new BulanikKural("Orta", "Küçük", "Küçük", "normal_hassas", "normal_kısa", "az"));
            kurallar.Add(new BulanikKural("Orta", "Küçük", "Orta", "orta", "kısa", "orta"));
            kurallar.Add(new BulanikKural("Orta", "Küçük", "Büyük", "normal_güçlü", "orta", "fazla"));
            kurallar.Add(new BulanikKural("Orta", "Orta", "Küçük", "normal_hassas", "normal_kısa", "orta"));
            kurallar.Add(new BulanikKural("Orta", "Orta", "Orta", "orta", "orta", "orta"));
            kurallar.Add(new BulanikKural("Orta", "Orta", "Büyük", "hassas", "uzun", "fazla"));
            kurallar.Add(new BulanikKural("Orta", "Büyük", "Küçük", "hassas", "orta", "orta"));
            kurallar.Add(new BulanikKural("Orta", "Büyük", "Orta", "hassas", "normal_uzun", "fazla"));
            kurallar.Add(new BulanikKural("Orta", "Büyük", "Büyük", "hassas", "uzun", "çok_fazla"));

            // 19–27: Hassaslık = "Sağlam"
            kurallar.Add(new BulanikKural("Sağlam", "Küçük", "Küçük", "orta", "orta", "az"));
            kurallar.Add(new BulanikKural("Sağlam", "Küçük", "Orta", "normal_güçlü", "orta", "orta"));
            kurallar.Add(new BulanikKural("Sağlam", "Küçük", "Büyük", "güçlü", "normal_uzun", "fazla"));
            kurallar.Add(new BulanikKural("Sağlam", "Orta", "Küçük", "orta", "orta", "orta"));
            kurallar.Add(new BulanikKural("Sağlam", "Orta", "Orta", "normal_güçlü", "normal_uzun", "orta"));
            kurallar.Add(new BulanikKural("Sağlam", "Orta", "Büyük", "güçlü", "orta", "çok_fazla"));
            kurallar.Add(new BulanikKural("Sağlam", "Büyük", "Küçük", "normal_güçlü", "normal_uzun", "fazla"));
            kurallar.Add(new BulanikKural("Sağlam", "Büyük", "Orta", "normal_güçlü", "uzun", "fazla"));
            kurallar.Add(new BulanikKural("Sağlam", "Büyük", "Büyük", "güçlü", "uzun", "çok_fazla"));

            // DataGridView'e yükle
            dgvKurallar.Rows.Clear();
            for (int i = 0; i < kurallar.Count; i++)
            {
                var k = kurallar[i];
                dgvKurallar.Rows.Add(
                    (i + 1).ToString("D2"),
                    k.HassaslikEtiketi,
                    k.MiktarEtiketi,
                    k.KirlilikEtiketi,
                    k.HizEtiketi,
                    k.SureEtiketi,
                    k.DeterjanEtiketi
                );
            }
        }


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // 1) Girdi
            double h = (double)nudHassaslik.Value;
            double m = (double)nudMiktar.Value;
            double k = (double)nudKirlilik.Value;

            // 2) Fuzzifikasyon
            var muH = degHassaslik.Bulaniklastir(h);
            var muM = degMiktar.Bulaniklastir(m);
            var muK = degKirlilik.Bulaniklastir(k);

            // 3) Temizle
            lstKurallar.Items.Clear();
            lvwMamdani.Items.Clear();
            dgvKurallar.ClearSelection();

            // 4) Listeler
            var tetiklenenIndeksler = new List<int>();
            var alphaList = new List<double>();
            var hizList = new List<double>();
            var sureList = new List<double>();
            var detList = new List<double>();

            // 5) Centroid temsilleri
            var reprHiz = new Dictionary<string, double>{
            {"hassas",0.5}, {"normal_hassas",2.75}, {"orta",5.0},
            {"normal_güçlü",7.25}, {"güçlü",9.5}
        };
            var reprSure = new Dictionary<string, double>{
            {"kısa",22.3}, {"normal_kısa",39.9}, {"orta",57.5},
            {"normal_uzun",75.1}, {"uzun",92.7}
        };
            var reprDet = new Dictionary<string, double>{
            {"çok_az",20}, {"az",85}, {"orta",150},
            {"fazla",215}, {"çok_fazla",280}
        };

            // 6) Kurallar
            for (int i = 0; i < kurallar.Count; i++)
            {
                var rule = kurallar[i];
                double a1 = muH[rule.HassaslikEtiketi];
                double a2 = muM[rule.MiktarEtiketi];
                double a3 = muK[rule.KirlilikEtiketi];
                double alpha = Math.Min(a1, Math.Min(a2, a3));

                if (alpha > 0)
                {
                    // ListBox’a metin
                    lstKurallar.Items.Add(
                        $"{i + 1:00}. {rule.HassaslikEtiketi}/" +
                        $"{rule.MiktarEtiketi}/{rule.KirlilikEtiketi} → " +
                        $"{rule.HizEtiketi},{rule.SureEtiketi},{rule.DeterjanEtiketi}"
                    );

                    // Veri biriktir
                    tetiklenenIndeksler.Add(i);
                    alphaList.Add(alpha);
                    hizList.Add(reprHiz[rule.HizEtiketi] * alpha);
                    sureList.Add(reprSure[rule.SureEtiketi] * alpha);
                    detList.Add(reprDet[rule.DeterjanEtiketi] * alpha);
                }
            }

            // 7) DataGridView’de satır seçimi
            foreach (int idx in tetiklenenIndeksler)
            {
                if (idx >= 0 && idx < dgvKurallar.Rows.Count)
                    dgvKurallar.Rows[idx].Cells[0].Selected = true;
            }
            if (tetiklenenIndeksler.Count > 0)
            {
                int ilk = tetiklenenIndeksler[0];
                dgvKurallar.FirstDisplayedScrollingRowIndex = ilk;
                dgvKurallar.CurrentCell = dgvKurallar.Rows[ilk].Cells[0];
            }

            // 8) ListView’e yaz
            for (int t = 0; t < tetiklenenIndeksler.Count; t++)
            {
                int no = tetiklenenIndeksler[t] + 1;
                double a = alphaList[t];
                var item = new ListViewItem(no.ToString("D2"));
                item.SubItems.Add(a.ToString("F2").Replace('.', ','));
                lvwMamdani.Items.Add(item);
            }

            // 9) Defuzz – ağırlıklı ortalama (örnek dönüş hızı)
            double sumA = alphaList.Sum();
            double resH = 0, resS = 0, resD = 0;
            if (sumA > 0)
            {
                resH = hizList.Sum() / sumA;
                resS = sureList.Sum() / sumA;
                resD = detList.Sum() / sumA;
            }

            // 10) Etiketler
            
            lblDegerHiz.Text = resH.ToString("F2").Replace('.', ',');
            lblDegerSure.Text = resS.ToString("F2").Replace('.', ',');
            lblDegerDet.Text = resD.ToString("F2").Replace('.', ',');

            // 11) Sonuçlar sekmesine geç & grafik
            tabControlMain.SelectedIndex = 2;
            pbSonucGrafik.Invalidate();
        }







        private void DrawGrafik(
    Graphics g,
    PictureBox pb,
    BulanikDegisken deg,
    decimal deger,
    string baslik
)
        {
            int W = pb.Width;
            int H = pb.Height;

            // Antialiasing
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Arka plan
            g.Clear(Color.White);

            // Kenar boşlukları
            int left = 40,
                right = 10,
                top = 30,
                bottom = 30;
            int graphW = W - left - right;
            int graphH = H - top - bottom;

            // 1) Eksenler
            using (var axisPen = new Pen(Color.Black, 1))
            {
                // X ekseni
                g.DrawLine(axisPen, left, H - bottom, left + graphW, H - bottom);
                // Y ekseni
                g.DrawLine(axisPen, left, top, left, top + graphH);
            }

            // 2) Tick’ler ve sayılar
            using (var font = new Font("Arial", 8))
            {
                for (int i = 0; i <= 10; i++)
                {
                    float x = left + i * (graphW / 10f);
                    g.DrawLine(Pens.Black, x, H - bottom, x, H - bottom + 5);
                    string s = i.ToString();
                    SizeF sz = g.MeasureString(s, font);
                    g.DrawString(s, font, Brushes.Black, x - sz.Width / 2, H - bottom + 5);
                }

                // Y ekseni 0 ve 1
                g.DrawLine(Pens.Black, left - 5, top + graphH, left, top + graphH);
                g.DrawString("0", font, Brushes.Black, left - 20, top + graphH - 6);
                g.DrawLine(Pens.Black, left - 5, top, left, top);
                g.DrawString("1", font, Brushes.Black, left - 20, top - 6);
            }

            // 3) Başlık
            using (var titleFont = new Font("Arial", 12f, FontStyle.Bold))
            {
                SizeF sz = g.MeasureString(baslik, titleFont);
                float x = (float)((W - sz.Width) / 2.0);
                float y = 5f;
                g.DrawString(baslik, titleFont, Brushes.Black, x, y);
            }

            // 4) Üyelik fonksiyonları
            Color[] renkler = { Color.Blue, Color.Green, Color.Orange, Color.Purple, Color.Brown };
            for (int idx = 0; idx < deg.Kumeler.Count; idx++)
            {
                var kume = deg.Kumeler[idx];
                using (var pen = new Pen(renkler[idx % renkler.Length], 2))
                {
                    var pts = new List<PointF>();
                    for (double xv = 0; xv <= 10.0; xv += 0.1)
                    {
                        double mu = kume.UyeDerecesi(xv);
                        float px = left + (float)(xv / 10.0 * graphW);
                        float py = top + graphH - (float)(mu * graphH);
                        pts.Add(new PointF(px, py));
                    }
                    if (pts.Count > 1)
                        g.DrawLines(pen, pts.ToArray());
                }
            }

            // 5) Seçili değeri çiz
            float markerX = left + (float)((double)deger / 10.0 * graphW);
            using (var redPen = new Pen(Color.Red, 1))
            {
                g.DrawLine(redPen, markerX, top, markerX, top + graphH);
            }
        }


        private void pbSonucGrafik_Paint(object sender, PaintEventArgs e)
        {
            DrawGrafik(e.Graphics,pbSonucGrafik,degDonusHizi,(decimal)sonHiz,"Dönüş Hızı Üyelik Fonksiyonu");
        }
        private void nudHassaslik_ValueChanged(object sender, EventArgs e)
        {
            pbHassaslik.Invalidate();
        }

        private void pbHassaslik_Paint(object sender, PaintEventArgs e)
        {
            DrawGrafik(e.Graphics,pbHassaslik,degHassaslik,nudHassaslik.Value,"Hassaslık Üyelik Fonksiyonu");
        }

        private void pbMiktar_Paint(object sender, PaintEventArgs e)
        {
            DrawGrafik(e.Graphics,pbMiktar,degMiktar,nudMiktar.Value,"Miktar Üyelik Fonksiyonu");
        }

        // Kirlilik grafiği için
        private void pbKirlilik_Paint(object sender, PaintEventArgs e)
        {
            DrawGrafik(e.Graphics,pbKirlilik,degKirlilik,nudKirlilik.Value,"Kirlilik Üyelik Fonksiyonu");
        }

    
        

    }

}

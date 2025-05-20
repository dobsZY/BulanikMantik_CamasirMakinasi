using System;
using System.Collections.Generic;
using System.Linq;

namespace BulanikMantikOdev
{
    // 1) Üyelik fonksiyonu soyut sınıfı
    public abstract class BulanikKume
    {
        public string Ad { get; }
        protected BulanikKume(string ad) { Ad = ad; }

        // x değerinin bu kümeye üyelik derecesi (0–1)
        public abstract double UyeDerecesi(double x);
    }

    // 2) Üçgen küme
    public class UcgenKume : BulanikKume
    {
        double a, b, c;
        public UcgenKume(string ad, double a, double b, double c)
            : base(ad) { this.a = a; this.b = b; this.c = c; }

        public override double UyeDerecesi(double x)
        {
            if (x <= a || x >= c) return 0;
            if (x == b) return 1;
            if (x < b) return (x - a) / (b - a);
            else return (c - x) / (c - b);
        }
    }

    // 3) Yamuk (trapezoid) küme
    public class YamukKume : BulanikKume
    {
        double a, b, c, d;
        public YamukKume(string ad, double a, double b, double c, double d)
            : base(ad) { this.a = a; this.b = b; this.c = c; this.d = d; }

        public override double UyeDerecesi(double x)
        {
            if (x <= a || x >= d) return 0;
            if (x >= b && x <= c) return 1;
            if (x > a && x < b) return (x - a) / (b - a);
            else /* c<x<d */      return (d - x) / (d - c);
        }
    }

    // 4) Bulanık değişken: birden çok küme içerir
    public class BulanikDegisken
    {
        public string Ad { get; }
        public List<BulanikKume> Kumeler { get; } = new List<BulanikKume>();
        public BulanikDegisken(string ad) { Ad = ad; }
        public void KumeEkle(BulanikKume k) => Kumeler.Add(k);

        // belirli x için tüm kümelere ait üyelik derecelerini döner
        public Dictionary<string, double> Bulaniklastir(double x)
        {
            var dict = new Dictionary<string, double>();
            foreach (var k in Kumeler)
                dict[k.Ad] = k.UyeDerecesi(x);
            return dict;
        }
    }

    // 5) Bir bulanık kural
    public class BulanikKural
    {
        public string HassaslikEtiketi, MiktarEtiketi, KirlilikEtiketi;
        public string HizEtiketi, SureEtiketi, DeterjanEtiketi;

        public BulanikKural(
            string hEt, string mEt, string kEt,
            string hizEt, string sureEt, string detEt)
        {
            HassaslikEtiketi = hEt;
            MiktarEtiketi = mEt;
            KirlilikEtiketi = kEt;
            HizEtiketi = hizEt;
            SureEtiketi = sureEt;
            DeterjanEtiketi = detEt;
        }
    }
}

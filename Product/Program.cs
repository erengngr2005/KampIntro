using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Monster";
            urun1.UrunFiyatı = 8000;
            urun1.UrunKodu = "PC100";
            urun1.UrunStok = "50 TANE KALDI";


            Urun urun2 = new Urun();
            urun2.UrunAdi = "Casper";
            urun2.UrunFiyatı = 5000;
            urun2.UrunKodu = "PC200";
            urun2.UrunStok = "150 TANE KALDI";


            Urun urun3 = new Urun();
            urun3.UrunAdi = "Samsung";
            urun3.UrunFiyatı = 6500;
            urun3.UrunKodu = "PC300";
            urun3.UrunStok = "900 TANE KALDI";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("----------------------------------------------");

            //for döngüsüyle
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi+"     "+ urunler[i].UrunFiyatı + "     " + urunler[i].UrunKodu+ "      "+ urunler[i].UrunStok);
            }

            //foreach
            Console.WriteLine("----------------------------------------------");
            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.UrunAdi + "     "+ x.UrunFiyatı + "     "+ x.UrunKodu+"     "+ x.UrunStok  );
            }

            Console.WriteLine("----------------------------------------------");

            int eren = 0;
            while (eren < urunler.Length)
            {
                Console.WriteLine(urunler[eren].UrunAdi+"    "+urunler[eren].UrunFiyatı+"    "+ urunler[eren].UrunKodu+"     "+ urunler[eren].UrunStok);
                eren++;
            }
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public int UrunFiyatı { get; set; }
        public string UrunKodu { get; set; }
        public string UrunStok { get; set; }

    }
    }

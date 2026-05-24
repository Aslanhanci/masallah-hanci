using System;

namespace modul5_1
{    class Insan
    {
        public double Boy, Kilo;
        public string Ad;

        public Insan(string ad)
        {
            this.Ad = ad;
            this.Boy = 0.45;
            this.Kilo = 3.5;
        }

        public void Buyu()
        {
            Boy += 0.5;
            Kilo += 0.5;
        }
    }
    class Ogrenci : Insan
    {
        public Ogrenci(string ad) : base(ad) { }
        new public void Buyu()
        {
            this.Boy += 1.5;
            this.Kilo += 1.5;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci birOgrenci = new Ogrenci("Masallah Hancı");

            Console.WriteLine("Öğrencimiz {0}'un Boyu {1}, kilosu ise {2}", birOgrenci.Ad, birOgrenci.Boy, birOgrenci.Kilo);
            birOgrenci.Buyu();

            Console.WriteLine("Büyüdükten sonra Boyu: {0}, kilosu: {1}", birOgrenci.Boy, birOgrenci.Kilo);

            Console.Read();
        }
    }
}
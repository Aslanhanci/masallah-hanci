using System;

namespace Siniflar_modul8_1
{
    class Araba
    {
        public string Marka;
        public int ModelYili;

        public void BilgiVer()
        {
            Console.WriteLine("Araba: " + Marka + ", Yıl: " + ModelYili);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Araba benimArabam = new Araba();
            benimArabam.Marka = "Mercedes";
            benimArabam.ModelYili = 2024;

            benimArabam.BilgiVer();

            Console.Read();
        }
    }
}
using System;

namespace BasvuruTuruKopyalama
{
    class Bisiklet
    {
        public int hiz = 0;
        public int vites = 0;

        public Bisiklet()
        {
            vites = 18;
        }

        public void Hizlan(int artis)
        {
            hiz = hiz + artis;
        }

        public void BilgileriYaz()
        {
            Console.WriteLine("Vites: " + vites + " Hız: " + hiz);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bisiklet bisiklet1 = new Bisiklet();
            Bisiklet bisiklet2 = bisiklet1;

            bisiklet1.Hizlan(10);

            Console.WriteLine("Bisiklet 1 bilgileri:");
            bisiklet1.BilgileriYaz();

            Console.WriteLine("Bisiklet 2 bilgileri:");
            bisiklet2.BilgileriYaz();

            Console.Read();
        }
    }
}
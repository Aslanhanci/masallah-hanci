using System;

namespace Temsilciler_Ve_Olaylar_modul9_1
{
    public delegate int Islemci(int x, int y);

    class Program
    {
        static int Topla(int a, int b) { return a + b; }
        static int Cikar(int a, int b) { return a - b; }

        static void Main(string[] args)
        {
            Islemci del = new Islemci(Topla);
            Console.WriteLine("Toplama sonucu: " + del(10, 5));

            del = new Islemci(Cikar);
            Console.WriteLine("Çıkarma sonucu: " + del(10, 5));

            Console.Read();
        }
    }
}
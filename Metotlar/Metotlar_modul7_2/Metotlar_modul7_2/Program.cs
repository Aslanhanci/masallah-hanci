using System;

namespace Metotlar_modul7_2
{
    class Program
    {
        static int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc; 
        }

        static void Main(string[] args)
        {
            int toplamSonucu = Topla(15, 25); 

            Console.WriteLine("İşlemin sonucu: " + toplamSonucu);

            Console.Read();
        }
    }
}
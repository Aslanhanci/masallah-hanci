using System;
using System.IO; 

namespace Veri_Yonetimi_modul10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "notlar.txt";

            using (StreamWriter sw = new StreamWriter(dosyaYolu))
            {
                sw.WriteLine(" veritabanı okundu!");
                sw.WriteLine("Bu bir test dosyasıdır.");
            }

            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    Console.WriteLine("Okunan: " + satir);
                }
            }

            Console.Read();
        }
    }
}
using System; 

namespace modul1_1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" hoş geldin!");

            Console.Write("Lütfen adınızı girin: ");
            string ad = Console.ReadLine();

            Console.WriteLine("Memnun oldum " + ad);

            Console.Read();
        }
    }
}
using System;

namespace Temsilciler_Ve_Olaylar_modul9_2
{
    public delegate void AlarmTemsilcisi(string mesaj);

    class AlarmSistemi
    {
        public event AlarmTemsilcisi AlarmCaldi;

        public void Tetikle(string mesaj)
        {
            if (AlarmCaldi != null)
            {
                AlarmCaldi(mesaj);
            }
        }
    }

    class Program
    {
        static void AlarmMetodu(string mesaj)
        {
            Console.WriteLine("Alarm bildirimi: " + mesaj);
        }

        static void Main(string[] args)
        {
            AlarmSistemi sistem = new AlarmSistemi();

            sistem.AlarmCaldi += new AlarmTemsilcisi(AlarmMetodu);

            sistem.Tetikle("Sistem izinsiz giriş tespit etti!");

            Console.Read();
        }
    }
}
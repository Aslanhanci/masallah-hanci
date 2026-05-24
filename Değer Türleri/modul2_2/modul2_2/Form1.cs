using System;
using System.Windows.Forms;

namespace modul2_2
{
    public struct Tarih
    {
        public int gun;
        public int ay;
        public int yil;
        public Tarih(int _gun, int _ay, int _yil)
        {
            gun = _gun;
            ay = _ay;
            yil = _yil;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarih bugun = new Tarih(23, 5, 2026);
            MessageBox.Show("Tarih Bilgisi: " + bugun.gun + "." + bugun.ay + "." + bugun.yil);
        }
    }
}
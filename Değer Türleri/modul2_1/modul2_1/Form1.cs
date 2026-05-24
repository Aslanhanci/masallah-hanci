using System;
using System.Windows.Forms;

namespace modul2_1
{
    public enum Gunler
    {
        Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] gunListe = Enum.GetNames(typeof(Gunler));
            foreach (string gun in gunListe)
            {
                comboBox1.Items.Add(gun);
            }
        }
    }
}
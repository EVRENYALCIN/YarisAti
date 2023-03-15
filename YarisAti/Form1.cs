using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YarisAti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnBaslat.Click += Click;
            btnSifirla.Click += Click;
        }
        Random rnd = new Random();
        private int baslamaNoktasi = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] Atlarinlokasyonu = HareketEttir();
            int ondekiAt = Atlarinlokasyonu.Max();
            string bilgi = string.Empty;
            string sonuc = string.Empty;
            for (int i = 0; i < Atlarinlokasyonu.Length; i++)
            {
                if (ondekiAt.Equals(Atlarinlokasyonu[i]))
                {
                    bilgi = $"{i + 1}. At önde";
                    if (Atlarinlokasyonu[i] >= lblFinish.Left)
                    {
                        sonuc = $"{i + 1}. At Yarisi Kazandi";
                    }
                }
            }
            lblBilgi.Text = bilgi;
            if (!string.IsNullOrEmpty(sonuc))
            {
                timer1.Stop();
                MessageBox.Show(sonuc);
            }
        }

        private int[] HareketEttir()
        {
            pbAt1.Left += rnd.Next(1, 15);
            pbAt2.Left += rnd.Next(1, 15);
            pbAt3.Left += rnd.Next(1, 15);
            return new int[] { pbAt1.Right, pbAt2.Right, pbAt3.Right };
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            object tag = btn.Tag;
            switch (tag)
            {
                case "Baslat":
                    Baslat();
                    break;
                case "Sifirla":
                    Sifirla();
                    break;
            }
        }

        private void Baslat()
        {
            timer1.Start();
            btnBaslat.Enabled = false;
        }

        private void Sifirla()
        {
            pbAt1.Left = pbAt2.Left = pbAt3.Left = baslamaNoktasi;
            lblBilgi.Text = "Score Board";
            //lblBilgi.Text = string.Empty;
            btnBaslat.Enabled = true;
            timer1.Stop();
        }

    }
}

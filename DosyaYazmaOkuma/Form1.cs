using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaYazmaOkuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            listBox_adiSoyadi.Items.Add(txt_adiSoyadi.Text);
            listBox_bolumu.Items.Add(txt_bolumu.Text);
            listBox_babaAdi.Items.Add(txt_babaAdi.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter bilgiyaz = System.IO.File.CreateText("C:\\bilgi_kayit.dat");
            for (int i = 0; i < listBox_adiSoyadi.Items.Count; i++)
            {
                bilgiyaz.WriteLine(listBox_adiSoyadi.Items[i]);
                bilgiyaz.WriteLine(listBox_bolumu.Items[i]);
                bilgiyaz.WriteLine(listBox_babaAdi.Items[i]);        
            }
            MessageBox.Show("Bilgisiyar C klasörünün içine bilgi_kayit adında dosya kaydedildi.");
            bilgiyaz.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.IO.TextReader bilgiOku = System.IO.File.OpenText("C:\\bilgi_kayit.dat");
                string satir;
                while ((satir=bilgiOku.ReadLine())!=null)
                {
                    listBox_adiSoyadi.Items.Add(satir);
                    satir = bilgiOku.ReadLine();
                    listBox_bolumu.Items.Add(satir);
                    satir = bilgiOku.ReadLine();
                    listBox_babaAdi.Items.Add(satir);
                }
                bilgiOku.Close();
            }
            catch
            {
            }
        }
    }
}

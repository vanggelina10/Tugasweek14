using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Konversi_Click(object sender, EventArgs e)
        {
            string kalJadi = "";
            string kode = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            int selisih = kode.IndexOf(textBox3Jadi.Text.ToUpper()) - kode.IndexOf(textBox2Huruf.Text.ToUpper());
            
            for (int i = 0; i < textBox1Kalimat.Text.Length; i++)
            {
                char huruf = textBox1Kalimat.Text.ToUpper()[i];
                if (huruf == ' ')
                {
                    kalJadi += ' ';
                }
                else
                {
                    int awal = kode.IndexOf(huruf);
                    int akhir = selisih + awal;
                    if (akhir > 25)
                    {
                        akhir -= 26;
                    }
                    else if (akhir < 0)
                    {
                        akhir += 26;
                    }
                    kalJadi += kode[akhir].ToString();
                }
            }
            label5Output.Text = kalJadi;
        }
    }
}

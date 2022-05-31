using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSWORD_GENERATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string[] Buyukharf = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","R","S","T","U","V","Y","Z"};
        
        public string[] kucukharf ={"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","r","s","t","u","v","y","z"};

        public string[] sayılar = {"0","1","2","3","4","5","6","7","8","9"};

        public string[] sekiller = {".",",","!","-","_","*"};

        public List<string> sonuc = new List<string>();
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            string password = "";
            int randomsayi;
            int hane = Convert.ToInt32(hScrollBar1.Value);
            sonuc.AddRange(kucukharf);
            if (chcboxBuyuk.Checked)
            {
                sonuc.AddRange(Buyukharf); //diziye buyuksayılar ekle
            }
            if (chcboxsayi.Checked)
            {
                sonuc.AddRange(sayılar);
            }
            if (chcboxsekil.Checked)
            {
                sonuc.AddRange(sekiller);
            }
            for (int i = 0; i < hane; i++)
            {
                randomsayi=rnd.Next(0,sonuc.Count);
                password += sonuc[randomsayi];
                label3.Text = password;
            }

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = "Parola Uzunluğu : " + hScrollBar1.Value.ToString();
        }

        
    }
}

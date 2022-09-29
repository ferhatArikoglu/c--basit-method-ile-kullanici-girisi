using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admingiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //static dersek dışarıdaki şeyleri içeri dahil edemiyoruz ancak parametre ile alabiliriz;))
        static  void kullanıcıkontrol(string kadi,string sifre)
        {
            if (kadi == "1" && sifre == "1")
            {
                MessageBox.Show("giriş başarılı");
            }
            else
            {
                MessageBox.Show("yanlış şifre girdiniz");
            }
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıkontrol(txtkadi.Text, txtsifre.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0, sayac1=0;
        double dogru = 0, yanlis = 0;
        string yanliscevap = "";

        void sorular()
        {
            if (sayac==1 )
            {
                timer1.Start();
                label2.Text = "Hangisi Arupa ülkesi degildir ?";
                abtn.Text = "A) İngiltere";
                bbtn.Text = "B) Almanya";
                cbtn.Text = "C) İsviçre";
                dbtn.Text = "D) Avustralya";
                dogrucevap = dbtn.Text;
                
                
                
            }
            if (sayac == 2)
            {
                label2.Text = "Hangi ülkenin Akdeniz'e kıyısı yoktur ? ";
                abtn.Text = "A) Mısır";
                bbtn.Text = "B) Cezayir";
                cbtn.Text = "C) Fransa";
                dbtn.Text = "D) Sırbistan";
                dogrucevap = dbtn.Text;
            }
            if (sayac == 3)
            {
                label2.Text = "Dünya Güneşin kaçıncı yörüngesinde yer alır ?";
                abtn.Text = "A) 1";
                bbtn.Text = "B) 2";
                cbtn.Text = "C) 3";
                dbtn.Text = "D) 4";
                dogrucevap = cbtn.Text;
            }
            if (sayac == 4)
            {
                label2.Text = "Hangi ülkenin nüfusu daha fazladır ?";
                abtn.Text = "A) Hindistan";
                bbtn.Text = "B) Bangladeş";
                cbtn.Text = "C) ABD";
                dbtn.Text = "D) Rusya";
                dogrucevap = abtn.Text;
            }
            if (sayac == 5)
            {
                label2.Text = "Hangi ilin yıllık yağışı daha fazladır ?";
                abtn.Text = "A) Ankara";
                bbtn.Text = "B) Bitlis";
                cbtn.Text = "C) Adana";
                dbtn.Text = "D) Gaziantep";
                dogrucevap = bbtn.Text;
            }
            if (sayac == 6)
            {
                label2.Text = "Aşağıdaki uygarlıklardan hangisi yazıyı icat etmiştir ?";
                abtn.Text = "A) Hititler";
                bbtn.Text = "B) Elamlar";
                cbtn.Text = "C) Sümerler";
                dbtn.Text = "D) Babiller";
                dogrucevap = cbtn.Text;
            }
            if (sayac == 7)
            {
                label2.Text = "Hangisi ana renk değildir ?";
                abtn.Text = "A) Kırmızı";
                bbtn.Text = "B) Sarı";
                cbtn.Text = "C) Mavi";
                dbtn.Text = "D) Yeşil";
                dogrucevap = dbtn.Text;
            }
            if (sayac == 8)
            {
                label2.Text = "Varşova Paktı hangi tarihte dağılmıştır ?";
                abtn.Text = "A) 1990";
                bbtn.Text = "B) 1991";
                cbtn.Text = "C) 1992";
                dbtn.Text = "D) 1993";
                if (dogrucevap == bbtn.Text)
                {
                    bbtn.BackColor = Color.Green;
                }
               
            }
            if (sayac == 9)
            {
                label2.Text = "Apirinin ham maddesi nedir ?";
                abtn.Text = "A) Söğüt";
                bbtn.Text = "B) Kavak";
                cbtn.Text = "C) Meşe";
                dbtn.Text = "D) Köknar";
                dogrucevap = abtn.Text;
            }
            if (sayac == 10)
            {
                label2.Text = "Isının birimi nedir ?";
                abtn.Text = "A) Joule";
                bbtn.Text = "B) Kelvin";
                cbtn.Text = "C) Litre";
                dbtn.Text = "D) Kütle";
                dogrucevap = abtn.Text;
                
                
            }

        }
        private void DortButon(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }

            if ((sender as Button).Text == dogrucevap)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                dogru++;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                yanlis++;
            }

            dogrulbl.Text = "Doğru Sayısı: " + dogru;
            yanlislbl.Text = "Yanlış Sayısı: " + yanlis;
 
            if (sayac==10)
            {
                
                panel1.Visible = false;
                panel2.Visible = true;
                baslatbtn.Visible = false;
                timer1.Stop();
                MessageBox.Show("Bilgi yarışması sona erdi...");
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel2.Visible = true;
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        string dogrucevap = "";

        private void timer1_Tick(object sender, EventArgs e)
        {



            
            label3.Text = sayac1.ToString();
            sayac1++;

        }

        private void baslatbtn_Click(object sender, EventArgs e)
        {
            
            baslatbtn.Text = "Sonraki Soru ";
            sayac++;
            label1.Text = "Soru " + sayac + ":";
            
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
            sorular();
            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // global değişkenleri tanımladım. 
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            // Bir şıkka basılınca tüm şıklar pasif olsun ki kullanıcı tekrar tekrar denemesin.

            // sonraki butonunu aktifleştirelim.
            btnsonraki.Enabled = true;

            label5.Text = btna.Text; // a butonuna tıklanırsa butondaki değer label5'e yazılıyor.
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBoxGreen.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBoxRed.Visible = true;
            }
        }
        private void btnb_Click(object sender, EventArgs e)
        {
            // önce tüm şıkları pasif yapalım.
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            
            btnsonraki.Enabled = true;

            label5.Text = btnb.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBoxGreen.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBoxRed.Visible = true;
            }
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            btnsonraki.Enabled = true;

            label5.Text = btnc.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBoxGreen.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBoxRed.Visible = true;
            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            btnsonraki.Enabled = true;

            label5.Text = btnd.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                pictureBoxGreen.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlış.Text = yanlis.ToString();
                pictureBoxRed.Visible = true;
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            pictureBoxRed.Visible = false;
            pictureBoxGreen.Visible = false;

            // her sonraki butonuna basıldığında şıkları aktif yapıyoruz.
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;

            // sonraki butonunu da pasif yapıyoruz.
            btnsonraki.Enabled = false;

            soruno++; // sonraki butonuna basılınca soru no bir bir artsın.
            lblsoruno.Text = soruno.ToString(); // soruno değişkeninden gelen değeri yazdık.

            if( soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923"; // sorunun doğru cevabını tutuyor.
            }
            if(soruno==2)
            {
                richTextBox1.Text = "Hangi şehir Ege bölgesinde bulunmaz?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if(soruno==3)
            {
                btnsonraki.Text = "SONUÇLAR";
                richTextBox1.Text = "'Son Kuşlar' hangi yazarımıza aittir?";
                btna.Text = "Sait Faik Abasıyanık";
                btnb.Text = "Cemal Süreya";
                btnc.Text = "Atilla İlhan";
                btnd.Text = "Reşat Nuri Güntekin";
                label4.Text = "Sait Faik Abasıyanık";
            }
            if(soruno==4)
            {
                
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnsonraki.Enabled = false;
                MessageBox.Show("DOĞRU : " + dogru + "\n" + "YANLIŞ    : " + yanlis);
            }
        }
    }
}

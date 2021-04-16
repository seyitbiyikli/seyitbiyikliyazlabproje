using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace yazilim_gelistirme_lab_odev
{
    public partial class kelimeOyunu : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataReader dr;
        public kelimeOyunu()
        {
            InitializeComponent();
            baglanti = new MySqlConnection("Server=127.0.0.1;Database=sorudata;user=root;Pwd=1234;SslMode=none");
        }
        int toplamPuan=0,soruSayisi=0, soruPuani,saniye = 60,saniye2=20,xSayisi,araPuanSayac=0,harfSayac=0,uzunluk,dakika=3;
        void baglantiKontrol()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                button2.BackColor = Color.Green;
            }
            if (baglanti.State == ConnectionState.Closed)
            {
                button2.BackColor = Color.Red;
            }
        }
        void lblTemizle()
        {
            harf1.Text = "_";
            harf2.Text = "_";
            harf3.Text = "_";
            harf4.Text = "_";
            harf5.Text = "_";
            harf6.Text = "_";
            harf7.Text = "_";
            harf8.Text = "_";
            harf9.Text = "_";
            harf10.Text = "_";
        }
        void soruCek(string b)
        {

            id(b);
            
            int maxId = int.Parse(lblMaxId.Text);
            Random r = new Random();
            int randomSayi = r.Next(0,maxId);
            komut = new MySqlCommand("select soru,cevap from "+ b + " where id="+randomSayi,baglanti);
            komut.CommandType = CommandType.Text;
            dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblSoru.Text = dr["soru"].ToString();
                label7.Text = dr["cevap"].ToString();
            }
            soruPuaniBul();
            dr.Close();

        }

        void id(string b)
        {
            baglantiKontrol();
            komut = new MySqlCommand("select MAX(id) from " + b, baglanti);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string x = dr["max(id)"].ToString();
                int a = int.Parse(x) + 1;
                lblMaxId.Text = a.ToString();
            }
            dr.Close();
            
        }
  
        void soruPuaniBul()
        {
            string cevapUzunluk = label7.Text;
            uzunluk = cevapUzunluk.Length;
            soruPuani = uzunluk * 100;
            lblAraPuan.Text = soruPuani.ToString();
        }
        private void btnHarfAl_Click(object sender, EventArgs e)
        {
            soruPuani = soruPuani - 100;
            lblAraPuan.Text = soruPuani.ToString();
            string cevap = label7.Text;
            int m = cevap.Length;
            Random r = new Random();
            harfSayac++;
            if(harfSayac<cevap.Length)
            {
                for(int i=cevap.Length;i<cevap.Length+1;i++)
                {
                    int sayiUret = r.Next(0, m);
                    int sayiYokIse = listBox1.Items.IndexOf(sayiUret);
                    if(sayiYokIse!=-1)
                    {
                        i--;
                        continue;
                    }
                    else if(sayiYokIse==-1)
                    {
                        listBox1.Items.Add(sayiUret);
                        if (sayiUret == 0)
                        {
                            harf1.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 1)
                        {
                            harf2.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 2)
                        {
                            harf3.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 3)
                        {
                            harf4.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 4)
                        {
                            harf5.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 5)
                        {
                            harf6.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 6)
                        {
                            harf7.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 7)
                        {
                            harf8.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 8)
                        {
                            harf9.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 9)
                        {
                            harf10.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                    }
                }
            }
            if(harfSayac==m)
            {
                for (int i = m; i < m + 1; i++)
                {
                    int sayiUret = r.Next(0, m);
                    int sayiYokIse = listBox1.Items.IndexOf(sayiUret);
                    if (sayiYokIse != -1)
                    {
                        i--;
                        continue;
                    }
                    else if (sayiYokIse == -1)
                    {
                        listBox1.Items.Add(sayiUret);
                        if (sayiUret == 0)
                        {
                            harf1.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 1)
                        {
                            harf2.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 2)
                        {
                            harf3.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 3)
                        {
                            harf4.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 4)
                        {
                            harf5.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 5)
                        {
                            harf6.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 6)
                        {
                            harf7.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 7)
                        {
                            harf8.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 8)
                        {
                            harf9.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                        else if (sayiUret == 9)
                        {
                            harf10.Text = cevap[sayiUret].ToString();
                            araPuanSayac++;
                        }
                    }
                }
            }
            if(harfSayac>=m)
            {
                listBox1.Items.Clear();
                harfSayac = 0;
            }
            
        }
        void cevapKontrol(string text)
        {
            if (text == "")
            {
                harfSayac = 0;
                lblAraPuan.Text = "0";
                toplamPuan = toplamPuan + int.Parse(lblAraPuan.Text);
                lblPuan.Text = toplamPuan.ToString();
                saniye2 = 20;
            }
            else
            {

                if (label7.Text == text)
                {
                    harfSayac = 0;
                    txtCevap.Text = "";
                    toplamPuan = toplamPuan + int.Parse(lblAraPuan.Text);
                    lblPuan.Text = toplamPuan.ToString();
                    MessageBox.Show("Soruyu doğru bildiniz :)");
                }
                else
                {
                    harfSayac = 0;
                    lblAraPuan.Text = "0";
                    txtCevap.Text = "";
                    toplamPuan = toplamPuan + int.Parse(lblAraPuan.Text);
                    lblPuan.Text = toplamPuan.ToString();
                    MessageBox.Show("Yanlış cevap verdiniz :(");
                }
            }
        }
        private void btnCevapla_Click(object sender, EventArgs e)
        {
            btnSureDurdur.Enabled = true;
            btnHarfAl.Enabled = true;
            txtCevap.Enabled = false;
            btnBasla.Enabled = false;
            btnCevapla.Enabled = false;
            label11.Visible = false;
            label12.Visible = false;
            timer2.Stop();
            timer1.Start();
            if (soruSayisi == 1)
            {
                cevapKontrol(txtCevap.Text);
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "400";
                lblTemizle();

            }
            if (soruSayisi == 2)
            {
                lblAraPuan.Text = "400";
                soruCek("harf4");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                soruSayisi++;
                lblTemizle();
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "400";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 3)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf5");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                soruPuaniBul();
                soruSayisi++;
                lblTemizle();
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "500";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 4)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf5");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "500";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 5)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf6");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                harf6.Visible = true;
                lblTemizle();
                soruPuaniBul();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "600";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 6)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf6");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf6.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "600";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 7)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf7");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                lblTemizle();
                soruPuaniBul();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "700";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 8)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf7");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "700";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 9)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf8");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "800";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 10)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf8");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                soruPuaniBul();
                soruSayisi++;
                lblTemizle();
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "800";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 11)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf9");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                harf9.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "900";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 12)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf9");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                harf9.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "900";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 13)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf10");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                harf9.Visible = true;
                harf10.Visible = true;
                soruPuaniBul();
                lblTemizle();
                soruSayisi++;
                txtCevap.Text = "";
                label12.Text = "20";
                lblAraPuan.Text = "1000";
                saniye2 = 20;
                listBox1.Items.Clear();
            }
            else if (soruSayisi == 14)
            {
                cevapKontrol(txtCevap.Text);
                soruCek("harf10");
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                harf9.Visible = true;
                harf10.Visible = true;
                soruSayisi++;
                lblTemizle();
                harfSayac = 0;
                lblTemizle();
                listBox1.Items.Clear();
            }
            else if(soruSayisi==15)
            {
                cevapKontrol(txtCevap.Text);
                MessageBox.Show("Oyun bitti.Puanınız masaüstüne kaydedildi.\n Oyuncu Adı:" + lblOyuncuAd.Text +"\nPuanı:"+toplamPuan+ "\nKalan Süre:" + lblDakika.Text + ":" + lblSaniye.Text + "\nOyun Oynama Tarihi:" + DateTime.Now.ToString());
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.AppendText(saveFileDialog1.FileName);
                    sw.WriteLine("Oyuncu Adı:" + lblOyuncuAd.Text+"\nPuanı:" + toplamPuan + "\nKalan Süre:" + lblDakika.Text + ":" + lblSaniye.Text + "\nOyun Oynama Tarihi:" + DateTime.Now.ToString());
                    sw.Close();
                }
                else
                    MessageBox.Show("Dosya yolunu seçiniz!!");
            }


        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
                txtCevap.Enabled = true;
                soruSayisi++;
                timer1.Start();
                if(soruSayisi==1)
                {
                    soruCek("harf4");
                    harf1.Visible = true;
                    harf2.Visible = true;
                    harf3.Visible = true;
                    harf4.Visible = true;
                    harfSayac = 0;
                }


        }

        private void btnSureDurdur_Click(object sender, EventArgs e)
        {
            txtCevap.Enabled = true;
            btnHarfAl.Enabled = false;
            label11.Visible = true;
            label12.Visible = true;
            timer1.Stop();
            timer2.Start();
            btnCevapla.Enabled = true;
            btnSureDurdur.Enabled = false;
        }

        private void kelimeOyunu_Load(object sender, EventArgs e)
        {
            txtCevap.Enabled = false;
            label7.Visible = false;
            lblMaxId.Visible = false;
            listBox1.Visible = false;
            baglantiKontrol();
            harf1.Visible = false;
            harf2.Visible = false;
            harf3.Visible = false;
            harf4.Visible = false;
            harf5.Visible = false; 
            harf6.Visible = false;
            harf7.Visible = false;
            harf8.Visible = false;
            harf9.Visible = false;
            harf10.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            label11.Visible = false;
            label12.Visible = false;
            btnCevapla.Enabled = false;
            timer1.Interval = 1000;
            timer2.Interval = 20;
            lblDakika.Text = "04";
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            saniye2 = saniye2 - 1;
            label12.Text = saniye2.ToString();
            if(saniye2==0)
            {
                timer2.Stop();
                MessageBox.Show("Yanıtlamak için süreniz doldu.Cevapla tuşuna basıp devam ediniz.");
                soruPuani = 0;
                lblAraPuan.Text = soruPuani.ToString();
                txtCevap.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            if(saniye==0)
            {
                dakika = dakika - 1;
                lblDakika.Text = dakika.ToString();
                saniye = 60;
            }
            if(lblDakika.Text=="-1")
            {
                timer1.Stop();
                lblDakika.Text = "00";
                lblSaniye.Text = "00";
                MessageBox.Show("Süreniz bitti!!");
            }

        }
    }
}

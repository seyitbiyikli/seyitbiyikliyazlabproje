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

namespace yazilim_gelistirme_lab_odev
{
    public partial class kelimeOyunuGiris : Form
    {
        public kelimeOyunuGiris()
        {
            InitializeComponent();
        }
        public static string oyuncuAd;
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOyuncuAd.Text != "")
            {
                kelimeOyunu frm = new kelimeOyunu();
                frm.lblOyuncuAd.Text = txtOyuncuAd.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Oyuncu adını giriniz!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soruekle frm2 = new soruekle();
            frm2.Show();
        }
    }
}

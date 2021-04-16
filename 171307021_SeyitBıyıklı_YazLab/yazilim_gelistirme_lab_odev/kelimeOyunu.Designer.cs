
namespace yazilim_gelistirme_lab_odev
{
    partial class kelimeOyunu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.harf1 = new System.Windows.Forms.Label();
            this.harf2 = new System.Windows.Forms.Label();
            this.harf9 = new System.Windows.Forms.Label();
            this.harf8 = new System.Windows.Forms.Label();
            this.harf3 = new System.Windows.Forms.Label();
            this.harf10 = new System.Windows.Forms.Label();
            this.harf4 = new System.Windows.Forms.Label();
            this.harf5 = new System.Windows.Forms.Label();
            this.harf6 = new System.Windows.Forms.Label();
            this.harf7 = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnHarfAl = new System.Windows.Forms.Button();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.txtToplamSure = new System.Windows.Forms.Label();
            this.btnSureDurdur = new System.Windows.Forms.Button();
            this.lblOyuncuAd = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAraPuan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kelime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cevap:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puan:";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.Location = new System.Drawing.Point(161, 257);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(18, 20);
            this.lblPuan.TabIndex = 4;
            this.lblPuan.Text = "0";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(151, 90);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(243, 20);
            this.lblSoru.TabIndex = 5;
            this.lblSoru.Text = "__________________________";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // harf1
            // 
            this.harf1.AutoSize = true;
            this.harf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf1.Location = new System.Drawing.Point(151, 115);
            this.harf1.Name = "harf1";
            this.harf1.Size = new System.Drawing.Size(29, 31);
            this.harf1.TabIndex = 6;
            this.harf1.Text = "_";
            // 
            // harf2
            // 
            this.harf2.AutoSize = true;
            this.harf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf2.Location = new System.Drawing.Point(184, 115);
            this.harf2.Name = "harf2";
            this.harf2.Size = new System.Drawing.Size(29, 31);
            this.harf2.TabIndex = 7;
            this.harf2.Text = "_";
            // 
            // harf9
            // 
            this.harf9.AutoSize = true;
            this.harf9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf9.Location = new System.Drawing.Point(429, 115);
            this.harf9.Name = "harf9";
            this.harf9.Size = new System.Drawing.Size(29, 31);
            this.harf9.TabIndex = 8;
            this.harf9.Text = "_";
            // 
            // harf8
            // 
            this.harf8.AutoSize = true;
            this.harf8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf8.Location = new System.Drawing.Point(394, 115);
            this.harf8.Name = "harf8";
            this.harf8.Size = new System.Drawing.Size(29, 31);
            this.harf8.TabIndex = 9;
            this.harf8.Text = "_";
            // 
            // harf3
            // 
            this.harf3.AutoSize = true;
            this.harf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf3.Location = new System.Drawing.Point(219, 115);
            this.harf3.Name = "harf3";
            this.harf3.Size = new System.Drawing.Size(29, 31);
            this.harf3.TabIndex = 10;
            this.harf3.Text = "_";
            // 
            // harf10
            // 
            this.harf10.AutoSize = true;
            this.harf10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf10.Location = new System.Drawing.Point(464, 115);
            this.harf10.Name = "harf10";
            this.harf10.Size = new System.Drawing.Size(29, 31);
            this.harf10.TabIndex = 11;
            this.harf10.Text = "_";
            // 
            // harf4
            // 
            this.harf4.AutoSize = true;
            this.harf4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf4.Location = new System.Drawing.Point(254, 115);
            this.harf4.Name = "harf4";
            this.harf4.Size = new System.Drawing.Size(29, 31);
            this.harf4.TabIndex = 12;
            this.harf4.Text = "_";
            // 
            // harf5
            // 
            this.harf5.AutoSize = true;
            this.harf5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf5.Location = new System.Drawing.Point(289, 115);
            this.harf5.Name = "harf5";
            this.harf5.Size = new System.Drawing.Size(29, 31);
            this.harf5.TabIndex = 13;
            this.harf5.Text = "_";
            // 
            // harf6
            // 
            this.harf6.AutoSize = true;
            this.harf6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf6.Location = new System.Drawing.Point(324, 115);
            this.harf6.Name = "harf6";
            this.harf6.Size = new System.Drawing.Size(29, 31);
            this.harf6.TabIndex = 14;
            this.harf6.Text = "_";
            // 
            // harf7
            // 
            this.harf7.AutoSize = true;
            this.harf7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harf7.Location = new System.Drawing.Point(359, 115);
            this.harf7.Name = "harf7";
            this.harf7.Size = new System.Drawing.Size(29, 31);
            this.harf7.TabIndex = 15;
            this.harf7.Text = "_";
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(156, 171);
            this.txtCevap.Multiline = true;
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(204, 21);
            this.txtCevap.TabIndex = 16;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(58, 297);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(125, 36);
            this.btnBasla.TabIndex = 17;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnHarfAl
            // 
            this.btnHarfAl.Location = new System.Drawing.Point(189, 297);
            this.btnHarfAl.Name = "btnHarfAl";
            this.btnHarfAl.Size = new System.Drawing.Size(125, 36);
            this.btnHarfAl.TabIndex = 18;
            this.btnHarfAl.Text = "HARF AL";
            this.btnHarfAl.UseVisualStyleBackColor = true;
            this.btnHarfAl.Click += new System.EventHandler(this.btnHarfAl_Click);
            // 
            // btnCevapla
            // 
            this.btnCevapla.Location = new System.Drawing.Point(451, 297);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(125, 36);
            this.btnCevapla.TabIndex = 19;
            this.btnCevapla.Text = "CEVAPLA";
            this.btnCevapla.UseVisualStyleBackColor = true;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // txtToplamSure
            // 
            this.txtToplamSure.AutoSize = true;
            this.txtToplamSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamSure.Location = new System.Drawing.Point(82, 58);
            this.txtToplamSure.Name = "txtToplamSure";
            this.txtToplamSure.Size = new System.Drawing.Size(47, 20);
            this.txtToplamSure.TabIndex = 20;
            this.txtToplamSure.Text = "Süre:";
            // 
            // btnSureDurdur
            // 
            this.btnSureDurdur.Location = new System.Drawing.Point(320, 297);
            this.btnSureDurdur.Name = "btnSureDurdur";
            this.btnSureDurdur.Size = new System.Drawing.Size(125, 36);
            this.btnSureDurdur.TabIndex = 21;
            this.btnSureDurdur.Text = "SÜRE DURDUR";
            this.btnSureDurdur.UseVisualStyleBackColor = true;
            this.btnSureDurdur.Click += new System.EventHandler(this.btnSureDurdur_Click);
            // 
            // lblOyuncuAd
            // 
            this.lblOyuncuAd.AutoSize = true;
            this.lblOyuncuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyuncuAd.Location = new System.Drawing.Point(166, 24);
            this.lblOyuncuAd.Name = "lblOyuncuAd";
            this.lblOyuncuAd.Size = new System.Drawing.Size(24, 20);
            this.lblOyuncuAd.TabIndex = 22;
            this.lblOyuncuAd.Text = "---";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(73, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Oyuncu:";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDakika.Location = new System.Drawing.Point(151, 58);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(27, 20);
            this.lblDakika.TabIndex = 24;
            this.lblDakika.Text = "04";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(176, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = ":";
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaniye.Location = new System.Drawing.Point(185, 58);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(27, 20);
            this.lblSaniye.TabIndex = 26;
            this.lblSaniye.Text = "00";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(707, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Bağlantı Durumu:";
            // 
            // lblMaxId
            // 
            this.lblMaxId.AutoSize = true;
            this.lblMaxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblMaxId.Location = new System.Drawing.Point(74, 382);
            this.lblMaxId.Name = "lblMaxId";
            this.lblMaxId.Size = new System.Drawing.Size(35, 13);
            this.lblMaxId.TabIndex = 29;
            this.lblMaxId.Text = "maxId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(122, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cevap";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(871, 493);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 4);
            this.listBox1.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(50, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Soru puanı:";
            // 
            // lblAraPuan
            // 
            this.lblAraPuan.AutoSize = true;
            this.lblAraPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraPuan.Location = new System.Drawing.Point(156, 211);
            this.lblAraPuan.Name = "lblAraPuan";
            this.lblAraPuan.Size = new System.Drawing.Size(18, 20);
            this.lblAraPuan.TabIndex = 35;
            this.lblAraPuan.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(316, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cevap Süresi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(418, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(366, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Boş bırakılan cevaplar otomatik 0 puan olarak alınır.";
            // 
            // kelimeOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(881, 496);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblAraPuan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMaxId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblOyuncuAd);
            this.Controls.Add(this.btnSureDurdur);
            this.Controls.Add(this.txtToplamSure);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.btnHarfAl);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.harf7);
            this.Controls.Add(this.harf6);
            this.Controls.Add(this.harf5);
            this.Controls.Add(this.harf4);
            this.Controls.Add(this.harf10);
            this.Controls.Add(this.harf3);
            this.Controls.Add(this.harf8);
            this.Controls.Add(this.harf9);
            this.Controls.Add(this.harf2);
            this.Controls.Add(this.harf1);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "kelimeOyunu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.kelimeOyunu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label harf1;
        private System.Windows.Forms.Label harf2;
        private System.Windows.Forms.Label harf9;
        private System.Windows.Forms.Label harf8;
        private System.Windows.Forms.Label harf3;
        private System.Windows.Forms.Label harf10;
        private System.Windows.Forms.Label harf4;
        private System.Windows.Forms.Label harf5;
        private System.Windows.Forms.Label harf6;
        private System.Windows.Forms.Label harf7;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnHarfAl;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.Label txtToplamSure;
        private System.Windows.Forms.Button btnSureDurdur;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblOyuncuAd;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAraPuan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


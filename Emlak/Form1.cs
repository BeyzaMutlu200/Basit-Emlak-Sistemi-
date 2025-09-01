using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Home
        {
            public string semt, islem;//islem aktiflik(müşteri var yok ) durumu için kullanılacak
            public double alan, kira_depozito, satilik_fiyat;
            public int oda_Sayisi, kat_Sayisi;
            public DateTime yapim_Tarih;

            public Guid emlak_No;
            public enum evTür
            {
                Daire = 0,
                Bahçeli = 1,
                Dubleks = 2,
                Mustakil = 3
            }

             ;

            public Home(string semt, string islem, double alan, double kira_depozito, double satilik_fiyat, int oda_Sayisi, int kat_Sayisi, DateTime yapim_Tarih, Guid emlak_No, evTür evtür)

            {
                this.semt = semt;
                this.islem = islem;
                this.alan = alan;
                this.kira_depozito = kira_depozito;
                this.satilik_fiyat = satilik_fiyat;
                this.oda_Sayisi = oda_Sayisi;
                this.kat_Sayisi = kat_Sayisi;
                this.yapim_Tarih = yapim_Tarih;
                this.emlak_No = emlak_No;
                //this.evtür = evtür; //nenden yanlış anlamadım????
            }
            public string Semt
            {
                get
                {
                    return semt;
                }
                set
                {
                    semt = value;
                }
            }
            public string Islem
            {
                
                get
                {
                    return islem;
                }
                set
                {
                    islem = value;
                }
            }
            public double Alan
            {
                
                get
                {
                    return alan;
                }
                set
                {
                    try
                    {
                        alan = value;
                       if(value==0 && value < 0)
                        {
                            throw new ArgumentException(" Hatalı alan bilgi girişi");
                        }

                    }
                    catch (ArgumentException e)

                    {
                        MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                }
            }
            public double Kira_Depo
            {
                get
                {
                    return kira_depozito;
                }
                set
                {
                    kira_depozito = value;
                    try
                    {
                        if(value<0)
                        {

                            throw new ArgumentException("Lütfen geçerli bir depozito girişi yapınız");
                        }

                    }
                    catch (ArgumentException e)

                    {
                        MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            public double Satilik_Fiyat
            {
                get => satilik_fiyat;
                set => satilik_fiyat = value;


                   
            }
            public DateTime Yapim_Tarih
            {
                get => yapim_Tarih;
                set => yapim_Tarih = value;
            }
            public int Oda_Sayisi
            {
                get => oda_Sayisi;
                set => oda_Sayisi = value;
            }
            public int Kat_Sayisi
            {
                get => kat_Sayisi;
                set => kat_Sayisi = value;
            }
            public Guid Emlak_No
            {
                get => emlak_No;
                set => emlak_No = value;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayitOl f2 = new kayitOl();
            f2.ShowDialog();
        }
    }
}

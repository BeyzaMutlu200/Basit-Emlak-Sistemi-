using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace Emlak
{
    public partial class kayitOl : Form
    {
        public List<TextBox> textBoxList;
        public kayitOl()
        {
            InitializeComponent();
            textBoxList = new List<TextBox>();

            // Tasarım arayüzü üzerinden eklenen TextBox'ları List'e ekle
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    textBoxList.Add((TextBox)control);
                }
            }
        }

        public void kayitOl_Load(object sender, EventArgs e)
        {
            kayit IN = new kayit("", "", "", "");

            // Her bir TextBox'ın içeriğini topla
            IN.Name_sname = textBox1.Text;
            IN.Email = textBox2.Text;
            IN.Telno = textBox3.Text;

            IN.Sifre = textBox4.Text;
        
            // Toplanan verileri SaveToFile metoduna geçir
            var result = true;
            if (result)
            {
                try
                {
                    // Her bir TextBox için kontrolü gerçekleştir
                    foreach (var textBox in textBoxList)
                    {
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            throw new ArgumentException("doldurlmayan alan/alanlar mevcut !");
                        }

                        // Diğer işlemleri buraya ekleyebilirsiniz
                        Console.WriteLine("Girilen Metin: " + textBox.Text);

                    }
                    if (string.IsNullOrWhiteSpace(label6.Text) || !label6.Text.ToLower().EndsWith(".pdf"))
                    {
                        throw new ArgumentException("Geçerli bir PDF dosyası seçilmelidir!");
                    }
                  
                }
                catch (ArgumentException ex)
                {
                    // TextBox boşsa burası çalışır
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //pdfdosyayolu için nasıl ekleme yapabilrim exception hatasını ?
            }
            //     MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleştirildi ", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); 
            // ekleyince throw mesajından sonra doğru 
        }

    }

    class kayit
    {
        public string name_sname;
        public string email;
        public string telno;
        public string sifre;

        public kayit(string name_sname, string email, string telno, string sifre)
        {
            this.name_sname = name_sname;
            this.email = email;
            this.telno = telno;
            this.sifre = sifre;
        }

        public string Name_sname
        {
            get
            {
                return name_sname;
            }
            set
            {
                name_sname = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Telno
        {
            get
            {
                return telno;
            }
            set
            {
                telno = value;
            }
        }

        public string Sifre
        {
            get
            {
                return sifre;
            }
            set
            {
                sifre = value;

            }
        }






    }





}

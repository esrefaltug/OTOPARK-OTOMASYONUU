using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOPARK_OTOMASYONUU
{
    public partial class Form1 : Form
    {
        Otopark myOtopark = null;
        public Form1()
        {
            InitializeComponent();
        }
        //Tüm içerik tarafından erişilmesi istenen nesneler ya da değişkenler global biçimde tanımlanmalıdır.
        private void btncreateotapark_Click(object sender, EventArgs e)
        {
            string OtoparkAdı = txtotoparkadı.Text;
            int Kapasite = Int32.Parse(txtkapasite.Text);

             myOtopark = new Otopark(OtoparkAdı, Kapasite);
            MessageBox.Show("Otopark Oluşturuldu");
            btncreateotapark.Enabled = false;
            txtotoparkadı.Enabled = false;
            txtkapasite.Enabled = false;
        }

        public void btntstgrs_Click(object sender, EventArgs e)
        {
            int kapasitekalan = myOtopark.KapasiteSorgula();
            if(kapasitekalan > 0)
            {
                bool indirimliMİ = checkBox1.Checked;
                myOtopark.AracGiris(indirimliMİ);
                MessageBox.Show("Araç Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Otopark DOLU");
            }

            //sınıf içerisinde metot yazmamız lazım
            //taşıt giriş işlemini yapsın

            //metot çağrılacak -->Otomobil mi?
            
            

            //Nesneadı.metot()
            //1-Otomobil mi? indirimli mi?
            //2-Kapasite--
            //3-para ++
            //Bulunan Araçsayısı++
        }

        private void btntstcks_Click(object sender, EventArgs e)
        {
            if (myOtopark.BulunanAraçSayısıSorgula()>0)
            {
                myOtopark.AracCikis();
                MessageBox.Show("Araç Çıkış Başarılı");
            }
            else
            {
                MessageBox.Show("Haatalı Veri girişi-Otoparkta Araç yok");
            }
        }

        private void btnkzncsorgla_Click(object sender, EventArgs e)
        {
            int ToplamPara = myOtopark.KazançSorgula();
            MessageBox.Show("Kazanç:" + ToplamPara);
        }

        private void btnotprkyersorgula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otopark Kapasite: " + myOtopark.KapasiteSorgula());
        }
    }
}

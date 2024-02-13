using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayıtSistemi
{
    public partial class formAnaSayfa : Form
    {
        public formAnaSayfa()
        {
            InitializeComponent();
        }

        //Öğrenci ekle butonuna tıklandığı zaman olacak olaylar:
        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            //öğrenci ekle formundan bir nesne üretiyoruz.
            formOgrEkle ogrEkle = new formOgrEkle();
            //Bu formu, yani anasayfayı kapatıyoruz.
            this.Hide();
            //Öğrenci ekle formunu açıyoruz:
            ogrEkle.Show();
        }


        //Öğrenci listele butonuna tıklandığı zaman olacak olaylar:
        private void btnOgrListele_Click(object sender, EventArgs e)
        {
            //öğrenci listele formundan bir nesne üretiyoruz.
            formOgrListele ogrListele = new formOgrListele();
            //Bu formu, yani anasayfayı kapatıyoruz.
            this.Hide();
            //Öğrenci listele formunu açıyoruz:
            ogrListele.Show();
        }


        //Öğrenci sil butonuna tıklandığı zaman olacak olaylar:
        private void btnOgrSilme_Click(object sender, EventArgs e)
        {
            //öğrenci sil formundan bir nesne üretiyoruz.
            formOgrSil ogrSil = new formOgrSil();
            //Bu formu, yani anasayfayı kapatıyoruz.
            this.Hide();
            //Öğrenci sil formunu açıyoruz:
            ogrSil.Show();
        }

        //Öğrenci düzenle butonuna tıklandığı zaman olacak olaylar:
        private void btnOgrDuzenle_Click(object sender, EventArgs e)
        {
            //öğrenci duzenle formundan bir nesne üretiyoruz.
            formOgrDuzenle ogrDuzenle = new formOgrDuzenle();
            //Bu formu, yani anasayfayı kapatıyoruz.
            this.Hide();
            //Öğrenci duzenle formunu açıyoruz:
            ogrDuzenle.Show();
        }
    }
}

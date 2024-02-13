using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayıtSistemi
{
    public partial class formOgrEkle : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-ES8AIES\SQLEXPRESS;Initial Catalog=OgrenciSistemi;Integrated Security=True");
        public formOgrEkle()
        {
            InitializeComponent();
        }

        //Sql bağlantısını açmak için fonksiyon:
        public void BaglantiAc()
        {
            sqlConnection.Open();
        }

        //Sql bağlantısını kapatmak için fonksiyon:
        public void BaglantiKapat()
        {
            sqlConnection.Close();
        }

        //Ekleme işlemi yaptıktan sonra alanları temizlemek için:
        public void Temizle()
        {
            txtOgrAd.Text = "";
            txtOgrSoyad.Text = "";
            txtOgrNo.Text = "";
        }
        //verilerin eklenip eklenmediğini kontrol etmek için kullanacağımız değişken:
        public int ekle;

        //Öğrenci ekleme fonksiyonu:
        public void OgrEkle()
        {
            //Herhangi bir hata olması durumunda programın sonlandırılmaması için bu işlemleri
            //kontrollü yapmak amacıyla try catch blokları arasında yapıyoruz.
            try
            {
                //Bağlantıyı açtık:
                BaglantiAc();
                //Veri tabanına veri ekleyecek olan komutu oluşturuyoruz:
                string veriEkle = "INSERT INTO OgrenciBilgileri(OgrAd,OgrSoyad,OgrNo) VALUES (@ad,@soyad,@numara)";
                //Komutu SqlCommand nesnesi için kullanıyoruz:
                SqlCommand Ekle = new SqlCommand(veriEkle,sqlConnection);
                //Daha sonra verileri tek tek ekliyoruz:
                Ekle.Parameters.AddWithValue("@ad", txtOgrAd.Text);
                Ekle.Parameters.AddWithValue("@soyad", txtOgrSoyad.Text);
                Ekle.Parameters.AddWithValue("@numara", Convert.ToInt32(txtOgrNo.Text));
                //Verilerin veri tabanı üzerinde eklenmesi için bu komutu yazıyoruz:
                ekle = Ekle.ExecuteNonQuery();
                //NOT: Veriler eklenirse bu komut geriye 1 değerini, eklenmezse 0 değerini döndürür.
                //Verilerin eklenip eklenmediğini anlayabilmek için bu değerin 1 olup olmadığını daha sonra kontrol ederek
                //kullanıcıya bildireceğiz.

                //Bağlantıyı kapatıyoruz:
                BaglantiKapat();
            }
            catch (Exception ex)
            {
                //Eğer bir hata alınırsa bu hata kullanıcıya bildirilecek:
                MessageBox.Show(ex.Message);
            }
            
        }


        //geri butonuna basıldığında olacak olaylar:
        private void btnGeri_Click(object sender, EventArgs e)
        {
            //ana sayfa formundan yeni bir nesne üretiyoruz:
            formAnaSayfa anaSayfa = new formAnaSayfa();
            //bu formu yani öğrenci ekle formunu kapatıyoruz.
            this.Hide();
            //ana sayfa formunu açıyoruz:
            anaSayfa.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Veri ekleme fonksiyonunu çalıştırdık:
            OgrEkle();
            //eğer veriler eklenmişse, yani ekle değişkeninin değeri 1 olmuşsa:
            if(ekle > 0)
            {
                MessageBox.Show("Öğrenci Bilgileri Başarılı Bir Şekilde Kaydedilmiştir.");
            }
            //Alanları temizleyelim:
            Temizle();
        }
    }
}

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
    public partial class formOgrListele : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-ES8AIES\SQLEXPRESS;Initial Catalog=OgrenciSistemi;Integrated Security=True");
        //Veri tablosu oluşturma:
        DataTable dt = new DataTable();
        public formOgrListele()
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

        //Verileri listelemek için fonksiyon:
        public void Listele()
        {
            try
            {
                BaglantiAc();
                //verileri getirme komutu:
                string veriGetir = "SELECT * FROM OgrenciBilgileri";
                //komutun oluşturulması:
                SqlCommand Listele = new SqlCommand(veriGetir, sqlConnection);
                //Komutun çalıştırılır veri okuma nesnesine aktarılması:
                SqlDataReader dr = Listele.ExecuteReader();
                //Verinin okunup veri tablosuna aktarılması:
                dt.Load(dr);
                //Datagridwiev in veri kaynağına bu veri tablosunun aktarılması:
                dgwOgrenciler.DataSource = dt;
                BaglantiKapat();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Gridwiev üzerinden seçilen verilerin textboxlara gelmesi için fonksiyon:
        public void BilgileriGetir()
        {
            try
            {
                txtID.Text = dgwOgrenciler.SelectedRows[0].Cells[0].Value.ToString();
                txtOgrAd.Text = dgwOgrenciler.SelectedRows[0].Cells[2].Value.ToString();
                txtOgrSoyad.Text = dgwOgrenciler.SelectedRows[0].Cells[3].Value.ToString();
                txtOgrNo.Text = dgwOgrenciler.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Tüm satırın seçili olduğundan emin olun!");
            }
        }

        //geri butonuna basıldığında olacak olaylar:
        private void btnGeri_Click(object sender, EventArgs e)
        {
            //ana sayfa formundan yeni bir nesne üretiyoruz:
            formAnaSayfa anaSayfa = new formAnaSayfa();
            //bu formu yani öğrenci listele formunu kapatıyoruz.
            this.Hide();
            //ana sayfa formunu açıyoruz:
            anaSayfa.Show();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgwOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BilgileriGetir();
        }
    }
}

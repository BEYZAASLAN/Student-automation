
namespace OgrenciKayıtSistemi
{
    partial class formAnaSayfa
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
            this.lblAnaSayfaBaslik = new System.Windows.Forms.Label();
            this.panelAnaSayfa = new System.Windows.Forms.Panel();
            this.btnOgrEkle = new System.Windows.Forms.Button();
            this.btnOgrSilme = new System.Windows.Forms.Button();
            this.btnOgrListele = new System.Windows.Forms.Button();
            this.btnOgrDuzenle = new System.Windows.Forms.Button();
            this.panelAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnaSayfaBaslik
            // 
            this.lblAnaSayfaBaslik.AutoSize = true;
            this.lblAnaSayfaBaslik.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaSayfaBaslik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAnaSayfaBaslik.Location = new System.Drawing.Point(14, 27);
            this.lblAnaSayfaBaslik.Name = "lblAnaSayfaBaslik";
            this.lblAnaSayfaBaslik.Size = new System.Drawing.Size(222, 69);
            this.lblAnaSayfaBaslik.TabIndex = 0;
            this.lblAnaSayfaBaslik.Text = "Ana Sayfa";
            // 
            // panelAnaSayfa
            // 
            this.panelAnaSayfa.BackColor = System.Drawing.Color.DarkGreen;
            this.panelAnaSayfa.Controls.Add(this.lblAnaSayfaBaslik);
            this.panelAnaSayfa.Location = new System.Drawing.Point(-2, -8);
            this.panelAnaSayfa.Name = "panelAnaSayfa";
            this.panelAnaSayfa.Size = new System.Drawing.Size(451, 121);
            this.panelAnaSayfa.TabIndex = 1;
            // 
            // btnOgrEkle
            // 
            this.btnOgrEkle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOgrEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOgrEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrEkle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrEkle.Location = new System.Drawing.Point(60, 177);
            this.btnOgrEkle.Name = "btnOgrEkle";
            this.btnOgrEkle.Size = new System.Drawing.Size(137, 103);
            this.btnOgrEkle.TabIndex = 2;
            this.btnOgrEkle.Text = "Öğrenci Ekle";
            this.btnOgrEkle.UseVisualStyleBackColor = false;
            this.btnOgrEkle.Click += new System.EventHandler(this.btnOgrEkle_Click);
            // 
            // btnOgrSilme
            // 
            this.btnOgrSilme.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOgrSilme.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOgrSilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrSilme.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrSilme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrSilme.Location = new System.Drawing.Point(60, 315);
            this.btnOgrSilme.Name = "btnOgrSilme";
            this.btnOgrSilme.Size = new System.Drawing.Size(137, 103);
            this.btnOgrSilme.TabIndex = 3;
            this.btnOgrSilme.Text = "Öğrenci Sil";
            this.btnOgrSilme.UseVisualStyleBackColor = false;
            this.btnOgrSilme.Click += new System.EventHandler(this.btnOgrSilme_Click);
            // 
            // btnOgrListele
            // 
            this.btnOgrListele.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOgrListele.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOgrListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrListele.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrListele.Location = new System.Drawing.Point(254, 177);
            this.btnOgrListele.Name = "btnOgrListele";
            this.btnOgrListele.Size = new System.Drawing.Size(137, 103);
            this.btnOgrListele.TabIndex = 4;
            this.btnOgrListele.Text = "Öğrencileri Listele";
            this.btnOgrListele.UseVisualStyleBackColor = false;
            this.btnOgrListele.Click += new System.EventHandler(this.btnOgrListele_Click);
            // 
            // btnOgrDuzenle
            // 
            this.btnOgrDuzenle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnOgrDuzenle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOgrDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrDuzenle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrDuzenle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrDuzenle.Location = new System.Drawing.Point(254, 315);
            this.btnOgrDuzenle.Name = "btnOgrDuzenle";
            this.btnOgrDuzenle.Size = new System.Drawing.Size(137, 103);
            this.btnOgrDuzenle.TabIndex = 5;
            this.btnOgrDuzenle.Text = "Öğrenci Kayıtlarını Düzenle";
            this.btnOgrDuzenle.UseVisualStyleBackColor = false;
            this.btnOgrDuzenle.Click += new System.EventHandler(this.btnOgrDuzenle_Click);
            // 
            // formAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(447, 456);
            this.Controls.Add(this.btnOgrDuzenle);
            this.Controls.Add(this.btnOgrListele);
            this.Controls.Add(this.btnOgrSilme);
            this.Controls.Add(this.btnOgrEkle);
            this.Controls.Add(this.panelAnaSayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panelAnaSayfa.ResumeLayout(false);
            this.panelAnaSayfa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAnaSayfaBaslik;
        private System.Windows.Forms.Panel panelAnaSayfa;
        private System.Windows.Forms.Button btnOgrEkle;
        private System.Windows.Forms.Button btnOgrSilme;
        private System.Windows.Forms.Button btnOgrListele;
        private System.Windows.Forms.Button btnOgrDuzenle;
    }
}


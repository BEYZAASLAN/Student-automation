
namespace OgrenciKayıtSistemi
{
    partial class formOgrDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLine = new System.Windows.Forms.Panel();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrBilgileri = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.panelDuzenleme = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblOgrDuzenleBaslik = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.panelDuzenleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.SystemColors.Control;
            this.panelLine.Location = new System.Drawing.Point(500, 177);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(243, 2);
            this.panelLine.TabIndex = 29;
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrAd.Location = new System.Drawing.Point(536, 256);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(54, 29);
            this.lblOgrAd.TabIndex = 28;
            this.lblOgrAd.Text = "İsim:";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(607, 379);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(128, 22);
            this.txtOgrNo.TabIndex = 27;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(607, 321);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(128, 22);
            this.txtOgrSoyad.TabIndex = 26;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(607, 261);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(128, 22);
            this.txtOgrAd.TabIndex = 25;
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrNo.Location = new System.Drawing.Point(505, 374);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(85, 29);
            this.lblOgrNo.TabIndex = 24;
            this.lblOgrNo.Text = "Numara:";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyad.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrSoyad.Location = new System.Drawing.Point(508, 316);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(82, 29);
            this.lblOgrSoyad.TabIndex = 23;
            this.lblOgrSoyad.Text = "Soyisim:";
            // 
            // lblOgrBilgileri
            // 
            this.lblOgrBilgileri.AutoSize = true;
            this.lblOgrBilgileri.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrBilgileri.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrBilgileri.Location = new System.Drawing.Point(524, 129);
            this.lblOgrBilgileri.Name = "lblOgrBilgileri";
            this.lblOgrBilgileri.Size = new System.Drawing.Size(203, 40);
            this.lblOgrBilgileri.TabIndex = 22;
            this.lblOgrBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.DarkGreen;
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListele.Location = new System.Drawing.Point(12, 120);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 41);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.BackgroundColor = System.Drawing.Color.Beige;
            this.dgwOgrenciler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(12, 174);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.RowHeadersWidth = 51;
            this.dgwOgrenciler.RowTemplate.Height = 24;
            this.dgwOgrenciler.Size = new System.Drawing.Size(461, 315);
            this.dgwOgrenciler.TabIndex = 20;
            // 
            // panelDuzenleme
            // 
            this.panelDuzenleme.BackColor = System.Drawing.Color.DarkGreen;
            this.panelDuzenleme.Controls.Add(this.btnGeri);
            this.panelDuzenleme.Controls.Add(this.lblOgrDuzenleBaslik);
            this.panelDuzenleme.Location = new System.Drawing.Point(-2, -8);
            this.panelDuzenleme.Name = "panelDuzenleme";
            this.panelDuzenleme.Size = new System.Drawing.Size(766, 121);
            this.panelDuzenleme.TabIndex = 30;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGeri.Location = new System.Drawing.Point(636, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(109, 39);
            this.btnGeri.TabIndex = 33;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblOgrDuzenleBaslik
            // 
            this.lblOgrDuzenleBaslik.AutoSize = true;
            this.lblOgrDuzenleBaslik.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrDuzenleBaslik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOgrDuzenleBaslik.Location = new System.Drawing.Point(14, 27);
            this.lblOgrDuzenleBaslik.Name = "lblOgrDuzenleBaslik";
            this.lblOgrDuzenleBaslik.Size = new System.Drawing.Size(348, 69);
            this.lblOgrDuzenleBaslik.TabIndex = 0;
            this.lblOgrDuzenleBaslik.Text = "Öğrenci Düzenle";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDuzenle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDuzenle.Location = new System.Drawing.Point(182, 120);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(109, 41);
            this.btnDuzenle.TabIndex = 31;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkGreen;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKaydet.Location = new System.Drawing.Point(626, 430);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 46);
            this.btnKaydet.TabIndex = 32;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblID.Location = new System.Drawing.Point(552, 194);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 29);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(607, 199);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(128, 22);
            this.txtID.TabIndex = 33;
            // 
            // formOgrDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(758, 506);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.panelDuzenleme);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.lblOgrAd);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.lblOgrNo);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.lblOgrBilgileri);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgwOgrenciler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formOgrDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.panelDuzenleme.ResumeLayout(false);
            this.panelDuzenleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrBilgileri;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Panel panelDuzenleme;
        private System.Windows.Forms.Label lblOgrDuzenleBaslik;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}
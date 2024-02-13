
namespace OgrenciKayıtSistemi
{
    partial class formOgrListele
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
            this.lblOgrListeleBaslik = new System.Windows.Forms.Label();
            this.panelListeleme = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblOgrBilgileri = new System.Windows.Forms.Label();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panelListeleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrListeleBaslik
            // 
            this.lblOgrListeleBaslik.AutoSize = true;
            this.lblOgrListeleBaslik.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrListeleBaslik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOgrListeleBaslik.Location = new System.Drawing.Point(14, 27);
            this.lblOgrListeleBaslik.Name = "lblOgrListeleBaslik";
            this.lblOgrListeleBaslik.Size = new System.Drawing.Size(321, 69);
            this.lblOgrListeleBaslik.TabIndex = 0;
            this.lblOgrListeleBaslik.Text = "Öğrenci Listele";
            // 
            // panelListeleme
            // 
            this.panelListeleme.BackColor = System.Drawing.Color.DarkGreen;
            this.panelListeleme.Controls.Add(this.btnGeri);
            this.panelListeleme.Controls.Add(this.lblOgrListeleBaslik);
            this.panelListeleme.Location = new System.Drawing.Point(-2, -8);
            this.panelListeleme.Name = "panelListeleme";
            this.panelListeleme.Size = new System.Drawing.Size(734, 121);
            this.panelListeleme.TabIndex = 3;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGeri.Location = new System.Drawing.Point(609, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(109, 39);
            this.btnGeri.TabIndex = 35;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.BackgroundColor = System.Drawing.Color.Beige;
            this.dgwOgrenciler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(12, 175);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.RowHeadersWidth = 51;
            this.dgwOgrenciler.RowTemplate.Height = 24;
            this.dgwOgrenciler.Size = new System.Drawing.Size(461, 315);
            this.dgwOgrenciler.TabIndex = 4;
            this.dgwOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrenciler_CellClick);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.DarkGreen;
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListele.Location = new System.Drawing.Point(12, 123);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 41);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblOgrBilgileri
            // 
            this.lblOgrBilgileri.AutoSize = true;
            this.lblOgrBilgileri.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrBilgileri.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrBilgileri.Location = new System.Drawing.Point(503, 127);
            this.lblOgrBilgileri.Name = "lblOgrBilgileri";
            this.lblOgrBilgileri.Size = new System.Drawing.Size(203, 40);
            this.lblOgrBilgileri.TabIndex = 11;
            this.lblOgrBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(586, 379);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(128, 22);
            this.txtOgrNo.TabIndex = 17;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(586, 321);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(128, 22);
            this.txtOgrSoyad.TabIndex = 16;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(586, 261);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(128, 22);
            this.txtOgrAd.TabIndex = 15;
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrNo.Location = new System.Drawing.Point(484, 374);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(85, 29);
            this.lblOgrNo.TabIndex = 14;
            this.lblOgrNo.Text = "Numara:";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyad.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrSoyad.Location = new System.Drawing.Point(487, 316);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(82, 29);
            this.lblOgrSoyad.TabIndex = 13;
            this.lblOgrSoyad.Text = "Soyisim:";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrAd.Location = new System.Drawing.Point(515, 256);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(54, 29);
            this.lblOgrAd.TabIndex = 18;
            this.lblOgrAd.Text = "İsim:";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.SystemColors.Control;
            this.panelLine.Location = new System.Drawing.Point(479, 175);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(243, 2);
            this.panelLine.TabIndex = 19;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblID.Location = new System.Drawing.Point(531, 199);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 29);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(586, 204);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(128, 22);
            this.txtID.TabIndex = 35;
            // 
            // formOgrListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(728, 502);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
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
            this.Controls.Add(this.panelListeleme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formOgrListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listeleme";
            this.panelListeleme.ResumeLayout(false);
            this.panelListeleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrListeleBaslik;
        private System.Windows.Forms.Panel panelListeleme;
        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblOgrBilgileri;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}

namespace OgrenciKayıtSistemi
{
    partial class formOgrEkle
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
            this.panelOgrEkle = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblOgrEkleBaslik = new System.Windows.Forms.Label();
            this.lblOgrAd = new System.Windows.Forms.Label();
            this.lblOgrSoyad = new System.Windows.Forms.Label();
            this.lblOgrNo = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panelOgrEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOgrEkle
            // 
            this.panelOgrEkle.BackColor = System.Drawing.Color.DarkGreen;
            this.panelOgrEkle.Controls.Add(this.btnGeri);
            this.panelOgrEkle.Controls.Add(this.lblOgrEkleBaslik);
            this.panelOgrEkle.Location = new System.Drawing.Point(-2, -8);
            this.panelOgrEkle.Name = "panelOgrEkle";
            this.panelOgrEkle.Size = new System.Drawing.Size(451, 121);
            this.panelOgrEkle.TabIndex = 2;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGeri.Location = new System.Drawing.Point(328, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(109, 39);
            this.btnGeri.TabIndex = 34;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblOgrEkleBaslik
            // 
            this.lblOgrEkleBaslik.AutoSize = true;
            this.lblOgrEkleBaslik.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrEkleBaslik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOgrEkleBaslik.Location = new System.Drawing.Point(14, 27);
            this.lblOgrEkleBaslik.Name = "lblOgrEkleBaslik";
            this.lblOgrEkleBaslik.Size = new System.Drawing.Size(277, 69);
            this.lblOgrEkleBaslik.TabIndex = 0;
            this.lblOgrEkleBaslik.Text = "Öğrenci Ekle";
            // 
            // lblOgrAd
            // 
            this.lblOgrAd.AutoSize = true;
            this.lblOgrAd.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrAd.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrAd.Location = new System.Drawing.Point(89, 185);
            this.lblOgrAd.Name = "lblOgrAd";
            this.lblOgrAd.Size = new System.Drawing.Size(141, 29);
            this.lblOgrAd.TabIndex = 3;
            this.lblOgrAd.Text = "Öğrencinin Adı:";
            // 
            // lblOgrSoyad
            // 
            this.lblOgrSoyad.AutoSize = true;
            this.lblOgrSoyad.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSoyad.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrSoyad.Location = new System.Drawing.Point(62, 245);
            this.lblOgrSoyad.Name = "lblOgrSoyad";
            this.lblOgrSoyad.Size = new System.Drawing.Size(168, 29);
            this.lblOgrSoyad.TabIndex = 4;
            this.lblOgrSoyad.Text = "Öğrencinin Soyadı:";
            // 
            // lblOgrNo
            // 
            this.lblOgrNo.AutoSize = true;
            this.lblOgrNo.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOgrNo.Location = new System.Drawing.Point(36, 303);
            this.lblOgrNo.Name = "lblOgrNo";
            this.lblOgrNo.Size = new System.Drawing.Size(194, 29);
            this.lblOgrNo.TabIndex = 5;
            this.lblOgrNo.Text = "Öğrencinin Numarası:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(239, 190);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(128, 22);
            this.txtOgrAd.TabIndex = 6;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(239, 250);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(128, 22);
            this.txtOgrSoyad.TabIndex = 7;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(239, 308);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(128, 22);
            this.txtOgrNo.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEkle.Location = new System.Drawing.Point(239, 363);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 58);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Kaydet";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // formOgrEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(447, 456);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.lblOgrNo);
            this.Controls.Add(this.lblOgrSoyad);
            this.Controls.Add(this.lblOgrAd);
            this.Controls.Add(this.panelOgrEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formOgrEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Ekleme";
            this.panelOgrEkle.ResumeLayout(false);
            this.panelOgrEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOgrEkle;
        private System.Windows.Forms.Label lblOgrEkleBaslik;
        private System.Windows.Forms.Label lblOgrAd;
        private System.Windows.Forms.Label lblOgrSoyad;
        private System.Windows.Forms.Label lblOgrNo;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGeri;
    }
}
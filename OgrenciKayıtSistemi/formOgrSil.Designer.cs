
namespace OgrenciKayıtSistemi
{
    partial class formOgrSil
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
            this.panelSilme = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblOgrSilBaslik = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.panelSilme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSilme
            // 
            this.panelSilme.BackColor = System.Drawing.Color.DarkGreen;
            this.panelSilme.Controls.Add(this.btnGeri);
            this.panelSilme.Controls.Add(this.lblOgrSilBaslik);
            this.panelSilme.Location = new System.Drawing.Point(-2, -8);
            this.panelSilme.Name = "panelSilme";
            this.panelSilme.Size = new System.Drawing.Size(602, 121);
            this.panelSilme.TabIndex = 4;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGeri.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnGeri.Location = new System.Drawing.Point(481, 20);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(109, 39);
            this.btnGeri.TabIndex = 35;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblOgrSilBaslik
            // 
            this.lblOgrSilBaslik.AutoSize = true;
            this.lblOgrSilBaslik.Font = new System.Drawing.Font("Sitka Banner", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgrSilBaslik.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOgrSilBaslik.Location = new System.Drawing.Point(14, 27);
            this.lblOgrSilBaslik.Name = "lblOgrSilBaslik";
            this.lblOgrSilBaslik.Size = new System.Drawing.Size(243, 69);
            this.lblOgrSilBaslik.TabIndex = 0;
            this.lblOgrSilBaslik.Text = "Öğrenci Sil";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.DarkGreen;
            this.btnListele.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListele.Location = new System.Drawing.Point(12, 125);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(109, 41);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
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
            this.dgwOgrenciler.Size = new System.Drawing.Size(576, 315);
            this.dgwOgrenciler.TabIndex = 11;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(479, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 41);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // formOgrSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(600, 502);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dgwOgrenciler);
            this.Controls.Add(this.panelSilme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "formOgrSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Sil";
            this.panelSilme.ResumeLayout(false);
            this.panelSilme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSilme;
        private System.Windows.Forms.Label lblOgrSilBaslik;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;
    }
}
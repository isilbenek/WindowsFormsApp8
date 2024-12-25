namespace WindowsFormsApp8
{
    partial class CalisanBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanBilgileri));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnCListele = new System.Windows.Forms.Button();
            this.btnCSil = new System.Windows.Forms.Button();
            this.btnCGuncelle = new System.Windows.Forms.Button();
            this.btnCEkle = new System.Windows.Forms.Button();
            this.btnCAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCikis.Location = new System.Drawing.Point(267, 479);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(177, 37);
            this.btnCikis.TabIndex = 12;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // btnCListele
            // 
            this.btnCListele.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCListele.Location = new System.Drawing.Point(279, 362);
            this.btnCListele.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCListele.Name = "btnCListele";
            this.btnCListele.Size = new System.Drawing.Size(153, 46);
            this.btnCListele.TabIndex = 11;
            this.btnCListele.Text = "Çalışan Listele";
            this.btnCListele.UseVisualStyleBackColor = true;
            // 
            // btnCSil
            // 
            this.btnCSil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCSil.Location = new System.Drawing.Point(279, 300);
            this.btnCSil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCSil.Name = "btnCSil";
            this.btnCSil.Size = new System.Drawing.Size(153, 46);
            this.btnCSil.TabIndex = 10;
            this.btnCSil.Text = "Çalışan Sil";
            this.btnCSil.UseVisualStyleBackColor = true;
            // 
            // btnCGuncelle
            // 
            this.btnCGuncelle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCGuncelle.Location = new System.Drawing.Point(279, 238);
            this.btnCGuncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCGuncelle.Name = "btnCGuncelle";
            this.btnCGuncelle.Size = new System.Drawing.Size(153, 46);
            this.btnCGuncelle.TabIndex = 9;
            this.btnCGuncelle.Text = "Çalışan Güncelle";
            this.btnCGuncelle.UseVisualStyleBackColor = true;
            this.btnCGuncelle.Click += new System.EventHandler(this.btnCGuncelle_Click);
            // 
            // btnCEkle
            // 
            this.btnCEkle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCEkle.Location = new System.Drawing.Point(279, 115);
            this.btnCEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCEkle.Name = "btnCEkle";
            this.btnCEkle.Size = new System.Drawing.Size(153, 46);
            this.btnCEkle.TabIndex = 7;
            this.btnCEkle.Text = "Çalışan Ekle";
            this.btnCEkle.UseVisualStyleBackColor = true;
            this.btnCEkle.Click += new System.EventHandler(this.btnCEkle_Click);
            // 
            // btnCAra
            // 
            this.btnCAra.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCAra.Location = new System.Drawing.Point(279, 176);
            this.btnCAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCAra.Name = "btnCAra";
            this.btnCAra.Size = new System.Drawing.Size(153, 46);
            this.btnCAra.TabIndex = 8;
            this.btnCAra.Text = "Çalışan Ara";
            this.btnCAra.UseVisualStyleBackColor = true;
            this.btnCAra.Click += new System.EventHandler(this.btnCAra_Click);
            // 
            // CalisanBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 566);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnCListele);
            this.Controls.Add(this.btnCSil);
            this.Controls.Add(this.btnCGuncelle);
            this.Controls.Add(this.btnCEkle);
            this.Controls.Add(this.btnCAra);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalisanBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisanBilgileri";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnCListele;
        private System.Windows.Forms.Button btnCSil;
        private System.Windows.Forms.Button btnCGuncelle;
        private System.Windows.Forms.Button btnCEkle;
        private System.Windows.Forms.Button btnCAra;
    }
}
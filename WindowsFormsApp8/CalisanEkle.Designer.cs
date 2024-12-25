namespace WindowsFormsApp8
{
    partial class CalisanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanEkle));
            this.button1 = new System.Windows.Forms.Button();
            this.txtCSifre = new System.Windows.Forms.MaskedTextBox();
            this.txtCTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCBolum = new System.Windows.Forms.TextBox();
            this.txtCAdSoyad = new System.Windows.Forms.TextBox();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtbaslik = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(366, 551);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCSifre
            // 
            this.txtCSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCSifre.Location = new System.Drawing.Point(438, 424);
            this.txtCSifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCSifre.Mask = "000000000000";
            this.txtCSifre.Name = "txtCSifre";
            this.txtCSifre.Size = new System.Drawing.Size(215, 26);
            this.txtCSifre.TabIndex = 14;
            this.txtCSifre.ValidatingType = typeof(int);
            // 
            // txtCTel
            // 
            this.txtCTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCTel.Location = new System.Drawing.Point(438, 385);
            this.txtCTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCTel.Mask = "(999) 000-0000";
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(215, 26);
            this.txtCTel.TabIndex = 12;
            // 
            // txtCBolum
            // 
            this.txtCBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCBolum.Location = new System.Drawing.Point(438, 332);
            this.txtCBolum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCBolum.Name = "txtCBolum";
            this.txtCBolum.Size = new System.Drawing.Size(215, 26);
            this.txtCBolum.TabIndex = 10;
            // 
            // txtCAdSoyad
            // 
            this.txtCAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCAdSoyad.Location = new System.Drawing.Point(438, 284);
            this.txtCAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCAdSoyad.Name = "txtCAdSoyad";
            this.txtCAdSoyad.Size = new System.Drawing.Size(215, 26);
            this.txtCAdSoyad.TabIndex = 8;
            this.txtCAdSoyad.TextChanged += new System.EventHandler(this.txtAdSoyad_TextChanged);
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCID.Location = new System.Drawing.Point(438, 237);
            this.txtCID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(215, 26);
            this.txtCID.TabIndex = 6;
            // 
            // txtbaslik
            // 
            this.txtbaslik.AutoSize = true;
            this.txtbaslik.BackColor = System.Drawing.Color.Transparent;
            this.txtbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbaslik.ForeColor = System.Drawing.Color.Black;
            this.txtbaslik.Location = new System.Drawing.Point(390, 125);
            this.txtbaslik.Name = "txtbaslik";
            this.txtbaslik.Size = new System.Drawing.Size(162, 25);
            this.txtbaslik.TabIndex = 17;
            this.txtbaslik.Text = "Çalışan Ekleme";
            // 
            // txt5
            // 
            this.txt5.AutoSize = true;
            this.txt5.BackColor = System.Drawing.Color.Transparent;
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt5.Location = new System.Drawing.Point(332, 430);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(55, 20);
            this.txt5.TabIndex = 15;
            this.txt5.Text = "Şifre:";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.BackColor = System.Drawing.Color.Transparent;
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.Location = new System.Drawing.Point(310, 385);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(77, 20);
            this.txt4.TabIndex = 13;
            this.txt4.Text = "Telefon:";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.BackColor = System.Drawing.Color.Transparent;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.Location = new System.Drawing.Point(319, 337);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(68, 20);
            this.txt3.TabIndex = 11;
            this.txt3.Text = "Bölüm:";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.BackColor = System.Drawing.Color.Transparent;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(281, 290);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(106, 20);
            this.txt2.TabIndex = 9;
            this.txt2.Text = "Ad / Soyad:";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.BackColor = System.Drawing.Color.Transparent;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.Location = new System.Drawing.Point(353, 237);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(34, 20);
            this.txt1.TabIndex = 7;
            this.txt1.Text = "ID:";
            // 
            // CalisanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCSifre);
            this.Controls.Add(this.txtCTel);
            this.Controls.Add(this.txtCBolum);
            this.Controls.Add(this.txtCAdSoyad);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.txtbaslik);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "CalisanEkle";
            this.Text = "CalisanEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtCSifre;
        private System.Windows.Forms.MaskedTextBox txtCTel;
        private System.Windows.Forms.TextBox txtCBolum;
        private System.Windows.Forms.TextBox txtCAdSoyad;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label txtbaslik;
        private System.Windows.Forms.Label txt5;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt1;
    }
}
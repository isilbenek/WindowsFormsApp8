namespace WindowsFormsApp8
{
    partial class MusteriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriSil));
            this.button2 = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(238, 633);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 32);
            this.button2.TabIndex = 54;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(250, 158);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(162, 26);
            this.txtAra.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "ID / TC No :";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(297, 351);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(162, 26);
            this.txtID.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(246, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(250, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 32);
            this.button1.TabIndex = 40;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBakiye.Location = new System.Drawing.Point(297, 550);
            this.txtBakiye.Margin = new System.Windows.Forms.Padding(2);
            this.txtBakiye.Mask = "000000000000";
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(162, 26);
            this.txtBakiye.TabIndex = 49;
            this.txtBakiye.ValidatingType = typeof(int);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(297, 507);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(162, 26);
            this.txtTel.TabIndex = 47;
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(297, 468);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ReadOnly = true;
            this.txtAdres.Size = new System.Drawing.Size(162, 26);
            this.txtAdres.TabIndex = 45;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(297, 433);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.ReadOnly = true;
            this.txtAdSoyad.Size = new System.Drawing.Size(162, 26);
            this.txtAdSoyad.TabIndex = 43;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(297, 390);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.ReadOnly = true;
            this.txtTcNo.Size = new System.Drawing.Size(162, 26);
            this.txtTcNo.TabIndex = 41;
            // 
            // txt5
            // 
            this.txt5.AutoSize = true;
            this.txt5.BackColor = System.Drawing.Color.Transparent;
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt5.Location = new System.Drawing.Point(209, 553);
            this.txt5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(71, 20);
            this.txt5.TabIndex = 50;
            this.txt5.Text = "Bakiye:";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.BackColor = System.Drawing.Color.Transparent;
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.Location = new System.Drawing.Point(203, 516);
            this.txt4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(77, 20);
            this.txt4.TabIndex = 48;
            this.txt4.Text = "Telefon:";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.BackColor = System.Drawing.Color.Transparent;
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt3.Location = new System.Drawing.Point(216, 477);
            this.txt3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(64, 20);
            this.txt3.TabIndex = 46;
            this.txt3.Text = "Adres:";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.BackColor = System.Drawing.Color.Transparent;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(174, 439);
            this.txt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(106, 20);
            this.txt2.TabIndex = 44;
            this.txt2.Text = "Ad / Soyad:";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.BackColor = System.Drawing.Color.Transparent;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt1.Location = new System.Drawing.Point(212, 396);
            this.txt1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(68, 20);
            this.txt1.TabIndex = 42;
            this.txt1.Text = "TC No:";
            // 
            // MusteriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 755);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "MusteriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Silme İşlemi";
            this.Load += new System.EventHandler(this.MusteriSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtBakiye;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label txt5;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt1;
    }
}
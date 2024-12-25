namespace WindowsFormsApp8
{
    partial class CalisanAra
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCTel = new System.Windows.Forms.MaskedTextBox();
            this.txtCAdSoyad = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCBolum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(315, 165);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(162, 22);
            this.txtAra.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID :";
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCID.Location = new System.Drawing.Point(314, 351);
            this.txtCID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCID.Name = "txtCID";
            this.txtCID.ReadOnly = true;
            this.txtCID.Size = new System.Drawing.Size(162, 22);
            this.txtCID.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(253, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(315, 211);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCTel
            // 
            this.txtCTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCTel.Location = new System.Drawing.Point(314, 471);
            this.txtCTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCTel.Mask = "(999) 000-0000";
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.ReadOnly = true;
            this.txtCTel.Size = new System.Drawing.Size(162, 22);
            this.txtCTel.TabIndex = 31;
            // 
            // txtCAdSoyad
            // 
            this.txtCAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCAdSoyad.Location = new System.Drawing.Point(314, 389);
            this.txtCAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCAdSoyad.Name = "txtCAdSoyad";
            this.txtCAdSoyad.ReadOnly = true;
            this.txtCAdSoyad.Size = new System.Drawing.Size(162, 22);
            this.txtCAdSoyad.TabIndex = 27;
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.BackColor = System.Drawing.Color.Transparent;
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt4.Location = new System.Drawing.Point(220, 474);
            this.txt4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(64, 16);
            this.txt4.TabIndex = 32;
            this.txt4.Text = "Telefon:";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.BackColor = System.Drawing.Color.Transparent;
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2.Location = new System.Drawing.Point(191, 395);
            this.txt2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(88, 16);
            this.txt2.TabIndex = 28;
            this.txt2.Text = "Ad / Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(220, 434);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Bölüm:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCBolum
            // 
            this.txtCBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCBolum.Location = new System.Drawing.Point(314, 428);
            this.txtCBolum.Margin = new System.Windows.Forms.Padding(2);
            this.txtCBolum.Name = "txtCBolum";
            this.txtCBolum.ReadOnly = true;
            this.txtCBolum.Size = new System.Drawing.Size(162, 22);
            this.txtCBolum.TabIndex = 39;
            // 
            // CalisanAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 751);
            this.Controls.Add(this.txtCBolum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCTel);
            this.Controls.Add(this.txtCAdSoyad);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Name = "CalisanAra";
            this.Text = "CalisanAra";
            this.Load += new System.EventHandler(this.CalisanAra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtCTel;
        private System.Windows.Forms.TextBox txtCAdSoyad;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCBolum;
    }
}
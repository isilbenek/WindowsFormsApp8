namespace WindowsFormsApp8
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.outBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.kurBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outBtn
            // 
            this.outBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.outBtn.Location = new System.Drawing.Point(211, 510);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(225, 60);
            this.outBtn.TabIndex = 4;
            this.outBtn.Text = "Çıkış Yap";
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsBtn.Location = new System.Drawing.Point(211, 418);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(225, 60);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.Text = "Ayarlar";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // kurBtn
            // 
            this.kurBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kurBtn.Location = new System.Drawing.Point(211, 330);
            this.kurBtn.Name = "kurBtn";
            this.kurBtn.Size = new System.Drawing.Size(225, 60);
            this.kurBtn.TabIndex = 2;
            this.kurBtn.Text = " Oranlar/ Kurlar";
            this.kurBtn.UseVisualStyleBackColor = true;
            this.kurBtn.Click += new System.EventHandler(this.kurBtn_Click);
            // 
            // reportsBtn
            // 
            this.reportsBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportsBtn.Location = new System.Drawing.Point(211, 242);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(225, 60);
            this.reportsBtn.TabIndex = 1;
            this.reportsBtn.Text = "Raporlar";
            this.reportsBtn.UseVisualStyleBackColor = true;
            this.reportsBtn.Click += new System.EventHandler(this.reportsBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginBtn.Location = new System.Drawing.Point(211, 154);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(225, 60);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Giriş yap";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 681);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.kurBtn);
            this.Controls.Add(this.reportsBtn);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button kurBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button loginBtn;
    }
}


namespace StudyEnglish
{
    partial class FrmAnaMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenü));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblisim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAlistirmaYap = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKelimeEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCeviri = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblisim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-48, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 85);
            this.panel1.TabIndex = 0;
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Location = new System.Drawing.Point(157, 33);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(48, 17);
            this.lblisim.TabIndex = 2;
            this.lblisim.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Soyisim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Hoş Geldiniz  ";
            // 
            // BtnAlistirmaYap
            // 
            this.BtnAlistirmaYap.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnAlistirmaYap.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlistirmaYap.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnAlistirmaYap.Appearance.Options.UseBackColor = true;
            this.BtnAlistirmaYap.Appearance.Options.UseFont = true;
            this.BtnAlistirmaYap.Appearance.Options.UseForeColor = true;
            this.BtnAlistirmaYap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAlistirmaYap.ImageOptions.Image")));
            this.BtnAlistirmaYap.Location = new System.Drawing.Point(18, 143);
            this.BtnAlistirmaYap.Name = "BtnAlistirmaYap";
            this.BtnAlistirmaYap.Size = new System.Drawing.Size(189, 85);
            this.BtnAlistirmaYap.TabIndex = 2;
            this.BtnAlistirmaYap.Text = "Alıştırma Yap";
            this.BtnAlistirmaYap.Click += new System.EventHandler(this.BtnAlistirmaYap_Click);
            // 
            // BtnKelimeEkle
            // 
            this.BtnKelimeEkle.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnKelimeEkle.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKelimeEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnKelimeEkle.Appearance.Options.UseBackColor = true;
            this.BtnKelimeEkle.Appearance.Options.UseFont = true;
            this.BtnKelimeEkle.Appearance.Options.UseForeColor = true;
            this.BtnKelimeEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKelimeEkle.ImageOptions.Image")));
            this.BtnKelimeEkle.Location = new System.Drawing.Point(18, 248);
            this.BtnKelimeEkle.Name = "BtnKelimeEkle";
            this.BtnKelimeEkle.Size = new System.Drawing.Size(189, 85);
            this.BtnKelimeEkle.TabIndex = 3;
            this.BtnKelimeEkle.Text = "Kelime Ekle";
            this.BtnKelimeEkle.Click += new System.EventHandler(this.BtnKelimeEkle_Click);
            // 
            // BtnCeviri
            // 
            this.BtnCeviri.Appearance.BackColor = System.Drawing.Color.White;
            this.BtnCeviri.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCeviri.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BtnCeviri.Appearance.Options.UseBackColor = true;
            this.BtnCeviri.Appearance.Options.UseFont = true;
            this.BtnCeviri.Appearance.Options.UseForeColor = true;
            this.BtnCeviri.Enabled = false;
            this.BtnCeviri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCeviri.ImageOptions.Image")));
            this.BtnCeviri.Location = new System.Drawing.Point(18, 361);
            this.BtnCeviri.Name = "BtnCeviri";
            this.BtnCeviri.Size = new System.Drawing.Size(189, 85);
            this.BtnCeviri.TabIndex = 4;
            this.BtnCeviri.Text = "Transtlate";
            this.BtnCeviri.Click += new System.EventHandler(this.BtnCeviri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(213, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 313);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liderlik Tablosu";
            // 
            // FrmAnaMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(785, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCeviri);
            this.Controls.Add(this.BtnKelimeEkle);
            this.Controls.Add(this.BtnAlistirmaYap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAnaMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.FrmAnaMenü_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton BtnAlistirmaYap;
        private DevExpress.XtraEditors.SimpleButton BtnKelimeEkle;
        private DevExpress.XtraEditors.SimpleButton BtnCeviri;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblisim;
    }
}


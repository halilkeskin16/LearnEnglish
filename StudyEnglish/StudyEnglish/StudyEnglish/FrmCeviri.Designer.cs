namespace StudyEnglish
{
    partial class FrmCeviri
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
            this.richtxtboxTurkce = new System.Windows.Forms.RichTextBox();
            this.grpboxTurkce = new System.Windows.Forms.GroupBox();
            this.grpboxIngilizce = new System.Windows.Forms.GroupBox();
            this.richTxtBoxingilizce = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBaglantiDurum = new System.Windows.Forms.Button();
            this.BtnCeviri = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grpboxTurkce.SuspendLayout();
            this.grpboxIngilizce.SuspendLayout();
            this.SuspendLayout();
            // 
            // richtxtboxTurkce
            // 
            this.richtxtboxTurkce.Location = new System.Drawing.Point(0, 31);
            this.richtxtboxTurkce.Name = "richtxtboxTurkce";
            this.richtxtboxTurkce.Size = new System.Drawing.Size(304, 218);
            this.richtxtboxTurkce.TabIndex = 2;
            this.richtxtboxTurkce.Text = "";
            this.richtxtboxTurkce.TextChanged += new System.EventHandler(this.richtxtboxTurkce_TextChanged);
            // 
            // grpboxTurkce
            // 
            this.grpboxTurkce.Controls.Add(this.richtxtboxTurkce);
            this.grpboxTurkce.Location = new System.Drawing.Point(75, 88);
            this.grpboxTurkce.Name = "grpboxTurkce";
            this.grpboxTurkce.Size = new System.Drawing.Size(310, 255);
            this.grpboxTurkce.TabIndex = 3;
            this.grpboxTurkce.TabStop = false;
            this.grpboxTurkce.Text = "Türkçe";
            // 
            // grpboxIngilizce
            // 
            this.grpboxIngilizce.Controls.Add(this.richTxtBoxingilizce);
            this.grpboxIngilizce.Location = new System.Drawing.Point(434, 88);
            this.grpboxIngilizce.Name = "grpboxIngilizce";
            this.grpboxIngilizce.Size = new System.Drawing.Size(310, 255);
            this.grpboxIngilizce.TabIndex = 3;
            this.grpboxIngilizce.TabStop = false;
            this.grpboxIngilizce.Text = "İngilizce";
            // 
            // richTxtBoxingilizce
            // 
            this.richTxtBoxingilizce.Location = new System.Drawing.Point(0, 37);
            this.richTxtBoxingilizce.Name = "richTxtBoxingilizce";
            this.richTxtBoxingilizce.Size = new System.Drawing.Size(304, 218);
            this.richTxtBoxingilizce.TabIndex = 2;
            this.richTxtBoxingilizce.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "İnternet Bağlantısı:";
            // 
            // BtnBaglantiDurum
            // 
            this.BtnBaglantiDurum.Enabled = false;
            this.BtnBaglantiDurum.Location = new System.Drawing.Point(179, 16);
            this.BtnBaglantiDurum.Name = "BtnBaglantiDurum";
            this.BtnBaglantiDurum.Size = new System.Drawing.Size(37, 35);
            this.BtnBaglantiDurum.TabIndex = 5;
            this.BtnBaglantiDurum.UseVisualStyleBackColor = true;
            // 
            // BtnCeviri
            // 
            this.BtnCeviri.Location = new System.Drawing.Point(318, 369);
            this.BtnCeviri.Name = "BtnCeviri";
            this.BtnCeviri.Size = new System.Drawing.Size(195, 49);
            this.BtnCeviri.TabIndex = 6;
            this.BtnCeviri.Text = "Çeviri\r\n";
            this.BtnCeviri.UseVisualStyleBackColor = true;
            this.BtnCeviri.Click += new System.EventHandler(this.BtnCeviri_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(788, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(437, 353);
            this.webBrowser1.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(115, 382);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(142, 28);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FrmCeviri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1349, 487);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BtnCeviri);
            this.Controls.Add(this.BtnBaglantiDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpboxIngilizce);
            this.Controls.Add(this.grpboxTurkce);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCeviri";
            this.Text = "FrmCeviri";
            this.Load += new System.EventHandler(this.FrmCeviri_Load);
            this.grpboxTurkce.ResumeLayout(false);
            this.grpboxIngilizce.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtboxTurkce;
        private System.Windows.Forms.GroupBox grpboxTurkce;
        private System.Windows.Forms.GroupBox grpboxIngilizce;
        private System.Windows.Forms.RichTextBox richTxtBoxingilizce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBaglantiDurum;
        private System.Windows.Forms.Button BtnCeviri;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
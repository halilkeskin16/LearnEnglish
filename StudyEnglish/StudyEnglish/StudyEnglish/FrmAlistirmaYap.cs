using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace StudyEnglish
{
    public partial class FrmAlistirmaYap : Form
    {
        public FrmAlistirmaYap()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=StudyEnglish;Integrated Security=True");
        Random RndKelime = new Random();
        public int ToplamPuan = 0;
        int BilinenKelime = 0;
        int KelimeGecikmeSuresi = 180;
        public int Sure ;
        private void FrmAlistirmaYap_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen CapsLock'unuzu Kapalı Tutun");
            LblZaman.Text = Sure.ToString();
        }
        public void KelimeGetirmek()
        {
            baglanti.Open();
            SqlCommand VeriSayısıSorgu = new SqlCommand("Select count(*) from TblKelime", baglanti);
            int VeriSayisi = Convert.ToInt32(VeriSayısıSorgu.ExecuteScalar());
            int RandomSayi = RndKelime.Next(1, VeriSayisi+1);
            SqlCommand Kelime = new SqlCommand("Select * from TblKelime where id=@p1", baglanti);
            Kelime.Parameters.AddWithValue("@p1", RandomSayi);
            SqlDataReader dr = Kelime.ExecuteReader();
            while (dr.Read())
            {
                Txtingilizce.Text = dr[2].ToString();
                LblCevap.Text = dr[1].ToString();
                LblCevap.Text = LblCevap.Text.ToLower();
            }
            baglanti.Close();

        }
        private void BtnAlistirmaBaslat_Click(object sender, EventArgs e)
        {
            LblPuan.Text = "";
            Sure = 20;
            LblZaman.Text = Sure.ToString();
            TxtTurkce.Focus();
            KelimeGetirmek();
            timer1.Start();
            TxtTurkce.Enabled = true;
        
        }

        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {
            if(TxtTurkce.Text == LblCevap.Text)
            {
                BilinenKelime++;
                LblPuan.Text = BilinenKelime.ToString();
                Thread.Sleep(KelimeGecikmeSuresi);
                TxtTurkce.Clear();
                KelimeGetirmek();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sure--;
            LblZaman.Text = Sure.ToString();
            if(Sure == 0)
            {
                timer1.Stop();
                TxtTurkce.Enabled = false;
                MessageBox.Show("Süreniz Bitti");
                ToplamPuan += BilinenKelime;
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            // FrmAnaMenü frmAnaMenü = new FrmAnaMenü();
           // frmAnaMenü.Show();
            this.Close();
        }
    }
}

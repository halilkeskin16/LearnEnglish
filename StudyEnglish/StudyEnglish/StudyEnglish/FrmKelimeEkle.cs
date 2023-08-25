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

namespace StudyEnglish
{
    public partial class FrmKelimeEkle : Form
    {
        public FrmKelimeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=StudyEnglish;Integrated Security=True");
        void Temizleme()
        {
            TxtIngilizce.Clear();
            TxtTurkce.Clear();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TblKelime(Türkcesi,İngilizcesi) values (@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtTurkce.Text);
                komut.Parameters.AddWithValue("@p2", TxtIngilizce.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizleme();
                MessageBox.Show("Kelime ekleme işlemi başarıyla tamamlandı.","Onay Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Kelime ekleme işlemi tamamlanamadı. Lütfen tekrar deneyiniz","Uyarı Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaMenü frmAnaMenü = new FrmAnaMenü();
            frmAnaMenü.Show();
            this.Close();
        }
    }
}

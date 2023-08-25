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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        public int id;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=StudyEnglish;Integrated Security=True");
        public void GirisKontrol()
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from TblKullanıcı where KullanıcıAdı = @p1 and Sifre = @p2",baglanti);
            komut1.Parameters.AddWithValue("@p1",TxtKullanıcıAdı.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaMenü frmAnaMenü = new FrmAnaMenü();
                frmAnaMenü.lblisim.Text = dr.GetValue(1).ToString();
                frmAnaMenü.ToplamPuan =  Convert.ToInt32(dr.GetValue(5));
                frmAnaMenü.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreyi Yanlış Girdiniz Lütfen Kontrol Ediniz");
            }
            baglanti.Close();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            GirisKontrol();
        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked == true)
            {
                TxtSifre.PasswordChar = '\0' ;
            }
            else
            {
                TxtSifre.PasswordChar = '*';
            }
        }
    }
}

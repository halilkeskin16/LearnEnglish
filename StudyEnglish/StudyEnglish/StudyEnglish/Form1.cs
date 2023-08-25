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
    public partial class FrmAnaMenü : Form
    {
        public FrmAnaMenü()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=StudyEnglish;Integrated Security=True");

        FrmAlistirmaYap frmAlistirma = new FrmAlistirmaYap();
        public int ToplamPuan = 0;
        private void BtnAlistirmaYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlistirma.ShowDialog();
            ToplamPuan = ToplamPuan + frmAlistirma.ToplamPuan;
            
            this.Show();
        }
        
        private void BtnKelimeEkle_Click(object sender, EventArgs e)
        {
            FrmKelimeEkle frmKelimeEkle = new FrmKelimeEkle();
            frmKelimeEkle.Show();
            this.Hide();
        }

        private void FrmAnaMenü_Load(object sender, EventArgs e)
        {
            ToplamPuan = ToplamPuan + frmAlistirma.ToplamPuan;
            
        }

        private void BtnCeviri_Click(object sender, EventArgs e)
        {
            FrmCeviri frmCeviri = new FrmCeviri();
            frmCeviri.Show();
            this.Hide();
        }
    }
}

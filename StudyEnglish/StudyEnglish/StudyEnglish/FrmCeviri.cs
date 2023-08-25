using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace StudyEnglish
{
    public partial class FrmCeviri : Form
    {
        public FrmCeviri()
        {
            InitializeComponent();
        }

        bool internetbaglantisi()
        {
            string adres = "https://www.google.com";
            try
            {
                WebRequest istek = WebRequest.Create(adres);
                WebResponse yanit = istek.GetResponse();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void FrmCeviri_Load(object sender, EventArgs e)
        {
            if (internetbaglantisi())
            {
                BtnBaglantiDurum.BackColor = Color.Green;
            }
            else
            {
                BtnBaglantiDurum.BackColor = Color.Red;
            }
            

        }

        private void richtxtboxTurkce_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText = richtxtboxTurkce.Text;
        }

        private void BtnCeviri_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                richTxtBoxingilizce.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }
    }
}

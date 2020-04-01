using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Yaz_Okulu_Otomasyonu.Administrator
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool sonuc = SQLHelper.GirisYap_Admin(txtKullaniciAdi.Text,txtSifre.Text);

            if (sonuc)
            {
               
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Label1.Text = "Hatalı Giriş";
            }
        }
    }
}
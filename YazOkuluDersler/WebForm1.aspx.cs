using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.OgrAd = txtOgrAd.Text;
            ogrenci.OgrSoyad = txtOgrSoyad.Text;
            ogrenci.OgrNumara = txtOgrNumara.Text;
            ogrenci.OgrSifre = txtOgrSifre.Text;
            ogrenci.OgrFotograf = txtOgrFotograf.Text;
            OgrenciBLL.OgrenciEkleBLL(ogrenci);
        }
    }
}
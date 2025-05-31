using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace YazOkuluDersler
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OgrId"].ToString());
            txtOgrId.Text = x.ToString();
            txtOgrId.Enabled = false;

            Ogrenci ogrenci = new Ogrenci();
            List<Ogrenci> OgrenciListe = OgrenciBLL.OgrenciDetayBLL(x);
            txtOgrAd.Text = OgrenciListe[0].OgrAd.ToString();
            txtOgrSoyad.Text = OgrenciListe[0].OgrSoyad.ToString();
            txtOgrNumara.Text = OgrenciListe[0].OgrNumara.ToString();
            txtOgrFotograf.Text = OgrenciListe[0].OgrFotograf.ToString();
            txtOgrSifre.Text = OgrenciListe[0].OgrSifre.ToString();
        }
    }
}
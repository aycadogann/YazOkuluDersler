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
    public partial class OgrenciListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Ogrenci> OgrenciListe = OgrenciBLL.OgrenciListeleBLL();
            Repeater1.DataSource = OgrenciListe;
            Repeater1.DataBind();
        }
    }
}
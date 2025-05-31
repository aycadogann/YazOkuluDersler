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
    public partial class Dersler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
            //List<Ders> dersler = DersBLL.DersListeleBLL();
            DropDownList1.DataSource = DersBLL.DersListeleBLL();
            DropDownList1.DataTextField = "DersAd";
            DropDownList1.SelectedValue = "DersId";
            DropDownList1.DataBind();
            }
        }
    }
}
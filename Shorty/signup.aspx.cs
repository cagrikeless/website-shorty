using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Shorty
{
    public partial class signup1 : System.Web.UI.Page
    {

        public static class PageUtility
        {
            public static void MessageBox(System.Web.UI.Page page, string strMsg)
            {
                ScriptManager.RegisterClientScriptBlock(page, page.GetType(), "alertmessage", "alert('" + strMsg + "')", true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btn_Signup_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                try
                {
                    Entities s = new Entities();
                    TBLSIGN signtbl = new TBLSIGN();
                    signtbl.NAME = txt_fullname.Text;
                    signtbl.EMAIL = txt_emailAddress.Text;
                    signtbl.PASSWORD = txt_password.Text.ToString();
                    s.TBLSIGNs.Add(signtbl);
                    s.SaveChanges();
                    Response.Redirect("/login.aspx");
                }
                catch (Exception)
                {
                    PageUtility.MessageBox(this, "Bir hata ile karşılaşıldı.");
                }
            }
               

            
        }
    }
}
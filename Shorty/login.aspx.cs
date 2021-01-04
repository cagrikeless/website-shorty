using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Shorty
{
    public partial class signup : System.Web.UI.Page
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-OL0BNDU\\" +
        "SQLEXPRESS;Initial Catalog=e-Ticaret;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand cmd;
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
            if (!IsPostBack)
            {
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                    try
                    {
                        cmd = new SqlCommand("Select * FROM TBLSIGN WHERE NAME=@NAME AND EMAIL=@EMAIL AND PASSWORD=@PASSWORD", con);
                        cmd.Parameters.AddWithValue("@NAME", txt_fullname.Text);
                        cmd.Parameters.AddWithValue("@EMAIL", txt_emailAddress.Text);
                        cmd.Parameters.AddWithValue("@PASSWORD", txt_password.Text);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Response.Redirect("/home.aspx");
                        }
                        else
                        {
                            PageUtility.MessageBox(this, "Yanlış Email Veya Şifre");
                        }
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
                else
                {
                    con.Close();
                }
            }
        }
    }
}
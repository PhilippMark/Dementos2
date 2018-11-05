using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrganizeMonkey
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            if (Request.QueryString["parameter"] != null && Request.QueryString["parameter"] == "logoutError")
            {
                placeholderLogoutError.Visible = true;
            }
            if (Request.QueryString["parameter"] != null && Request.QueryString["parameter"] == "login")
            {
                placeHolderLoginError.Visible = true;
            }
            if (Request.QueryString["parameter"] != null && Request.QueryString["parameter"] == "logout")
            {
                placeHolderLogout.Visible = true;
            }
            if (Request.QueryString["parameter"] != null && Request.QueryString["parameter"] == "regError")
            {
                placeholderRegError.Visible = true;
            }
            if (Request.QueryString["parameter"] != null && Request.QueryString["parameter"] == "regSuccess")
            {
                placeholderRegSuccess.Visible = true;
            }
            if (Request.QueryString["parameter"] != null && Request.QueryString["parameter"] == "regNameError")
            {
                placeholderRegNameError.Visible = true;
            }

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            Administration.User user = new Administration.User();
            int? userId = null;
            //userId = user.GetLogin(txtLogin.Text, txtPassword.Text);

            if (userId.HasValue)
            {
                //Session_Start(null, null);
                Session["user"] = userId.Value;
                Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority));
            }
            else
            {
                Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority) + "/login.aspx?parameter=login");
            }
            //errormessage.Visible = true;   
            btnLogin.Enabled = true;
        }

        
    }
}
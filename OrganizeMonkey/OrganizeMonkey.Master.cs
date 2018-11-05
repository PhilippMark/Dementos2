using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyAPI;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web.Enums;
using System.IO;
using System.Net;
using System.Data;
using System.Web.UI.HtmlControls;
 

namespace OrganizeMonkey
{

    public partial class OrganizeMonkey : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////if (Session["farbe"] == null)
            ////{
            ////    MyStyleSheet.Attributes.Add("href", "~/styles/monkey-blue.css");
            ////}
            ////else
            ////{
            ////    if (Session["farbe"].ToString() == "blau")
            ////        MyStyleSheet.Attributes.Add("href", "~/styles/monkey-blue.css");
            ////    if (Session["farbe"].ToString() == "gruen")
            ////        MyStyleSheet.Attributes.Add("href", "~/styles/monkey-standard.css");
            ////    if (Session["farbe"].ToString() == "rot")
            ////        MyStyleSheet.Attributes.Add("href", "~/styles/monkey-red.css");
            ////}
            //////SpotifyWebAPI spot = new SpotifyWebAPI();
            ////if (Session["user"] == null)
            ////{
            ////    Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority) + "/Login.aspx");
            ////}

            ////GetComponents();
            //if (Session["user"] == null)
            //{
            //    Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority) + "/Login.aspx?parameter=logout");
            //}

            //Administration.Corporation corp = new Administration.Corporation();
            //Administration.User user = new Administration.User();
            //LoadChat();
            //LoadTasks();
            //Session["corporation"] = corp.GetCorporationIdByUserId(Convert.ToInt32(Session["user"]));
            //string text = user.GetCorpName(Session["user"].ToString());

            //name.Text = text;

            //repeaterUser.DataSource = GetUsersByCorporation();
            //repeaterUser.DataBind();

            //Session.Timeout = 20;


        }

        //protected DataTable GetUsersByCorporation()
        //{
        //    Administration.User user = new Administration.User();

        //    int corpId = Convert.ToInt32(Session["corporation"].ToString());

        //    return user.GetUsersByCorporation(corpId);
        //}
        //protected void btnLogout_Click(object sender, EventArgs e)
        //{
        //    Session.Clear();
        //    Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority) + "/Login.aspx");
        //}

        //protected string GetStartURL()
        //{
        //    string url = (Request.Url.GetLeftPart(UriPartial.Authority) + "/Components/Start/index.aspx");
        //    return url;
        //}

        ////protected void Blau_Click(object sender, EventArgs e)
        ////{   
        ////    MyStyleSheet.Attributes.Add("href", "~/styles/monkey-blue.css");
        ////    Session["farbe"] = "blau";
        ////}

        ////protected void Gruen_Click(object sender, EventArgs e)
        ////{
        ////    MyStyleSheet.Attributes.Add("href", "~/styles/monkey-standard.css");
        ////    Session["farbe"] = "gruen";
        ////}

        ////protected void Rot_Click(object sender, EventArgs e)
        ////{
        ////    MyStyleSheet.Attributes.Add("href", "~/styles/monkey-red.css");
        ////    Session["farbe"] = "rot";
        ////}
        //protected void LoadChat()
        //{
        //    int userId = Convert.ToInt32(Session["user"].ToString());
        //    DataTable messages = new Administration.Message().GetTopMessages(userId, 4);

        //    if(messages.Rows.Count > 0)
        //    {
        //        placeholderNewMessage.Visible = placeholderNewMessageMobile.Visible = true;
        //        lblNewMessage.Text = lblNewMessageMobile.Text = messages.Rows.Count.ToString();
        //        placeholderNoMessages.Visible = false;
        //    }

        //    repeaterMessages.DataSource = messages;
        //    repeaterMessages.DataBind();
        //}

        //protected void LoadTasks()
        //{
        //    int userId = Convert.ToInt32(Session["user"].ToString());
        //    DataTable tasks = new Administration.Message().GetTopMessagesTasks(userId);

        //    if (tasks.Rows.Count > 0)
        //    {
        //        placeholderNewTasks.Visible = placeholderNewTasksMobile.Visible = true;
        //        lblNewTasks.Text = lblNewTasksMobile.Text = tasks.Rows.Count.ToString();
        //        placeholderNoTasks.Visible = false;
        //    }

        //    repeaterTasks.DataSource = tasks;
        //    repeaterTasks.DataBind();
        //}
    }   
}
    
   

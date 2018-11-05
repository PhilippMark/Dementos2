using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyAPI.Web;
using System.Data;

namespace OrganizeMonkey
{
    public partial class _default : System.Web.UI.Page
    {
        public string offen;
        public string bearbeitung;
        public string beendet;
        public string erledigt;
        public string offenVal;
        public string bearbeitungVal;
        public string beendetVal;
        public string erledigtVal;

        public string offen2;
        public string bearbeitung2;
        public string beendet2;
        public string erledigt2;
        public string offenVal2;
        public string bearbeitungVal2;
        public string beendetVal2;
        public string erledigtVal2;
        protected void Page_Load(object sender, EventArgs e)
        {
            Administration.User user = new Administration.User();
            EFMonkey.User i = user.GetUserById(1);

            //if (Session["user"] == null)
            //{
            //    Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority) +"/Login.aspx");
            //}

            //Administration.Corporation corp = new Administration.Corporation();
            //Session["corporation"] = corp.GetCorporationIdByUserId(Convert.ToInt32(Session["user"]));
            //int userId = Convert.ToInt32(Session["user"].ToString());
            //int taskId = Convert.ToInt32(Session["corporation"].ToString());
            //Administration.Task task = new Administration.Task();
            //Dictionary<string, string> counts = task.GetTaskCountByUser(userId);
            //lblName.Text = new Administration.User().GetUserNameById(userId);

            //offen = "Offen";
            //bearbeitung = "In Bearbeitung";
            //beendet = "Beendet";
            //erledigt = "Erledigt";

            //offenVal = counts["Offen"];
            //bearbeitungVal = counts["In Bearbeitung"];
            //beendetVal = counts["Beendet"];
            //erledigtVal = counts["Erledigt"];

            //Dictionary<string, string> counts2 = task.GetTaskCount(taskId);

            //offen2 = "Offen";
            //bearbeitung2 = "In Bearbeitung";
            //beendet2 = "Beendet";
            //erledigt2 = "Erledigt";

            //offenVal2 = counts2["Offen"];
            //bearbeitungVal2 = counts2["In Bearbeitung"];
            //beendetVal2 = counts2["Beendet"];
            //erledigtVal2 = counts2["Erledigt"];



        }
    }
}
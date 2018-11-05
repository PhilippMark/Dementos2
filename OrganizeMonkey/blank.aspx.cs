using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrganizeMonkey
{
    public partial class blank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int documentId = Convert.ToInt32(Request.QueryString["documentId"].ToString());
            Administration.Message message = new Administration.Message();
            //string filename = message.GetDocument(documentId);

            //Response.ContentType = "application/octet-stream";
            //Response.AppendHeader("Content-Disposition", "attachment; "+ filename);
            //Response.TransmitFile(Server.MapPath("~/Files/" + filename));
            //Response.End();
        }
    }
}
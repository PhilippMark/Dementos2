using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OrganizeMonkey
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["init"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (!(HttpContext.Current != null || HttpContext.Current.Session != null))
            {
                //if (Session["user"] == null)
                //{
                //    Response.Redirect(Request.Url.GetLeftPart(UriPartial.Authority) + "/Login.aspx");
                //}
            }

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            HttpUnhandledException httpUnhandledException =
                new HttpUnhandledException(Server.GetLastError().Message, Server.GetLastError());
            SendEmailWithErrors(httpUnhandledException.GetHtmlErrorMessage());

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private static void SendEmailWithErrors(string result)
{
    try
    {
                SmtpClient smtpClient = new SmtpClient("smtp.1und1.de", 465);

                smtpClient.Credentials = new System.Net.NetworkCredential("philipp.markendorf@organize-monkey.com", "1959ortsac");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                MailMessage mail = new MailMessage();

                //Setting From , To and CC
                mail.From = new MailAddress("philipp.markendorf@organize-monkey.com", "MyWeb Site");
                mail.To.Add(new MailAddress("philmark@online.de"));
                mail.Body = result;

                smtpClient.Send(mail);
            }
    catch (Exception e)
    {
        // Write o the event log.
    }
}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Net.Mail;
using System.IO;

namespace WineStore
{
    public partial class Contact : Page
    {
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string messageForm = HttpContext.Current.Server.MapPath("~/App_Data/MessageForm.txt");
            string messageToSend = File.ReadAllText(messageForm);
            messageToSend = messageToSend.Replace("@@name@@", txtName.Text);
            messageToSend = messageToSend.Replace("@@lastName@@", txtLastName.Text);
            messageToSend = messageToSend.Replace("@@message@@", txtMessage.Text);
            messageToSend = messageToSend.Replace("@@loginLink@@", "https://localhost:44303/Contact" + txtLastName.Text);

            MailMessage myMessage = new MailMessage();
            myMessage.Subject = "WorldofWine account activation";
            myMessage.Body = messageToSend;
            myMessage.From = new MailAddress("worldofwine11@gmail.com", "WorldofWine");
            myMessage.To.Add(new MailAddress(txtEmail.Text, txtName.Text + " " + txtLastName.Text));
            SmtpClient mySmtpClient = new SmtpClient();
            mySmtpClient.Send(myMessage);
        }
    }
}


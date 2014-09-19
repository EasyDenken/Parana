using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Configuration;

namespace RioParanaBLL
{
    public static class ErrorHandler
    {
        public static void HandleError(Exception exe)
        {
            //string fromAddress = ConfigurationManager.AppSettings["FromEmail"].ToString();
            //string toAddress = ConfigurationManager.AppSettings["Admin.SupportMail"].ToString();
            //string messageBody = exe.Message + "\r\n" + exe.StackTrace.ToString() + "\r\n" + exe.Source.ToString();
            //string subject = "Error";
            ////public void SendMessage(string subject, string messageBody, string fromAddress, string toAddress)
            //MailMessage message = new MailMessage();
            //SmtpClient client = new SmtpClient();

            //// Set the sender's address
            //message.From = new MailAddress(fromAddress);

            //// Allow multiple "To" addresses to be separated by a semi-colon
            //if (toAddress.Trim().Length > 0)
            //{
            //    foreach (string addr in toAddress.Split(';'))
            //    {
            //        message.To.Add(new MailAddress(addr));
            //    }
            //}

            //// Allow multiple "Cc" addresses to be separated by a semi-colon
            ////if (ccAddress.Trim().Length > 0)
            ////{
            ////    foreach (string addr in ccAddress.Split(';'))
            ////    {
            ////        message.CC.Add(new MailAddress(addr));
            ////    }
            ////}

            //// Set the subject and message body text
            //message.Subject = subject;
            //message.Body = messageBody;

            //// TODO: *** Modify for your SMTP server ***
            //// Set the SMTP server to be used to send the message
            //client.Host = "";
            //// Send the e-mail message
            //client.Send(message);
        }
    }
}

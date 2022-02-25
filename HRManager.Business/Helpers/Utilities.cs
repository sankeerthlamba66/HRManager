using HRManager.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HRManager.Business.Helpers
{
    internal static class Utilities
    {
        //Functionality to send email
        public static string HRMailId = "srinivas.rathod@tekfriday.com";
        public static string HRName = "srinivas";
        public static void SendEmail(string EmailId, string Subject, string Body)
        { 
            try
            {
                var senderEmail = new MailAddress(HRMailId, HRName);
                var password = "Sri@2250";
                var receiverEmail = new MailAddress(EmailId);
                //HRadmin or HR password
                var smtp = new SmtpClient
                {
                    Host = "smtp.ionos.com", //smtp.ionos.com
                    Port = 587,             //port number to be updated
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var sendMail = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = Subject,
                    Body = Body
                })
                {
                    smtp.Send(sendMail);
                }
            }
            catch(Exception ex)
            {
                ErrorLogger.LogException(ex);
            }
        }
    }
}

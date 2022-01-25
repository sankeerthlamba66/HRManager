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
        public static void SendEmail(string EmailId, string Subject, string Body)
        { 
            var senderEmail = new MailAddress("******HR@tekfriday.com", "Name Of the sender");
            var receiverEmail = new MailAddress(EmailId);
            var password = "********";//HRadmin or HR password
            var smtp = new SmtpClient
            {
                Host = "imap.ionos.com", //smtp address 
                Port = 993,             //port number to be updated
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
    }
}

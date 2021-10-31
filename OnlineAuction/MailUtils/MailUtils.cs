using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OnlineAuction.MailUtils
{
    public class MailUtils
    {
        public static async Task<string> SendMail( string _to, string _subject, string _body)
        {
            var _from = "sonlineauction@gmail.com";
            MailMessage message = new MailMessage(_from, _to, _subject, _body);
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;

            message.ReplyToList.Add(new MailAddress(_from));
            message.Sender = new MailAddress(_from);

            using var smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("sonlineauction@gmail.com","Oa123988@");

            try
            {
               await smtpClient.SendMailAsync(message);
                return "Sent";
            }
            catch (Exception ex)
            {

                return "Email has not been sent." + ex.Message;
            }

        }
    }
}

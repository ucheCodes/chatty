﻿namespace Chatty.Data
{
    using MailKit;
    using MailKit.Net.Smtp;
    using MailKit.Security;
    using MimeKit;
    using MimeKit.Text;
    using Org.BouncyCastle.Asn1.Ocsp;
    public class MailService
    {
        public Task<bool> Send(string from, string to, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(from));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            using (var smtp = new SmtpClient())
            {
                try
                {
                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate("peters.soft.network@gmail.com", "kdznwmmmmcdcxszr");
                    smtp.Send(email);
                    smtp.Disconnect(true);//$PSNSecure123$
                    return Task.FromResult(true);
                }
                catch (Exception)
                {
                    return Task.FromResult(false);
                }
            }
        }
    }
}
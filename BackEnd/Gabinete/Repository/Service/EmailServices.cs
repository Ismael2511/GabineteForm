using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Repository.Service
{
    public class EmailServices : IEmailServices
    {
        public string url()
        {
            return "https://localhost:44329/files/";
        }
        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                var smtpClient = new SmtpClient("mail.oscgre.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("prueba@oscgre.com", "msf1ss@"),
                    EnableSsl = false,
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("Esmerlin79@hotmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(to);

                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {
                throw new Exception("No se pudo enviar el correo" + e);
            }

        }
    }
}

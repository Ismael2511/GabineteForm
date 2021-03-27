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
                    From = new MailAddress("prueba@oscgre.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(to);

                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {

            }
            //implementacion si es sin el boton mandarlo para otro html
            /*using (WebClient client = new WebClient())
            {
                string htmlCode = client.DownloadString(_config.url() + "theme_email/confirmacion.html");

                htmlCode = htmlCode.Replace("URL_REGISTRO", _config.urlFront() + "Credentials.html?id=" + obj.hash + "&entidad=" + obj.tipo_registro);
                _email.SendEmail(obj.email_igle, "Bienvenido", htmlCode);
            }*/

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
    public interface IEmailServices
    {
        void SendEmail(String to, String subject, String body);
        string url();
    }
}

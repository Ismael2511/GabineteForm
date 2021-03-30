using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IEmailServices
    {
         void SendEmail(String to, String subject, String body);
        string url();
    }
}

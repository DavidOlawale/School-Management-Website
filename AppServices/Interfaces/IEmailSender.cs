using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppServices.Interfaces
{
    public interface IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string body);
    }
}

using System;
using System.Threading.Tasks;

namespace TaskList.Services
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string toEmail, string fromEmail, string subject, string message)
        {
            throw new NotImplementedException();
        }
    }
}

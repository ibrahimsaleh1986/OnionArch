using System;
using System.Threading.Tasks;

namespace TaskList.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string fromEmail, string subject, string message);
    }
}

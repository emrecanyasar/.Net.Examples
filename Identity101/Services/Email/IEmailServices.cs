using Identity101.Models.Email;

namespace Identity101.Services.Email
{
    public interface IEmailServices
    {
        Task SendMailAsync(MailModel model);
    }
}

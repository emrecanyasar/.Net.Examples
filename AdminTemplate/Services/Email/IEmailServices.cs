using AdminTemplate.Models.Email;

namespace AdminTemplate.Services.Email
{
    public interface IEmailServices
    {
        Task SendMailAsync(MailModel model);
    }
}

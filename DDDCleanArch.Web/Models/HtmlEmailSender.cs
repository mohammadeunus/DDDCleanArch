namespace DDDCleanArch.Web.Models;

public class HtmlEmailSender : IEmailSender
{
    public Task SendEmailAsync(string receiverEmail, string subject, string body)
    {
        throw new NotImplementedException();
    }
}

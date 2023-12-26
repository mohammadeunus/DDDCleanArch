namespace DDDCleanArch.Web.Models;

public interface IEmailSender
{
    Task SendEmailAsync(string receiverEmail, string subject, string body);
}
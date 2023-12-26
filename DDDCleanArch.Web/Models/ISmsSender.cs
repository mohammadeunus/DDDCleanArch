namespace DDDCleanArch.Web.Models;

public interface ISmsSender
{
    void SendMessage(string message);
}

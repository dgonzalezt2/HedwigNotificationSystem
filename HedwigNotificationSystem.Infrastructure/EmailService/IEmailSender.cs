namespace HedwigNotificationSystem.Infrastructure.EmailService;

public interface IEmailSender<T> where T : class
{
    Task SendAsync(T message, string recipient);
}

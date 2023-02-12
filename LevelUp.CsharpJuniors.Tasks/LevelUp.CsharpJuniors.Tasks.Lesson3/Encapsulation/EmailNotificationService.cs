using System.Net.Mail;

namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Encapsulation;

public sealed class EmailNotificationService : INotificationService
{
    // These fields should be private because it's just the internal details
    private readonly string _smtpServerAddress;
    private Queue<EmailMessage> _queue = new();

    // This property can be read from outside - it's a part of public class interface
    // (how many items does the queue contain at he moment?)
    public int QueueCount => _queue.Count;
    
    public EmailNotificationService(string smtpServerAddress)
    {
        _smtpServerAddress = smtpServerAddress;
    }

    public void Notify(string receiver, string message)
    {
        if (!MailAddress.TryCreate(receiver, out var mailAddress))
        {
            return;
        }

        // Send notification message via email
        var emailMessage = new EmailMessage(mailAddress, message);
        _queue.Enqueue(emailMessage);
        
        // Process queue...
        // ...
    }
}
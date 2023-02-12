using System.Net.Mail;

namespace LevelUp.CsharpJuniors.Tasks.Lesson3.Encapsulation;

public record EmailMessage(MailAddress Address, string Message);
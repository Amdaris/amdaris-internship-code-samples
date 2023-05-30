NotificationService notificationService = new NotificationService();

notificationService.SendNotification("Amdaris", "SOLID principles are amazing!");

#region Classes
public class EmailSender
{
    public void SendEmail(string recipient, string message)
    {
        Console.WriteLine($"An email was sent to {recipient}! Message: {message}");
    }
}

public class NotificationService
{
    private EmailSender _emailSender;

    public NotificationService()
    {
        _emailSender = new EmailSender();
    }

    public void SendNotification(string recipient, string message)
    {
        _emailSender.SendEmail(recipient, message);
    }
}
#endregion

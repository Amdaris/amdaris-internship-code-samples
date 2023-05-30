NotificationService notificationService = new NotificationService(new EmailSender());

notificationService.SendNotification("Amdaris", "SOLID principles are amazing!");

#region Classes
public interface INotificationSender
{
    void SendNotification(string recipient, string message);
}

public class EmailSender : INotificationSender
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($"An email was sent to {recipient}! Message: {message}");
    }
}

public class NotificationService
{
    private INotificationSender _notificationSender;

    public NotificationService(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }

    public void SendNotification(string recipient, string message)
    {
        _notificationSender.SendNotification(recipient, message);
    }
}
#endregion
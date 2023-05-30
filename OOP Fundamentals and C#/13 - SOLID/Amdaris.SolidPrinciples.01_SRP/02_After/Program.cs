LoggerService loggerService = new LoggerService();

loggerService.LogMessage("Cool message which should be logged!");

NotificationService notificationService = new NotificationService();

notificationService.SendNotification("Amazing notification has been sended!");

#region Classes
public class LoggerService
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Log message: {message}");
    }
}

public class NotificationService
{
    public void SendNotification(string notificationMessage)
    {
        Console.WriteLine($"Notification message: {notificationMessage}");
    }
}
#endregion
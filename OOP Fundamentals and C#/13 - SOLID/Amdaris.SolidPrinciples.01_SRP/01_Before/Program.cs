Logger logger = new Logger();

logger.LogMessage("Cool message which should be logged!");

logger.SendNotification("Amazing notification has been sended!");

#region Classes
public class Logger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Log message: {message}");
    }

    public void SendNotification(string notificationMessage)
    {
        Console.WriteLine($"Notification message: {notificationMessage}");
    }
}
#endregion
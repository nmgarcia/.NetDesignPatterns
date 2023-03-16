/*
 In this example, the abstraction is Notification, which has a reference to the INotificationChannel interface that is implemented by different types of concrete
notification(refined abstractions) channels (EmailNotificationChannel and SMSNotificationChannel).
The concrete implementations are EmailNotification and SMSNotification, which inherit from the abstraction and are responsible for sending a notification message
through the corresponding channel.
 */

namespace Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Notification
    {
        protected INotificationChannel _notificationChannel;

        public Notification(INotificationChannel notificationChannel)
        {
            _notificationChannel = notificationChannel;
        }

        public abstract void Send(string message);
    }

    /// <summary>
    /// Implementation
    /// </summary>
    public interface INotificationChannel
    {
        void SendNotification(string message);
    }

    /// <summary>
    /// Concrete Implementation 1
    /// </summary>
    public class EmailNotificationChannel : INotificationChannel
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending email notification: '{message}'.");
        }
    }

    /// <summary>
    /// Concrete Implementation 2
    /// </summary>
    public class SMSNotificationChannel : INotificationChannel
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending SMS notification: '{message}'.");
        }
    }

    /// <summary>
    /// Refined Abstraction 1
    /// </summary>
    public class EmailNotification : Notification
    {
        public EmailNotification(INotificationChannel notificationChannel) : base(notificationChannel)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending email notification.");
            _notificationChannel.SendNotification(message);
        }
    }

    /// <summary>
    /// Refined Abstraction 2
    /// </summary>
    public class SMSNotification : Notification
    {
        public SMSNotification(INotificationChannel notificationChannel) : base(notificationChannel)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending SMS notification.");
            _notificationChannel.SendNotification(message);
        }
    }

    

}
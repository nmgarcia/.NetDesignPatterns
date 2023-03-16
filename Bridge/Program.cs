namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationChannel emailNotificationChannel = new EmailNotificationChannel();
            INotificationChannel smsNotificationChannel = new SMSNotificationChannel();

            Notification emailNotification = new EmailNotification(emailNotificationChannel);
            emailNotification.Send("Hello! This is an email.");

            Notification smsNotification = new SMSNotification(smsNotificationChannel);
            smsNotification.Send("Hello! This is a text message.");
        }
    }
}
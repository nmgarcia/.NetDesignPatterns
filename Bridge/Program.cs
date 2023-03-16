namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ICanalDeNotificacion canalDeNotificacionPorEmail = new CanalDeNotificacionPorEmail();
            ICanalDeNotificacion canalDeNotificacionPorSMS = new CanalDeNotificacionPorSMS();

            Notificacion notificacionPorEmail = new NotificacionPorEmail(canalDeNotificacionPorEmail);
            notificacionPorEmail.Enviar("¡Hola! Este es un correo electrónico.");

            Notificacion notificacionPorSMS = new NotificacionPorSMS(canalDeNotificacionPorSMS);
            notificacionPorSMS.Enviar("¡Hola! Este es un mensaje de texto.");
        }
    }
}
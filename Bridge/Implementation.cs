/*
 En este ejemplo, la abstracción es Notificacion, que tiene una referencia a la interfaz ICanalDeNotificacion que es implementada por diferentes tipos
de canales de notificación concretos (CanalDeNotificacionPorEmail y CanalDeNotificacionPorSMS). 
Las implementaciones concretas son NotificacionPorEmail y NotificacionPorSMS, que heredan de la abstracción y tienen la responsabilidad de enviar un mensaje
de notificación a través del canal correspondiente.
 */

namespace Bridge
{
    /// <summary>
    /// Abstracción
    /// </summary>
    public abstract class Notificacion
    {
        protected ICanalDeNotificacion _canalDeNotificacion;

        public Notificacion(ICanalDeNotificacion canalDeNotificacion)
        {
            _canalDeNotificacion = canalDeNotificacion;
        }

        public abstract void Enviar(string mensaje);
    }

    /// <summary>
    /// Implementación
    /// </summary>
    public interface ICanalDeNotificacion
    {
        void EnviarNotificacion(string mensaje);
    }

    /// <summary>
    /// Implementación concreta 1
    /// </summary>
    public class CanalDeNotificacionPorEmail : ICanalDeNotificacion
    {
        public void EnviarNotificacion(string mensaje)
        {
            Console.WriteLine($"Notificación por correo electrónico: '{mensaje}'.");
        }
    }

    /// <summary>
    /// Implementación concreta 2
    /// </summary>
    public class CanalDeNotificacionPorSMS : ICanalDeNotificacion
    {
        public void EnviarNotificacion(string mensaje)
        {
            Console.WriteLine($"Notificación por mensaje de texto: '{mensaje}'.");
        }
    }

    /// <summary>
    /// Abstaccion Refinada 1
    /// </summary>
    public class NotificacionPorEmail : Notificacion
    {
        public NotificacionPorEmail(ICanalDeNotificacion canalDeNotificacion) : base(canalDeNotificacion)
        {
        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando notificación por correo electrónico.");
            _canalDeNotificacion.EnviarNotificacion(mensaje);
        }
    }

    /// <summary>
    /// Abstaccion Refinada 2
    /// </summary>
    public class NotificacionPorSMS : Notificacion
    {
        public NotificacionPorSMS(ICanalDeNotificacion canalDeNotificacion) : base(canalDeNotificacion)
        {
        }

        public override void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando notificación por mensaje de texto.");
            _canalDeNotificacion.EnviarNotificacion(mensaje);
        }
    }

}
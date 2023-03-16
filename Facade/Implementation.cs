/*
 En este ejemplo, el subsistema complejo es el SistemaDeVentaDeBoletos, que tiene múltiples métodos para realizar diferentes tareas en el proceso de venta de boletos.
La fachada FachadaDeVentaDeBoletos proporciona un método simplificado ComprarBoletos() que se encarga de llamar al conjunto de métodos del subsistema para realizar la 
venta de boletos.
El cliente interactúa únicamente con la fachada y no necesita conocer la complejidad del sistema de venta de boletos.
 */

namespace Facade
{
    /// <summary>
    /// Subsistema complejo
    /// </summary>
    public class SistemaDeVentaDeBoletos
    {
        public void SeleccionarPelicula(string pelicula)
        {
            Console.WriteLine($"La película '{pelicula}' ha sido seleccionada.");
        }

        public void SeleccionarHorario(DateTime horario)
        {
            Console.WriteLine($"El horario '{horario.ToString()}' ha sido seleccionado.");
        }

        public void SeleccionarAsientos(int[] asientos)
        {
            Console.WriteLine($"Los asientos '{string.Join(", ", asientos)}' han sido seleccionados.");
        }

        public void RealizarPago(int[] asientos, float precio)
        {
            float total = asientos.Length * precio;
            Console.WriteLine($"Se ha realizado el pago por un total de ${total}.");
        }

        public void ImprimirBoleto()
        {
            Console.WriteLine("El boleto ha sido impreso.");
        }
    }

    /// <summary>
    /// Fachada para el sistema de venta de boletos
    /// </summary>
    public class FachadaDeVentaDeBoletos
    {
        private readonly SistemaDeVentaDeBoletos _sistemaDeVentaDeBoletos;

        public FachadaDeVentaDeBoletos()
        {
            _sistemaDeVentaDeBoletos = new SistemaDeVentaDeBoletos();
        }

        public void ComprarBoletos(string pelicula, DateTime horario, int[] asientos, float precio)
        {
            _sistemaDeVentaDeBoletos.SeleccionarPelicula(pelicula);
            _sistemaDeVentaDeBoletos.SeleccionarHorario(horario);
            _sistemaDeVentaDeBoletos.SeleccionarAsientos(asientos);            
            _sistemaDeVentaDeBoletos.RealizarPago(asientos,precio);
            _sistemaDeVentaDeBoletos.ImprimirBoleto();
        }
    }
}

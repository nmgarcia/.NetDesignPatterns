namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaDeVentaDeBoletos fachadaDeVentaDeBoletos = new FachadaDeVentaDeBoletos();

            string pelicula = "Avengers: Endgame";
            DateTime horario = new DateTime(2023, 3, 14, 19, 30, 0);
            int[] asientos = { 1, 2, 3 };
            float precio = 10.50f;

            fachadaDeVentaDeBoletos.ComprarBoletos(pelicula, horario, asientos, precio);

        }
    }
}
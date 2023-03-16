namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketSellingSystemFacade ticketSellingSystemFacade = new TicketSellingSystemFacade();

            string movie = "Avengers: Endgame";
            DateTime showtime = new DateTime(2023, 3, 14, 19, 30, 0);
            int[] seats = { 1, 2, 3 };
            float price = 10.50f;

            ticketSellingSystemFacade.BuyTickets(movie, showtime, seats, price);


        }
    }
}
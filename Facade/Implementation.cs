/*
 In this example, the class TicketSellingSystem is the complex subsystem that handles operations related to ticket sales.
The class TicketSellingSystemFacade is the facade that provides a simplified interface for buying tickets.
The class Program is the client that uses the facade to buy tickets.
 */

namespace Facade
{
    /// <summary>
    /// Complex subsystem
    /// </summary>
    public class TicketSellingSystem
    {
        public void SelectMovie(string movie)
        {
            Console.WriteLine($"The movie '{movie}' has been selected.");
        }

        public void SelectShowtime(DateTime showtime)
        {
            Console.WriteLine($"The showtime '{showtime.ToString()}' has been selected.");
        }

        public void SelectSeats(int[] seats)
        {
            Console.WriteLine($"The seats '{string.Join(", ", seats)}' have been selected.");
        }

        public void MakePayment(float total)
        {
            Console.WriteLine($"The payment has been made for a total of ${total}.");
        }

        public void PrintTicket()
        {
            Console.WriteLine("The ticket has been printed.");
        }
    }

    /// <summary>
    /// Facade for the ticket selling system
    /// </summary>
    public class TicketSellingSystemFacade
    {
        private readonly TicketSellingSystem _ticketSellingSystem;

        public TicketSellingSystemFacade()
        {
            _ticketSellingSystem = new TicketSellingSystem();
        }

        public void BuyTickets(string movie, DateTime showtime, int[] seats, float price)
        {
            _ticketSellingSystem.SelectMovie(movie);
            _ticketSellingSystem.SelectShowtime(showtime);
            _ticketSellingSystem.SelectSeats(seats);
            float total = seats.Length * price;
            _ticketSellingSystem.MakePayment(total);
            _ticketSellingSystem.PrintTicket();
        }
    }   
}

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockMarket = new StockMarket();
            var investor1 = new Investor("John");
            var investor2 = new Investor("Sarah");

            stockMarket.Attach(investor1);
            stockMarket.Attach(investor2);

            stockMarket.StockPrice = 100.50f; // Output: John: Stock price has changed to 100.5, Sarah: Stock price has changed to 100.5

            stockMarket.Detach(investor2);

            stockMarket.StockPrice = 99.50f; // Output: John: Stock price has changed to 99.5
        }
    }
}
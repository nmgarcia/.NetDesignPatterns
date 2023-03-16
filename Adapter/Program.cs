namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle { Width = 5, Height = 10 };
            var triangle = new Triangle { Base = 8, Height = 6 };
            var triangleAdapter = new TriangleAdapter(triangle);

            Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Triangle area: {triangleAdapter.CalculateArea()}");
        }
    }
}
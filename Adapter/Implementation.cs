/*
 n the example we looked at, we had two interfaces for calculating the area of a shape - IShape and IAdvancedShape. 
We had an existing class Rectangle that implemented the IShape interface, but we wanted to use it as an IAdvancedShape interface.
So, we created an adapter class RectangleAdapter that implemented the IAdvancedShape interface and internally used the Rectangle class to calculate the area.

This allowed us to use the Rectangle class as if it were an IAdvancedShape object, without modifying its original implementation.
The adapter class acted as a bridge between the two interfaces, and the client was able to use the adapted object seamlessly.
 */
namespace Adapter
{
    /// <summary>
    /// Target
    /// </summary>
    public interface IShape
    {
        double CalculateArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
    /// <summary>
    /// Adaptee
    /// </summary>
    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }

    /// <summary>
    /// Adapter
    /// </summary>
    public class TriangleAdapter : IShape
    {
        private readonly Triangle _triangle;

        public TriangleAdapter(Triangle triangle)
        {
            _triangle = triangle;
        }

        public double CalculateArea()
        {
            return _triangle.GetArea();
        }
    }
}

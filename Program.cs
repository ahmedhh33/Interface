namespace Interfacebehavior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ishape circle = new Circle(4);
            Console.WriteLine("The area of Circle = "+circle.calculateArea());
            Console.WriteLine("The perimeter of Circle = "+circle.getperimeter());
            Ishape rectangle = new Rectangle(2, 3);
            Console.WriteLine("The area of Rectangle = " + rectangle.calculateArea());
            Console.WriteLine("The perimeter of Reectangle = " + rectangle.getperimeter());
        }

    }
}
namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle();

            Console.WriteLine("Circle 1 radius: ");
            circle1.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Circle 2 radius: ");
            circle2.Radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"Circle 1 - Perimeter: {circle1.Perimeter():F4}; Area: {circle1.Area():F4}");
            Console.WriteLine($"Circle 2 - Perimeter: {circle2.Perimeter():F4}; Area: {circle2.Area():F4}");
        }
    }
}

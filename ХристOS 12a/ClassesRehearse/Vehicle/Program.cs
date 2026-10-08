namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Vehicle brand:");
            vehicle.Brand = Console.ReadLine();
            Console.WriteLine("Vehicle speed:");
            vehicle.Speed = int.Parse(Console.ReadLine());

            Console.WriteLine("Bicycle brand:");
            bicycle.Brand = Console.ReadLine();
            Console.WriteLine("Bicycle speed:");
            bicycle.Speed = int.Parse(Console.ReadLine());

            vehicle.Move();
            bicycle.Move();
        }
    }
}

namespace Workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", 123, 1200000);
            Console.WriteLine(car.toString());
        }
    }
}
namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            newCar.Make = "Chevy";
            newCar.Model = "Corvette";
            newCar.Year = 2024;

            Console.WriteLine($"This is a {newCar.Year} {newCar.Make} {newCar.Model}");
        }
    }

    
}

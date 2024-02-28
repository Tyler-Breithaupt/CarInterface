namespace CarInterface;
public interface ICar
{
    string Model { get; set; }
    int Year { get; set; }

    void Start();
}

class Program
{
    public class Car : ICar
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine($"The {Year} {Model} is starting.");
        }
    }

    static void Main(string[] args)
    {
        ICar myCar = new Car();

        myCar.Model = "Chevy Malibu";
        myCar.Year = 2022;

        myCar.Start();

        Console.WriteLine($"Car Model: {myCar.Model}");
        Console.WriteLine($"Car Year: {myCar.Year}");

        Console.ReadLine(); // To keep the console window open
    }
}


namespace GA_AggregateAndContainment_DavidAbarca
{
    internal class Program
    {


        static void Main(string[] args)
        {
            ComputerExample();
            List<Engine> engines = new List<Engine>();
            engines.Add(new Engine(120)); // Slow engine
            engines.Add(new Engine(250)); // Fast engine

            Car myCar = new("Ford", "Escort", engines[1]); // Using the fast engine
            Engine fastEngine = new Engine(250);
            Engine slowerEngine = new Engine(120);

            engines.Add(fastEngine);
            engines.Add(slowerEngine);

            Suspension suspension = new Suspension(-.4f, 5, .5f);

            Car car = new Car("Ford", "Escort", fastEngine, suspension);
            Console.WriteLine(car.ToString());

            // Add this code to our main in program.cs
            Character donkeyKong = new Character(150, "Donkey Kong");
            GoKart goKart = new GoKart(donkeyKong);

            Console.WriteLine(goKart.ToString());

            Character toad = new Character(50, "Toad");
            GoKart goKartToad = new GoKart(toad);
            Console.WriteLine(goKartToad.ToString());
            Console.WriteLine("Before our try catch");
            try
            {
                goKart.TweakEngine(-50); // Invalid value
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
          


        }

        static void ComputerExample()
        {
            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel);
            Computer comp = new Computer(gc);

            Console.WriteLine("Computer Information:");
            Console.WriteLine("Graphics Card Brand: " + comp.GraphicsCard);
        }


    }
}
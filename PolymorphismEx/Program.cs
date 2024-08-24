namespace PolymorphismEx
{
    // A base class for all cars
    public class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("The car is driving.");
        }
    }

    // The race car drives fast
    public class RaceCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("The race car is driving fast!");
        }
    }

    // The truck drives slowly
    public class Truck : Car
    {
        public override void Drive()
        {
            Console.WriteLine("The truck is driving slowly with a heavy load.");
        }
    }

    // The fire truck drives to a fire
    public class FireTruck : Car
    {
        public override void Drive()
        {
            Console.WriteLine("The fire truck is driving to a fire with its siren on!");
        }
    }

    // In the main program:
    class Program
    {
        static void Main(string[] args)
        {
            Car myRaceCar = new RaceCar();
            Car myTruck = new Truck();
            Car myFireTruck = new FireTruck();

            myRaceCar.Drive();    // Output: The race car is driving fast!
            myTruck.Drive();      // Output: The truck is driving slowly with a heavy load.
            myFireTruck.Drive();  // Output: The fire truck is driving to a fire with its siren on!
        }
    }
}

// Polymorphism is like having one button that does different things for different cars,
// but they all know how to drive. In programming, it means different objects can perform the same action
// in their own way, depending on what kind of object they are.

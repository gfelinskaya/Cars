namespace Cars
{
    public class Program
    {
         static void Main()
        {
           Car simple = new Car("VH345345", "Black", 1.4f, 5, "diesel") 
           {
              Price = 20
           };

           Car ferrary = new SportCar("VH345456546", "Red", 5.0f, 3, "gas")
           {
              Price = 50
           };

           Car bugatti = new SportCar("VH345345455", "Yellow", 6.0f, 3, "gas")
           {
              Price = 60
           };

           Car[] garage = new Car[] { simple, ferrary, bugatti};

           foreach (Car car in garage)
           {
            car.Start();
            car.Accelerate();
            car.Stop();
           }
           
           foreach (Car car in garage) 
           {
                if (car is SportCar)
                {
                    SportCar sportCar = (SportCar)car;
                    sportCar.Start();
                    sportCar.Turbo();
                    sportCar.Accelerate();
                    sportCar.Stop();
                }
           }

            var myGarage = new Garage("Bravo", 100);
            myGarage.AddCar(ferrary);
            myGarage.AddCar(bugatti);
            Console.WriteLine($"Count of occupated places is {myGarage.OccupatedPlaces}");
            Console.WriteLine(myGarage.EmptyPlaces);
            Console.WriteLine(myGarage.Name);

            var myFerarri = myGarage["VH345456546"];

            if (myFerarri != null)
                Console.WriteLine($"Volume of engeen {myFerarri.EngineVolume}");


            var myGarage2 = new Garage("Tango", 200);
            myGarage2.AddCar(simple);
            Console.WriteLine($"Count of occupated places is {myGarage2.OccupatedPlaces}");
            Console.WriteLine(myGarage2.EmptyPlaces);

            Console.WriteLine(myGarage2["VH345345"].EngineVolume);

            var myCar = myGarage[1];

            if (myCar != null)
            {
                Console.WriteLine($"Color = {myCar.Color}");
            }
            else
            {
                Console.WriteLine("Car does not exist");
            }
        }
    }
}
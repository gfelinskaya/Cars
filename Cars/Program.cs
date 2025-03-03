namespace Cars
{
    public class Program
    {
         static void Main()
        {
           Car simple = new Car("Black", 1.4f, 5, "diesel", 20);
           Car ferrary = new SportCar("Red", 5.0f, 3, "gas", 50);
           Car bugatti = new SportCar("Yellow", 6.0f, 3, "gas", 60);

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
            sportCar.Stop();
            }
           }
        }
    }
}
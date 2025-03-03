namespace Cars
{
    public class SportCar : Car
    {
        public SportCar(string color, float engineVolume, uint doorsQuantity, string fuelType, float price) : base (color, engineVolume, doorsQuantity, fuelType, price)
        {
        }

        public void Turbo()
        { 
            Console.WriteLine("Turbo driving");
        }
    }
}
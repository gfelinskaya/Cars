namespace Cars
{
    public class SportCar : Car
    {
        public SportCar(string color, float engineVolume, byte doorsQuantity, string fuelType) 
          : base (color, engineVolume, doorsQuantity, fuelType)
        {
        }

        public void Turbo()
        { 
            Console.WriteLine("Turbo driving");
        }
        public override void Accelerate()
        { 
            currentSpeed += 40;
            Console.WriteLine($"Accelerating. Current speep {currentSpeed}");
        }
    }
}
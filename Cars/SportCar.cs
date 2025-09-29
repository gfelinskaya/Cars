namespace Cars
{
    public class SportCar : Car
    {
        public SportCar(string vin, string color, float engineVolume, byte doorsQuantity, string fuelType) 
          : base (vin, color, engineVolume, doorsQuantity, fuelType)
        {
        }

        public void Turbo()
        { 
            Console.WriteLine("Turbo driving");
        }
        public override void Accelerate()
        {            
            currentSpeed += 40;
            if (currentSpeed > MaxSpeed)
                throw new SpeedLimitOverflowException(currentSpeed);

            Console.WriteLine($"Accelerating. Current speep {currentSpeed}");
        }
    }
}
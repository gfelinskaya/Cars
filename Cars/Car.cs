namespace Cars
{
    public class Car
    {
        protected uint currentSpeed;

        public string VIN { get; }
        public string Color { get; set;}
        public float EngineVolume { get;}
        public byte DoorsQuantity { get;}
        public string FuelType { get;}
        public float Price { get; set;}

        public Car (string vin, string color, float engineVolume, byte doorsQuantity, string fuelType)
        {
          VIN = vin;
          Color = color;
          EngineVolume = engineVolume;
          DoorsQuantity = doorsQuantity;
          FuelType = fuelType;
        }
        public void Start()
        { 
            Console.WriteLine("Start driving");
        }
        public void Stop()
        {
            Console.WriteLine("Stop driving");
        }
        public virtual void Accelerate()
        {
            currentSpeed += 20;
            Console.WriteLine($"Accelerating. Current speep {currentSpeed}");
        }
        }
    }
namespace Cars
{
    public class Car
    {
        public string Color { get; set;}
        public float EngineVolume { get;}
        public byte DoorsQuantity { get;}
        public string FuelType { get;}
        public float Price { get; set;}

        public Car (string color, float engineVolume, byte doorsQuantity, string fuelType)
        {
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
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }
        }
    }
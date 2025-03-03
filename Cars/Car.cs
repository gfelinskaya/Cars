namespace Cars
{
    public class Car
    {
        public string Color { get;}
        public float EngineVolume { get;}
        public uint DoorsQuantity { get;}
        public string FuelType { get;}
        public float Price { get; set;}

        public Car (string color, float engineVolume, uint doorsQuantity, string fuelType, float price)
        {
          Color = color;
          EngineVolume = engineVolume;
          DoorsQuantity = doorsQuantity;
          FuelType = fuelType;
          Price = price;
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
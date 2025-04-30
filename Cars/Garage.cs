namespace Cars;

class Garage
{
    private readonly Car[] cars;
    private int carCounter = 0;

    private readonly string name;
    public string Name { get => name; }

    public Garage(string name, uint capacity)
    {
        this.name = name;    
        cars = new Car[capacity];     
    }

    public void AddCar(Car car)
    {
        if (carCounter < cars.Length)
        {
            cars[carCounter++] = car;
        }
    }

    public int EmptyPlaces { get => cars.Length - carCounter; }

    public int OccupatedPlaces { get => carCounter; }

    public Car this[string index]
    {
        get
        {
            for (int i = 0; i < carCounter; i++)
            {
                if (cars[i].VIN.ToLower() == index.ToLower())
                    return cars[i];
            }

            return null;
        }
    }

    public Car this[int index]
    {
        get 
        {
            if (index >= 0 && index <= carCounter)
            { 
                return cars[index];
            }

            return null;
        }
    }

}

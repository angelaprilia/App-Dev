public class Car
{
    private string Make;
    private string Model;
    private int Year;
    private double Price;
    private string Type;

    public string getMake()
    {
        return Make;
    }
    public void setMake(string make)
    {
        Make = make;
    }
    public string getModel()
    {
        return Model;
    }
    public void setModel(string model)
    {
        Model = model;
    }
    public int getYear()
    {
        return Year;
    }
    public void setYear(int year)
    {
        Year = year;
    }
    public double getPrice()
    {
        return Price;
    }
    public void setPrice(double price)
    {
        Price = price;
    }
    public string getType()
    {
        return Type;
    }
    public void setType(string type)
    {
        Type = type;
    }
    public class ElectricCar : Car
    {
        private int BatteryCapacity;
        public int getBatteryCapacity()
        {
            return BatteryCapacity;
        }
        public void setBatteryCapacity(int battery)
        {
            BatteryCapacity = battery;
        }
    }
    public class HybridCar : Car
    {
        private int GasTankSize;
        public int getGasTankSize()
        {
            return GasTankSize;
        }
        public void setGasTankSize(int gastank)
        {
            GasTankSize = gastank;
        }
        private int BatteryCapacity;
        public int getBatteryCapacity()
        {
            return BatteryCapacity;
        }
        public void setBatteryCapacity(int battery)
        {
            BatteryCapacity = battery;
        }
    }
    public class GasolineCar : Car
    {
        private int GasTankSize;
        public int getGasTankSize()
        {
            return GasTankSize;
        }
        public void setGasTankSize(int gastank)
        {
            GasTankSize = gastank;
        }
    }
}
public class Dealership
{
    private string Name;
    private string Location;
    private List<Car> Cars = new List<Car>();
    private List<Sale> saleshistory = new List<Sale>();
    private string CarMakeSale;
    private string CarModelSale;
    public string getName()
    {
        return Name;
    }
    public void setName(string name)
    {
        Name = name;
    }
    public string getLocation()
    {
        return Location;
    }
    public void setLocation(string location)
    {
        Location = location;
    }
    public List<Car> getCars()
    {
        return Cars;
    }
    public void setCars(List<Car> cars)
    {
        Cars = cars;
    }
    public void AddCar(Car car)
    {
        Cars.Add(car);
    }
    public string getCarMakeSale()
    {
        return CarMakeSale;
    }
    public void setCarMakeSale(string carmakesale)
    {
        CarMakeSale = carmakesale;
    }
    public string getCarModelSale()
    {
        return CarModelSale;
    }
    public void setCarModelSale(string carmodelsale)
    {
        CarModelSale = carmodelsale;
    }
    public void RemoveCar(string carMake, string carModel)
    {
        foreach (Car car in Cars)
        {
            if ((carMake == car.getMake()) && carModel == car.getModel())
            {
                Cars.Remove(car);
                break;
            }

        }
    }
    public void PrintCars()
    {
        foreach (Car car in Cars)
        {
            Console.WriteLine();
            Console.WriteLine("Make : " + car.getMake());
            Console.WriteLine("Model : " + car.getModel());
            Console.WriteLine("Year : " + car.getYear());
            Console.WriteLine("Price : " + car.getPrice());
            Console.WriteLine("Type : " + car.getType());
        }
    }
    public void MakeSale(Sale sale)
    {
        foreach (Car car in Cars)
        {
            if (sale.getCar() == car)
            {
                saleshistory.Add(sale);
                Cars.Remove(car);
                break;
            }
        }
    }
    public void PrintSale()
    {
        foreach (Sale sale in saleshistory)
        {
            Console.WriteLine();
            Console.WriteLine("Customer Name : " + sale.getCustomerName());
            Console.WriteLine("Customer Car Make: " + sale.getCarMakeSale());
            Console.WriteLine("Customer Car Model: " + sale.getCarModelSale());
            Console.WriteLine("Customer Price Paid : " + sale.getPricePaid());
        }
        Console.ReadKey();
    }
    public class Sale : Dealership
    {
        private string CustomerName;
        private Car Car;
        private double PricePaid;
        public string getCustomerName()
        {
            return CustomerName;
        }
        public void setCustomerName(string customername)
        {
            CustomerName = customername;
        }
        public Car getCar()
        {
            return Car;
        }
        public void setCar(Car car)
        {
            Car = car;
        }
        public double getPricePaid()
        {
            return PricePaid;
        }
        public void setPricePaid(double pricepaid)
        {
            PricePaid = pricepaid;
        }
        
        
    }

}

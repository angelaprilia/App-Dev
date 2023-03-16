using System.ComponentModel.Design;
using static Car;
using static Dealership;

internal class Program
{
    private static void Main(string[] args)
    {
        int menu = 0;
        int menu2 = 0;
        string electricCarmake;
        string electricCarmodel;
        int electricCaryear;
        double electricCarprice;
        int electricCarBC;
        string hybridCarmake;
        string hybridCarmodel;
        int hybridCaryear;
        double hybridCarprice;
        int hybridCarGTS;
        int hybridCarBC;
        string gasolineCarmake;
        string gasolineCarmodel;
        int gasolineCaryear;
        double gasolineCarprice;
        int gasolineCarGTS;
        string electricCartype;
        Dealership dealership = new Dealership();
        Console.Write("Add Dealership name : ");
        dealership.setName(Console.ReadLine());
        Console.Write("Add Dealership location : ");
        dealership.setLocation(Console.ReadLine());
        while (menu != 6)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add Car \n2. Remove Car \n3. Print All Cars \n4. Make Sales \n5. Print Sales \n6. Exit \n-----------------------");
            Console.Write("Menu Choice : ");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Electric Car ");
                Console.WriteLine("2. Hybrid Car ");
                Console.WriteLine("3. Gasoline Car ");
                Console.WriteLine("---------------------------------");
                Console.Write("Car Choice : ");
                menu2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------------------");

                if (menu2 == 1)
                {
                    ElectricCar electricCar = new ElectricCar();
                    electricCar.setType("Electric Car");
                    Console.Write("Input Car Make :  ");
                    electricCarmake = Console.ReadLine();
                    electricCar.setMake(electricCarmake);
                    Console.Write("Input Car Model : ");
                    electricCarmodel = Console.ReadLine();
                    electricCar.setModel(electricCarmodel);
                    Console.Write("Input Car Year : ");
                    electricCaryear = Convert.ToInt32(Console.ReadLine());
                    electricCar.setYear(electricCaryear);
                    Console.Write("Input Car Price : ");
                    electricCarprice = Convert.ToInt64(Console.ReadLine());
                    electricCar.setPrice(electricCarprice);
                    Console.Write("Input Car Battery Capacity : ");
                    electricCarBC = Convert.ToInt32(Console.ReadLine());
                    electricCar.setBatteryCapacity(electricCarBC);
                    dealership.AddCar(electricCar);
                    Console.Clear();
                }
                else if (menu2 == 2)
                {
                    HybridCar hybridCar = new HybridCar();
                    hybridCar.setType("Hybrid Car");
                    Console.Write("Input Car Make :  ");
                    hybridCarmake = Console.ReadLine();
                    hybridCar.setMake(hybridCarmake);
                    Console.Write("Input Car Model : ");
                    hybridCarmodel = Console.ReadLine();
                    hybridCar.setModel(hybridCarmodel);
                    Console.Write("Input Car Year : ");
                    hybridCaryear = Convert.ToInt32(Console.ReadLine());
                    hybridCar.setYear(hybridCaryear);
                    Console.Write("Input Car Price : ");
                    hybridCarprice = Convert.ToInt64(Console.ReadLine());
                    hybridCar.setPrice(hybridCarprice);
                    Console.Write("input Car Gas Tank Size : ");
                    hybridCarGTS = Convert.ToInt32(Console.ReadLine());
                    hybridCar.setGasTankSize(hybridCarGTS);
                    Console.Write("Input Car Battery Capacity : ");
                    hybridCarBC = Convert.ToInt32(Console.ReadLine());
                    hybridCar.setBatteryCapacity(hybridCarBC);
                    dealership.AddCar(hybridCar);
                    Console.Clear();
                }
                else if (menu2 == 3)
                {
                    GasolineCar gasolineCar = new GasolineCar();
                    gasolineCar.setType("Gasoline Car");
                    Console.Write("Input Car Make :  ");
                    gasolineCarmake = Console.ReadLine();
                    gasolineCar.setMake(gasolineCarmake);
                    Console.Write("Input Car Model : ");
                    gasolineCarmodel = Console.ReadLine();
                    gasolineCar.setModel(gasolineCarmodel);
                    Console.Write("Input Car Year : ");
                    gasolineCaryear = Convert.ToInt32(Console.ReadLine());
                    gasolineCar.setYear(gasolineCaryear);
                    Console.Write("Input Carc Price : ");
                    gasolineCarprice = Convert.ToInt64(Console.ReadLine());
                    gasolineCar.setPrice(gasolineCarprice);
                    Console.Write("Input Car Gas Tank Size : ");
                    gasolineCarGTS = Convert.ToInt32(Console.ReadLine());
                    gasolineCar.setGasTankSize(gasolineCarGTS);
                    dealership.AddCar(gasolineCar);
                    Console.Clear();
                }
            }
            else if (menu == 2)
            {
                Console.Write("Car Make : ");
                string removeCarmake = Console.ReadLine();
                Console.Write("Car Model : ");
                string removeCarmodel = Console.ReadLine();
                dealership.RemoveCar(removeCarmake, removeCarmodel);
                Console.Clear();
            }
            else if (menu == 3)
            {
                dealership.PrintCars();
                Console.ReadKey();
                Console.Clear();
            }
            else if (menu == 4)
            {
                Sale sale = new Sale();
                Console.Write("Customer Name : ");
                sale.setCustomerName(Console.ReadLine());
                Console.Write("Customer Car Make : ");
                sale.setCarMakeSale(Console.ReadLine());
                Console.Write("Customer Car Model : ");
                sale.setCarModelSale(Console.ReadLine());
                Console.Write("Customer Price Paid : ");
                sale.setPricePaid(Convert.ToDouble(Console.ReadLine()));
                foreach (Car car in dealership.getCars())
                {
                    if (car.getMake() == sale.getCarMakeSale() && car.getModel() == sale.getCarModelSale())
                    {
                        sale.setCar(car);
                        dealership.MakeSale(sale);
                        break;
                    }
                }
            }
            else if (menu == 5)
            {
                dealership.PrintSale();
                Console.ReadKey();
            }
        }
    }
}
using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "Volkswagen",
                Model = "MK2",
                Year = 1989,
                FuelQuantity = 200,
                FuelConsumption = 5,

            };
            car.Drive(300);
            Console.WriteLine(car.FuelConsumption);
            Console.WriteLine(car.WhoAmI());

            Car firstCar = new Car();
            Car secondCar = new Car("Ford", "Mondeo", 2012);
            Car thirdCar = new Car("BMW", "E39", 2001, 10, 10);
           
        }
    }
}

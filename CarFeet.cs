using System;

namespace FleetManagement
{
    class Car
    {
        public string LicensePlate { get; set; }
        public string Model { get; set; }
        public string DriverName { get; set; }

        public Car(string licensePlate, string model, string driverName)
        {
            LicensePlate = licensePlate;
            Model = model;
            DriverName = driverName;
        }

        public string ToString()
        {
            return $"Лицензия: {LicensePlate}, Модель: {Model}, Водитель: {DriverName}";
        }
    }

    class Fleet
    {
        private Car[] cars;


        public Fleet(params Car[] initialCars)
        {
            cars = initialCars;
        }


        public Car this[int index]
        {
            get
            {
                if (index < 0 || index >= cars.Length)
                    throw new IndexOutOfRangeException("Некорректный индекс");
                return cars[index];
            }
            set
            {
                if (index < 0 || index >= cars.Length)
                    throw new IndexOutOfRangeException("Некорректный индекс");
                cars[index] = value;
            }
        }


        public Car this[string licensePlate]
        {
            get
            {
                foreach (var car in cars)
                {
                    if (car.LicensePlate == licensePlate)
                        return car;
                }
                return null;
            }
            set
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].LicensePlate == licensePlate)
                    {
                        cars[i] = value;
                        return;
                    }
                }
                Array.Resize(ref cars, cars.Length + 1);
                cars[cars.Length - 1] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Fleet fleet = new Fleet(
                new Car("A123BC", "Volvo XC90", "Lusine Kazaryan"),
                new Car("B456CD", "toyota supra", "Liza Mishenko"),
                new Car("C789DE", "jiguli", "Maksim ")
            );

            Console.WriteLine("Автомобиль по индексу 1:");
            Console.WriteLine(fleet[1].ToString());

            Console.WriteLine("Автомобиль с номером A123BC:");
            Console.WriteLine(fleet["A123BC"].ToString());

            Console.WriteLine("Добавляем новый автомобиль с номером D012EF");
            fleet["D012EF"] = new Car("D012EF", "Mercedes-Benz GLC", "Oleg Sidorov");

            Console.WriteLine("Проверка добавленного автомобиля:");
            Console.WriteLine(fleet["D012EF"].ToString());
        }
    }
}

using System;
namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "X3", StickerPrice = 51000, Year = 2001 },
                new Car() { VIN = "B1", Make = "Toyato", Model = "SS01", StickerPrice = 22000, Year = 2010 },
                new Car() { VIN = "C1", Make = "Maruthi", Model = "SS01", StickerPrice = 45000, Year = 2005 },
                new Car() { VIN = "D1", Make = "Renault", Model = "SS01", StickerPrice = 63000, Year = 2012 },
                new Car() { VIN = "E1", Make = "BMW", Model = "SS01", StickerPrice = 15000, Year = 2010 },
            };
            //LINQ Query
            /*
            var bmws = from Car in myCars
                       where Car.Model == "SS01"
                       && Car.Year==2010
                       select Car;
            */
            /*
            var orderedCar = from Car in myCars
                             orderby Car.Year descending
                             select Car;
            */
            var newCars = from Car in myCars
                       where Car.Make == "BMW"
                       && Car.Year == 2010
                       select new { Car.Make,Car.Model};
            Console.WriteLine(newCars.GetType());

            //LINQ method

            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year==2010 );
            //var orderedCar = myCars.OrderByDescending(p => p.Year);
            /*var firstBMW = myCars.OrderByDescending(p=>p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);*/
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2009);
            //myCars.ForEach(p => p.StickerPrice -= 3000);

            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p=>p.Make=="Toyota"));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            /*
            foreach (var car in orderedCar) {
                Console.WriteLine("{0} {1} {2}",car.Year, car.Model, car.VIN);
            }*/

            Console.WriteLine(myCars.GetType());
            var orderedCar = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCar.GetType());

            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double StickerPrice { get; set; }
        public int Year { get; set; }
    }
}
namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.MyMethod();
            /*
            myCar.Make = "Maruthi";
            myCar.Model = "Alto";
            myCar.Year = 2010;
            myCar.Color = "Blue";
            

            Car myThirdCar = new Car("Maruthi","800",2000,"Red");
            Car myOtherCar; //Copying the address
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "Renult";
            //Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            myCar = null; //removing all the references to the object
            */
            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        /*
        public Car()
        {
            // You could load form a configuration file
            // a database,etc.
            this.Make = "Nissan";//refers this instance of the object....Optional

        }
        public Car(string make,string model,int year,string color)
        {
            Make = make;
            Model = model;
            Year = year;    
            Color = color;

        }
        */
        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
        }
    }
}
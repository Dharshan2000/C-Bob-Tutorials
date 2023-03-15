using System.Collections;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Car car1 = new Car(); ;
            car1.Make = "Maruthi suzuki";
            car1.Model = "Alto 800";
            car1.VIN = "A1";

            Car car2= new Car();
            car2.Make = "Renault";
            car2.Model = "Kwid";
            car2.VIN = "B2";

            Book b1= new Book();
            b1.Author = "Chetan Bhagat";
            b1.Title = "Girl in the room 105";
            b1.ISBN = "0-000-00000-0";
            /*
            //ArrayList are Dynamically sized
            //Features like sorting , remove items
            ArrayList myArrayList=new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);//No easy way to limit the type of data inside of the array
            myArrayList.Add(b1);
            myArrayList.Remove(b1);
            foreach(Car car in myArrayList) {
                Console.WriteLine(car.Make);
       
            }
            */
            /*
            // List<T> Generic Collections

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            
            foreach (Car car in myList) { 
                Console.WriteLine(car.Model);
            }
            

            // Dictionary<Tkey , TValue>
            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B2"].Make);
            */


            //string[] names={"Dharshan", "Divya","Johnshon","Anand"};
            //Object Initializer Systax
            //No need for Constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750Li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "Supra", VIN = "D4" };

            // Collection Initializer

            List<Car> myList = new List<Car>()
            {
                new Car {Make = "Maruthi Suzuki",Model="Alto LXi",VIN = "E5"},
                new Car {Make = "Renault",Model="Duster",VIN = "F5" }
            };

            Console.ReadLine();
        
        
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
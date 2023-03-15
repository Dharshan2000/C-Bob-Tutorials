namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hi hello");
            Console.Write("Choose a door : 1,2,3:");
            string userValue = Console.ReadLine(); ;
            if (userValue == "1")
            {
                string message = "You won a new Car";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a bike";
                Console.WriteLine(message);
            }
            else if (userValue == "3") {
                string message = "you won a chocalate";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Sorry , invalid door number ";
                message = message + " You lost the game";
                Console.WriteLine(message);
            }
            Console.ReadLine();
            */

            Console.WriteLine("Hi hello");
            Console.Write("Choose a door : 1,2,3:");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "car" : "Bike";
            /*Console.Write("You won a ");
            Console.Write(message);
            Console.Write(".");*/
            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
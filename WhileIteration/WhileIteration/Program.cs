namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if(result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if(result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3") 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Number");
            Console.Write("Type a number");
            int result = int.Parse(Console.ReadLine()); //Allow us to take string into a integer
            int counter = 1;
            while(counter < result+1)
                {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }

            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.WriteLine("Guessing game");

            Random myRandom = new Random();
            int randomnumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 to 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomnumber.ToString()) 
                    incorrect = false;
                else
                    Console.WriteLine("Wrong");
            } while (incorrect);
            Console.WriteLine("Correct! It took {0} guess ",guesses);
            Console.ReadLine();
        }
    }
}
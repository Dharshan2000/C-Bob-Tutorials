namespace SimpleMethod
{
    class Program
    {
        static void Main(String[] args) 
        {
            Console.Write("Reveresed letters : ");
            string reverseFirstName=HellowWorld("Dharshan");
            string reverseLastName=HellowWorld("Prasath");
            string reverseCity=HellowWorld("Kotagiri");
            //Console.Write(String.Format("{0} {1} {2}", reverseFirstName, reverseLastName, reverseCity);
           //Console.ReadLine();
           DisplayResult(reverseFirstName,reverseLastName,reverseCity);
            Console.ReadLine();
        }

        private static string HellowWorld(string message)
        {
            char[] messageArray = message.ToArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
        private static void DisplayResult(string reversedFirstName,string reversedLastName, string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}", reverseFirstName, reverseLastName, reverseCity);
            Console.ReadLine();
        }
    }
}
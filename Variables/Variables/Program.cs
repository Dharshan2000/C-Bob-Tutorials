// See https
// ://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Variables
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* int x;
             int y;

             x = 7;
             y = x + 3;
             Console.Clear();
             Console.WriteLine(y);
             Console.ReadLine();
            */
            Console.WriteLine("What is your name");
            Console.WriteLine("Type your name: ");
            string myFirstName;
            myFirstName=Console.ReadLine();

            string myLastName;
            Console.Write("Type your lastname: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello "+myFirstName+" "+myLastName);
        }
    }
}
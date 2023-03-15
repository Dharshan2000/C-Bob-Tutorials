using MyCodelibrary;
using System;
namespace MyClient
{
    class Program
    {
        private static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value= myScrape.ScrapeWebpage("https://msdn.microsoft.com");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
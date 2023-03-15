namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                string content = File.ReadAllText(@"C:\Users\Dharshan\source\repos\Testtextfil.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch(FileNotFoundException ex) 
            {
                Console.WriteLine("There is a problem");
                Console.WriteLine("Make sure the filename is correct");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("There is a problem");
                Console.WriteLine("Make sure the directory is correct");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is a problem");
                Console.WriteLine(ex.Message);
            }
            finally { 
                //Code to finalize
                //Setting objects to null
                //Closing database connections
                   }
            Console.ReadLine();
        }
    }

}
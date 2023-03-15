using System.Text;

namespace WorkingwithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "My \"so-called\" life";
            string myString2 = "What if I need a\nnew line";
            string myString3 = "Go to your c:\\ drive";
            string myString4 = @"Go to your c:\ drive";
            string myString5 = String.Format("{0} = {1}", "First", "Second");
            string myString6 = string.Format("{0:C}", 123.45);
            string myString7 = string.Format("{0:N}", 1234567890);
            string myString8 = string.Format("Percentage : {0:P}", .123);
            string myString9 = string.Format("Phone No : {0:(##) ##########}", 911234567890);
            string myString10 = "We are strangers from now ";
            myString10 = myString10.Substring(6,10);
            string myString11 = myString10.ToUpper();
            string myString12 = myString10.Replace(" ", "--");
            
            Console.WriteLine(myString);
            Console.WriteLine(myString2);
            Console.WriteLine(myString3);
            Console.WriteLine(myString4);
            Console.WriteLine(myString5);
            Console.WriteLine(myString6);
            Console.WriteLine(myString7);
            Console.WriteLine(myString8);
            Console.WriteLine(myString9);
            Console.WriteLine(myString10);  
            Console.WriteLine(myString11);
            Console.WriteLine(myString12);
            //myString10 = myString10.Remove(6,8);
            //string mystr = String.Format("Length before: {0} -- Length after: {1}", myString10.Trim().Length);
            string str = "";
            for(int i= 0;i<100;i++)
            {
                str += "--" + i.ToString();
            }
            StringBuilder mystr=new StringBuilder();
            for( int i= 0;i<100; i++)
            {
                mystr.Append("--");
                mystr.Append(i);f
            }
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
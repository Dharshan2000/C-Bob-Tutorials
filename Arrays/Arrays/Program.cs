namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new int[5];
            numbers[0]=4;
            numbers[1]=5;
            numbers[2]=6;
            numbers[3]=7;
            numbers[4]=8;
            */
            /*for(int i=0; i<numbers.Length; i++)
            {
                numbers[i]=Console.ReadLine();
            }*/
            string[] names = new string[] { "Dharshan", "Indra", "Divyashree", "Dinesh" };
            /*for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i] + " ");
            }
            Console.ReadLine();
            */
            /*foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */
            string zig = "You can get what u want if u help enough other people"+"get what they want";
            char[] charArray=zig.ToCharArray(); 
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
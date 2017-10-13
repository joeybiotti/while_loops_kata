using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
           
           do
           {
               Console.Write("Enter a number: ");
               
               string line = Console.ReadLine();
               
               Int32.TryParse(line, out value);
           }
           while (value <= 10);
           
           Console.WriteLine("The number was bigger than 10!");

           Console.ReadLine();
        }
    }
}

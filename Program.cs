using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            while(value != 5)
            {
                Console.WriteLine("Enter the number 5: ");
                string line = Console.ReadLine();

                Int32.TryParse(line, out value);
            }

            Console.WriteLine("That's it!");
            Console.ReadLine();
        }
    }
}

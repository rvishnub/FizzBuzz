using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz:  identify the multiples of 3 and 5.");
            Console.WriteLine();


            int index;
            int startRange = 0;
            int endRange = 0;

            while (startRange >= endRange)
            {
                try
                {
                    Console.WriteLine("Enter start of range:");
                    startRange = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter end of range");
                    endRange = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Your entries are not valid.  Start of range must be less than end of range.  Try again.");
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Your entries are not valid.  Entries must be integers.  Try again.");
                }
            }


            try
            {
                for (index = startRange; index <= endRange; index++)
                {
                    if (index % 3 == 0 && index % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (index % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else if (index % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
            }
            catch
            {
            }

            Console.WriteLine("Press Enter to close");
            Console.ReadLine();


        }

    }

}
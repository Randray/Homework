using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give point limit:");

            string line = Console.ReadLine();
            int number=12321;

            int.TryParse(line, out number);
            if (number >= 0 && number <= 1)
            {
                Console.WriteLine("School number is 0");
            }
            else if (number > 1 && number<= 3)
            {
                Console.WriteLine("School number is 1");
            }
            else if (number > 3 && number <= 5)
            {
                Console.WriteLine("School number is 2");
            }
            else if (number > 5 && number <= 7)
            {
                Console.WriteLine("School number is 3");
            }
            else if (number > 7 && number <= 9)
            {
                Console.WriteLine("School number is 4");
            }
            else if (number > 9 && number <= 12)
            {
                Console.WriteLine("School number is 5");
            }
            else
            {
                Console.WriteLine("My boi do you know de whay");
            }

           Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classtask
{
    class Program
    {
        static void Main(string[] args)
        {/*
            double i = double.MaxValue;

            Console.WriteLine("i: " + i);
            Console.Read(); */


            int number = 0;
            string lien = Console.ReadLine();

            bool resul = Int32.TryParse(lien, out number);
            if (resul)
            {
                Console.WriteLine("Sucsses " + number);
            }

            else
            {
                Console.WriteLine("NANI");
            }

            Console.Read();

        }
    }
}

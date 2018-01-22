using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCat(99);
            Console.WriteLine("CatCount: " + CATSCOUT.CatCount());
            

        }

        static void CreateCat (int num)
        {
            int i;
            for (i = 0; i < 99; i++)
            {
                CATSCOUT cat = new CATSCOUT();


            }



        }


    }
}

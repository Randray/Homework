using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._2
{
    class Elevator
    {
        private int floor = 1;
        private string line;

     

        public void Whatfloor()
        {
            Console.Write("Give a new floor number (1-5) >");
            line = Console.ReadLine();


             Int32.TryParse(line, out floor);
            if (floor >= 1 && floor <= 5)
            {
                

                Console.WriteLine("Elevator is now in floor : " + floor);



            }
            else if (floor < 0)
            {
                Console.WriteLine("Floor is too small!");
            }
            else if (floor > 5)
            {
                Console.WriteLine("Floor is too big!");
            }
            else
            {
                Console.WriteLine("NANI!!!");
            }




        }






    }
}

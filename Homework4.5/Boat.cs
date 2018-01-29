using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._5
{
    class Boat: Vehicle
    {

        public string Type { get; set; }
        public int Seat { get; set; }
        public void ToStringBoat()
        {
            Console.WriteLine("Boat info:");
            Console.WriteLine(" - Name: " + Name + " Model: " + Model + " MadeIn: " + MadeIn + " Boat type " + Type + " HMS: " + Seat);
        }

    }
}

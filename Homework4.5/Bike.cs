using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._5
{
    class Bike: Vehicle
    {




        public string GearWheels;

        public string GearName { get; set; }

        public void ToStringBike()
        {
            Console.WriteLine("Bike info:");
            Console.WriteLine(" - Name: "+ Name+ " Model: "+ Model+ " MadeIn: "+ MadeIn+ " GearWheels: "+ GearWheels+ "GearName: "+ GearName);
        }




    }
}

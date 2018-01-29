using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike();
            Boat boat1 = new Boat();
            Bike bike2 = new Bike();
            Boat boat2 = new Boat();

            bike1.Name = "Jopo";
            bike1.Model = "Street";
            bike1.MadeIn = 2016;
            bike1.Color = "Blue";
            bike1.GearWheels = "False";

            bike2.Name = "Tunturi";
            bike2.Model = "StreetPower";
            bike2.MadeIn = 2010;
            bike2.Color = "Black";
            bike2.GearWheels = "True";
            bike2.GearName = "Shimano";

            boat1.Name = "Suvi";
            boat1.Model = "S9000";
            boat1.MadeIn = 1990;
            boat1.Color = "White";
            boat1.Seat = 3;
            boat1.Type = "Rowboat";

            boat2.Name = "Yamaha";
            boat2.Model = "1000";
            boat2.MadeIn = 2010;
            boat2.Color = "Yellow";
            boat2.Seat = 5;
            boat2.Type = "Motorboat";

            bike1.ToStringBike();
            bike2.ToStringBike();
            boat1.ToStringBoat();
            boat2.ToStringBoat();

            Console.ReadLine();





        }
    }
}

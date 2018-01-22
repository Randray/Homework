using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._1
{
    class Tank
    {
        private string name;
        private string type;
        private int crewCount;
        private float speed=0;
        private readonly float speedMax = 100;
        


        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public int CrewCout
        {
            get { return crewCount; }
            set
            {
                if (value >= 2 && value <= 6) { crewCount = value; }
                else if (value < 2) Console.WriteLine("Too few crew members to drive this vehicle.");
                else
                {
                    Console.WriteLine("You all won't fit in to the vehicle.");
                }
            }
        }


        public float Speed { get { return speed; } }





        public void AccerelateTo(float k)
        {
            
        
            if(k >= 0 && k <= speedMax)
            {
                speed = k;
                Console.WriteLine("Your speed is " + speed);
            }
            else if (k<0)
            {
                Console.WriteLine("You can't slow down with this");
            }
            else if (k > speedMax)
            {
                Console.WriteLine("This tank cant go that fast--- setting to Maxspeed");
                speed = speedMax;
            }
            else
            {
                Console.WriteLine("NANI");
            }
        }


        public void SlowTo(float o)
        {
           
            if (o >= 0 && o <= speedMax)
            {
                speed = o;
                Console.WriteLine("Your speed is " + speed);
            }
            else if (o < 0)
            {
                Console.WriteLine("You can't slow down with this");
            }
            else if (o > speedMax)
            {
                Console.WriteLine("This tank cant go that fast--- setting to Maxspeed");
                speed = speedMax;
            }
            else
            {
                Console.WriteLine("NANI");
            }
        }
        public void Tostring()
        {
            Console.WriteLine("Tank:");
            Console.WriteLine("--Name: "+name);
            Console.WriteLine("--Type: " +type);
            Console.WriteLine("--Crewsize: " +crewCount);
            Console.WriteLine("--Speed: "+ speed);
        }
    }


     





    }


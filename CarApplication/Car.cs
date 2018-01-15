using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {

        private static int Maxspeed = 200;
        private int speed;

        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public int Speed {

            get { return speed; }
            set {
                if (speed <= Maxspeed) speed = value;
                else speed = Maxspeed;
                    }




        }
        public bool FuzzyDices { get; set;}
        public int DoorCount { get; set; }

        

        //methods

        public void Accelerate()
        {
            Speed += 5;
        }

        // method to slow down
        public void Brake()
        {
            Speed -= 5;
        }
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + EngineSize);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
        }


        //constructor

        public  Car(string model, string color, double engineSize, bool fuzzyDice, int doorCount)
        {
            Model = model;
            Color = color;
            EngineSize = engineSize;
            FuzzyDices = fuzzyDice;
            DoorCount = doorCount;
        }



        // destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}

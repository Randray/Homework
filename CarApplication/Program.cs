using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double temp = TemperatureConverter.FahrenheitToCelsius(200);
            Car datsun = new Car("Datsun 100A", "red",1.0,true,2);
            //Car toyota = new Car("Datsun 100A", "red", 1.0, true, 2);
            //Car porche = new Car("Datsun 100A", "red", 1.0, true, 2);
            datsun.Speed = 280;
            //toyota.Speed = 100;
            //porche.Speed = 190;

            // display car data
            datsun.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();
        }
    }
}

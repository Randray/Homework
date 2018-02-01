using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexsample
{
    class Program
    {
        static void Main(string[] args)
        {


            Internetconnction conn = new Internetconnction();

            Dog internetAwareDog = new Dog();


            conn.Connect(internetAwareDog);

            Console.Read();



        }
    }
}

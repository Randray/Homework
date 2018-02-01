using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexsample
{
    class Dog : Animal, IConnectionSatusListener
    {

        public override void Talk()
        {
            Console.WriteLine("Wuh");
        }


       public void OnConnnectionStarted()
        {
            Console.WriteLine("DOG: ONConnectionStrated");

        }

       public void OnConnectionSuccess()
        {
            Console.WriteLine("DOG: ONConnectionSuccess--- WUF");
        }
        public void OnConnectionFailed()
        {
            Console.WriteLine("DOG: ONConnectionFailed---- whine...");
        }






    }
}

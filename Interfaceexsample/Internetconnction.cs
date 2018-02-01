using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceexsample
{


    interface IConnectionSatusListener
    {
        void OnConnnectionStarted();
        void OnConnectionSuccess();
        void OnConnectionFailed();

    }

    class Internetconnction
    {

       


        public void Connect(IConnectionSatusListener listener)
        {
            Console.WriteLine("Connecting to internet...");
            
            System.Threading.Thread.Sleep(4000);
            if(listener != null) listener.OnConnnectionStarted();



            Random rand = new Random();

            if (rand.Next(0, 10) < 8)
            {
                if (listener != null) listener.OnConnectionSuccess();
            }
            else
            {
                if (listener != null) listener.OnConnectionFailed();
            }

            Console.WriteLine("Connection attempt complete!");


        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._6
{
    class Radio
    {
        private int onOff;
        private int volume=0;
        private double frequency=2000.0;
        private string line;
        private int option;

        public void Startup()
        {
            Console.Write("Do you want to turn on the radio(1 = yes 0 = no)");
            line = Console.ReadLine();
            int.TryParse(line, out onOff);

            if (onOff == 1)
            {
                Console.WriteLine("Radio is starting up");
            }
            else if (onOff == 0)
            {
                Console.WriteLine("Bye bye");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("BAKA");
                Console.WriteLine("Radio just walked away");
                Console.Read();
                System.Environment.Exit(1);
            }


        }



        public void Menu()
        {
            while (true)
            {
                Console.WriteLine("Radio is on. Volume is at "+ volume + ". Frequency is at: " + frequency);
                Console.WriteLine("Do you want to:");
                Console.WriteLine(" 1. Turn off the radio?");
                Console.WriteLine(" 2. Turn up or down the volume?");
                Console.WriteLine(" 3. Chance the frequency?");

                line = Console.ReadLine();

                int.TryParse(line, out option);


                if (option== 1)
                {
                    Console.WriteLine("Radio turning of...");
                    break;
                }
                else if (option == 2)
                {
                    Volume();
                }
                else if (option == 3 )
                {

                }
                else
                {
                    Console.WriteLine("Unknow command. Returning to menu...");
                }
            }


        }

        private void Volume()
        {
            Console.Write("How high/low you want the volume:");

            line = Console.ReadLine();
            int.TryParse(line, out volume);
            
            if(volume>=0 && volume <= 9)
            {
                Console.WriteLine("Volume is set to "+ volume);
                Console.WriteLine("Returning to menu...");

            }
            else if(volume < 0)
            {
                Console.WriteLine("Volume is too low. Setting volume to default. Returning to menu...");
                volume = 0;

            }
            else if (volume > 9)
            {
                Console.WriteLine("Volume is too high. Setting volume to default. Returning to menu...");
                volume = 0;

            }
            else
            {
                 
                
                 Console.WriteLine("Unknow command.Returning to menu...");
                 volume = 0;

                
            }
        }

        private void Frequency()
        {
            Console.Write("How high/low you want the volume:");

            line = Console.ReadLine();
            int.TryParse(line, out volume);

        }

    }
}

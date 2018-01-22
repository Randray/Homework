using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._3
{
    class Amplifier
    {
        private int volume = 0;
        private string line;

        public int Volume1 {
            get { return volume; } set{ if (value >= 0 && value <= 100) volume = value; else if (value < 0) volume = 0; else if (value > 100) volume = 100; else Console.WriteLine("NANI"); }}



        public void Volume()
        {
            while (true) {
                Console.Write("Give a new volume value (0-100) > ");

                line = Console.ReadLine();

                Int32.TryParse(line, out volume);

                if (volume >= 0 && volume <= 100)
                {
                    Console.WriteLine("-> Amplifier volume is set to :"+ volume);

                }


                else if(volume < 0)
                {
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : 0");

                    volume = 0;

                }
                else if (volume > 100)
                {
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : 100");
                    volume = 100;
                }
                else
                {
                    Console.WriteLine("NANI!!!!!");
                }
            }
            





        }







    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tank TT = new Tank();

            TT.Name = "Destroy";
            TT.Type = "Random";
            TT.CrewCout = 3;

            TT.Tostring();
            TT.AccerelateTo(90);
            TT.Tostring();
            TT.SlowTo(80);
            TT.Tostring();
            TT.AccerelateTo(110);
            TT.Tostring();


            Console.Read();



        }
    }
}

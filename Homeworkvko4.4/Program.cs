using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ep = new Employee();
            Boss boss = new Boss();

            ep.Name = "Kirsi Kernel";
            ep.Profession = "Teacher";
            ep.Salary = 1200;

            ep.ToStringE();

            boss.Name = "Jussi Jurkka";
            boss.Profession = "Head of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;


            boss.ToStringB();


            ep.Name = "Kirsi Kernel";
            ep.Profession = "Principal";
            ep.Salary = 2200;

            ep.ToStringE();

            Console.Read();





        }
    }
}

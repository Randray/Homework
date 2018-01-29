using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._4
{
    class Boss: Employee
    {

        public float Bonus { get; set; }
        public string Car { get; set; }


        public  void ToStringB()
        {
            Console.WriteLine("Boss:");
            Console.WriteLine("Name: " + Name + " Profession: " + Profession + " Salary: " + Salary + " Car: " + Car +" Bonus: " + Bonus);
        }


    }
}

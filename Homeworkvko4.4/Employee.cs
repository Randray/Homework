using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworkvko4._4
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public float Salary { get; set; }


        public void ToStringE()
        {
            Console.WriteLine("Employee:");
            Console.WriteLine(" -Name: "+ Name + " Profession: "+ Profession + " Salary: "+ Salary );
        }


    }
}

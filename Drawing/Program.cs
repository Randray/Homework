﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape shape = new Shape();
            Shape circle = new Circle();

            circle.Draw();

            List<Shape> shapes = new List<Shape>();
            // use polymorphis to store objects
            shapes.Add(new Circle());
            shapes.Add(new Square());
            shapes.Add(new Circle());
            shapes.Add(new Square());

            Console.WriteLine("Loop through all drawing objects in a list:");
            foreach (Shape shape in shapes)
            {
                shape.Draw(); // "Draw Circle!" "Draw Square!" ...
            }




        }
    }
}

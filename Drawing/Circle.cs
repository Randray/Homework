using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Circle: Shape
    {
        // ei toimi ilman override sanaa
        public override void Draw()
        {
            Console.WriteLine("Draw Circle!");
        }
    }
}

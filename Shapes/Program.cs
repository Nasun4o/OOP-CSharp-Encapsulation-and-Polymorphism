using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            IShape[] shapes = new IShape[] {
                new Rectangle(2.2,2.2),
                new Rectangle(2,5.5),
                new Rhombus(4,5),
                new Rhombus(4,4),
                new Circle(2.2),
                new Circle(1.22)
            };


            foreach (IShape shape in shapes)
            {
                Console.WriteLine("Figure type: {0}{3}Area: {1:F2}{3}Perimeter: {2:F2}{3}", shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter(), Environment.NewLine);
            }

        }
    }
}

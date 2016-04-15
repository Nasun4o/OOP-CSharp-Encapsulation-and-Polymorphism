using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }
        public override double CalculateArea()
        {

            double areaRect = base.Width * base.Height;
            return areaRect;
        }

        public override double CalculatePerimeter()
        {
            double permRect = 2 * (this.Width * this.Height);
            return permRect;
        }

       
    }
}

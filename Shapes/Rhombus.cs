using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(double width, double height) :base(width, 0)
        {

        }

        public override double CalculateArea()
        {
            double areaRomb = this.Width * Width;
            return areaRomb;
        }

        public override double CalculatePerimeter()
        {
            double rombPerm = this.Width * 4;
            return rombPerm;
        }

       
    }
}

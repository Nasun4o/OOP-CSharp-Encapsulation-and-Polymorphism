using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public double CalculateArea()
        {
            double areaCirc = Math.PI * Math.Pow(Radius, 2);
            return areaCirc;
        }

        public double CalculatePerimeter()
        {
            double permCircle = Math.PI * (radius * 2);
            return permCircle;
        }



      
    }
}

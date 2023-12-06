using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
    public class Cricle : Shape {
        private double radius;
        public Cricle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}

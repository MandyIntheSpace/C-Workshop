using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Rectangle
    {
        private float length;
        private float width;

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle(double length, double width) 
        {
            this.length = (float)length;
            this.width = (float)width;
        }
        public float CalculateArea()
        {
            return this.length * this.width;
        }

    }
    
}

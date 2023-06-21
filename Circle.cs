using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacebehavior
{
    internal class Circle : Ishape
    {
        public double radius;
        public Circle (double radius)
        {
            this.radius = radius;
        }
        public double calculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public double getperimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
    internal class Rectangle : Ishape
    {
        public double lenght;
        public double width;
        public Rectangle(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        public double calculateArea()
        {
            return this.lenght * this.width;
        }

        public double getperimeter()
        {
            return 2*(this.lenght + this.width);
        }
    }
}

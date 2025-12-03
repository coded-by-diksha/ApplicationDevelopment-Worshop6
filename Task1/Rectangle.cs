using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public Rectangle(double length, double breadth) =>
            (this.length, this.breadth) = (length, breadth);

        public double GetArea() => length * breadth;

        public double GetPerimeter() => 2 * (length + breadth);

        public string ShowDetails() =>
            $"Length: {length}, Breadth: {breadth}";
    }
}

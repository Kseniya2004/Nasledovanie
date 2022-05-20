using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie.Classes
{
    abstract class Figure
    {
        abstract public double Perimetr();
        abstract public double Square();
    }
    class Circle : Figure
    {
        private double Radius;
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Figure
    {
        private double Side1, Side2;
        public Rectangle(double s1, double s2)
        {
            Side1 = s1;
            Side2 = s2;
        }
        public override double Perimetr()
        {
            return 2 * (Side1 + Side2);
        }
        override public double Square()
        {
            return Side1 * Side2;
        }
    }
    class Triangle : Figure
    {
        private double Side1, Side2, Side3;
        public bool Exists
        {
            get
            {
                return (Side1 + Side2 > Side3) && (Side1 + Side3 > Side2) && (Side2 + Side3 > Side1);
            }
        }
        public Triangle(double s1, double s2, double s3)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
        }
        public override double Perimetr()
        {
            return Side1 + Side2 + Side3;
        }
        public override double Square()
        {
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}


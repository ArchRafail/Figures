using System;

namespace Figures
{
    abstract class GeometricFigures
    {
        protected string figure;
        protected double perimeter;
        protected double area;
        public abstract double Perimeter { get; set; }
        public abstract double Area { get; set; }
        protected double Check(double value)
        {
            if (value < 0)
                value *= -1;
            if (value == 0)
                value = 1;
            return value;
        }
        public abstract void Print();
    }
}

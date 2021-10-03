using System;

namespace Figures
{
    class Circle : GeometricFigures
    {
        private double radius;
        public Circle()
        {
            figure = "Circle";
            Console.Write("Input the length of the radius of circle: ");
            this.radius = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Circle(double radius)
        {
            figure = "Circle";
            this.radius = Check(radius);
            Calculation();
        }
        public override double Perimeter
        {
            get => perimeter;
            set { perimeter = value; }
        }
        public override double Area
        {
            get => area;
            set { area = value; }
        }
        private void Calculation()
        {
            Perimeter = 2 * 3.14 * radius;
            Area = 3.14 * radius;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Math.Round(Perimeter, 2, MidpointRounding.AwayFromZero)}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

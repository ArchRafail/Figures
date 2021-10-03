using System;

namespace Figures
{
    class Rectangle : GeometricFigures
    {
        private double sideA, sideB;
        public Rectangle()
        {
            figure = "Rectangle";
            Console.Write("Input the length of the side A of rectangle: ");
            this.sideA = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input the side B length of rectangle: ");
            this.sideB = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Rectangle(double sideA, double sideB)
        {
            figure = "Rectangle";
            this.sideA = Check(sideA);
            this.sideB = Check(sideB);
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
            Perimeter = 2 * (sideA + sideB);
            Area = sideA * sideB;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Perimeter}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

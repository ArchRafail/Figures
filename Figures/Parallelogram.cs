using System;

namespace Figures
{
    class Parallelogram : GeometricFigures
    {
        private double side, height;
        public Parallelogram()
        {
            figure = "Parallelogram";
            Console.Write("Input the length of the side of parallelogram: ");
            this.side = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input the height to the side of the parallelogram: ");
            this.height = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Parallelogram(double side, double height)
        {
            figure = "Parallelogram";
            this.side = Check(side);
            this.height = Check(height);
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
            Perimeter = 2 * (side + height);
            Area = side * height;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Perimeter}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

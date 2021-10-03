using System;

namespace Figures
{
    class Rhombus : GeometricFigures
    {
        private double side, height;
        public Rhombus()
        {
            figure = "Rhombus";
            Console.Write("Input the length of the side of rhombus: ");
            this.side = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input the height of the rhombus: ");
            this.height = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Rhombus(double side, double height)
        {
            figure = "Rhombus";
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
            Perimeter = 4 * side;
            Area = side * height;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Perimeter}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

using System;

namespace Figures
{
    class Square : GeometricFigures
    {
        private double side;
        public Square()
        {
            figure = "Square";
            Console.Write("Input the length of the side of square: ");
            this.side = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Square(double side)
        {
            figure = "Square";
            this.side = Check(side);
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
            Area = side*side ;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Perimeter}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

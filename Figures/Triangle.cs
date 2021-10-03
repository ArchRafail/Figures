using System;

namespace Figures
{
    class Triangle : GeometricFigures
    {
        private double sideA, sideB, sideC;
        public Triangle()
        {
            figure = "Triangle";
            Console.Write("Input length of side A of the triangle: ");
            this.sideA = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input side B of the triangle: ");
            this.sideB = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input side C of the triangle: ");
            this.sideC = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            figure = "Triangle";
            this.sideA = Check(sideA);
            this.sideB = Check(sideB);
            this.sideC = Check(sideC);
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
            Perimeter = sideA + sideB + sideC;
            Area = Math.Sqrt((sideA + sideB - sideC) * (sideA - sideB + sideC) * (sideB - sideA + sideC) * (sideA + sideB + sideC)) / 4;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Perimeter}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

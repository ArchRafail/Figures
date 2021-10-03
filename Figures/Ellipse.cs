using System;

namespace Figures
{ 
    class Ellipse : GeometricFigures
    {
        private double semiradiusA, semiradiusB;
        public Ellipse()
        {
            figure = "Ellipse";
            Console.Write("Input the length of the semiradius A of the ellipse: ");
            this.semiradiusA = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input the length of the semiradius B of the ellipse: ");
            this.semiradiusB = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Ellipse(double semiradiusA, double semiradiusB)
        {
            figure = "Ellipse";
            this.semiradiusA = Check(semiradiusA);
            this.semiradiusB = Check(semiradiusB);
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
            Perimeter = 2 * 3.14 * Math.Sqrt((semiradiusA * semiradiusA + semiradiusB * semiradiusB) / 2);
            Area = 3.14 * semiradiusA * semiradiusB;
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Math.Round(Perimeter, 2, MidpointRounding.AwayFromZero)}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

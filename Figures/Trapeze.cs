using System;

namespace Figures
{
    class Trapeze : GeometricFigures
    {
        private double baseA, baseB, sideC, sideD;
        public Trapeze()
        {
            figure = "Trapeze";
            Console.Write("Input the length of the base A of the trapeze: ");
            this.baseA = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input the length of the base B (longer base) of the trapeze: ");
            this.baseB = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input side C of the trapeze: ");
            this.sideC = Check(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Input side D of the trapeze: ");
            this.sideD = Check(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Calculation();
        }
        public Trapeze(double baseA, double baseB, double sideC,  double sideD)
        {
            figure = "Trapeze";
            this.baseA = Check(baseA);
            this.baseB = Check(baseB);
            this.sideC = Check(sideC);
            this.sideD = Check(sideD);
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
            double temp;
            if (baseA > baseB)
            {
                temp = baseB;
                baseB = baseA;
                baseA = temp;
            }
            if (baseA == baseB)
                baseB = baseA + 1;
            Perimeter = baseA + baseB + sideC + sideD;
            Area = ((baseB + baseA) * Math.Sqrt((baseB - baseA + sideC + sideD) * (baseA - baseB + sideC + sideD) * (baseA - baseB + sideC - sideD) * (baseA - baseB - sideC + sideD))) / (4*(baseB - baseA));
        }
        public override void Print()
        {
            Console.WriteLine($"Figure: {figure}, Perimeter: {Perimeter}, Area: {Math.Round(Area, 2, MidpointRounding.AwayFromZero)}.");
        }
    }
}

using System;

namespace Figures
{
    class ComplexFigures
    {
        private static int size;
        private int count;
        private GeometricFigures[] figures;

        static ComplexFigures() { size = 10; }
        public ComplexFigures()
        {
            count = 0;
            Console.WriteLine("The program is about how to collect objects from diff. classes in one array.");
            figures = new GeometricFigures[size];
        }
        public int Menu()
        {
            int answer;
            Console.WriteLine("If you want to add a figure input the number that corresponds it.");
            Console.WriteLine("1. Triangle.  /  2. Square.  /  3. Rhombus.  /  4. Rectangle.");
            Console.WriteLine("5. Parallelogram.  /  6. Trapeze.  /  7. Circle.  /  8. Ellipse.");
            do
            {
                answer = Convert.ToInt32(Console.ReadLine());
            } while (answer < 1 || answer > 8);
            return answer;
        }
        public void AddFigure(int type)
        {
            int index;
            index = CheckArr();
            switch (type)
            {
                case 1:
                    Console.WriteLine();
                    figures[index] = new Triangle();
                    break;
                case 2:
                    Console.WriteLine();
                    figures[index] = new Square();
                    break;
                case 3:
                    Console.WriteLine();
                    figures[index] = new Rhombus();
                    break;
                case 4:
                    Console.WriteLine();
                    figures[index] = new Rectangle();
                    break;
                case 5:
                    Console.WriteLine();
                    figures[index] = new Parallelogram();
                    break;
                case 6:
                    Console.WriteLine();
                    figures[index] = new Trapeze();
                    break;
                case 7:
                    Console.WriteLine();
                    figures[index] = new Circle();
                    break;
                case 8:
                    Console.WriteLine();
                    figures[index] = new Ellipse();
                    break;
            }
        }
        private int CheckArr()
        {
            if (count + 1 > size)
            { 
                GeometricFigures[] temp = new GeometricFigures[size + 10];
                for (int i = 0; i < size; i++)
                    temp[i] = figures[i];
                figures = temp;
                size += 10;
            }
            return count++;
        }
        public void Print()
        {
            double totalArea = 0;
            Console.WriteLine("An information about each figure in array.");
            for (int i = 0; i < count; i++)
            {
                figures[i].Print();
                totalArea += figures[i].Area;
            }
            Console.WriteLine($"\nTotal area of figures in array: {Math.Round(totalArea, 2, MidpointRounding.AwayFromZero)}\n");
        }
    }
}

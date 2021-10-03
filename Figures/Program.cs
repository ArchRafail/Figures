using System;

namespace Figures
{
    class Program
    {
        public static int Menu()
        {
            int answer;
            Console.WriteLine("What action do you want to do?");
            Console.WriteLine("1. Add a figure to the array.");
            Console.WriteLine("2. Show contents of the array of figures.");
            Console.WriteLine("3. Exit from program.");
            do
            {
                answer = Convert.ToInt32(Console.ReadLine());
            } while (answer < 1 || answer > 3);
            return answer;
        }
        static void Main(string[] args)
        {
            ComplexFigures figures = new ComplexFigures();
            do
            {
                switch (Menu())
                {
                    case 1:
                        Console.WriteLine();
                        figures.AddFigure(figures.Menu());
                        break;
                    case 2:
                        Console.WriteLine();
                        figures.Print();
                        break;
                    case 3:
                        Console.WriteLine();
                        return;
                }
            } while (true);
        }
    }
}

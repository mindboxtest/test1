using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcArea;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

			List<Figure> figures = new List<Figure>();

			figures.Add(new Triangle(2, 9, 8));
			figures.Add(new Triangle(2, 10, 8));
			figures.Add(new Triangle(2, 15, 15));
			figures.Add(new Around(5));
			figures.Add(new Around(20));

			double sunArea = 0.0;

			foreach (var it in figures)
				sunArea += it.Area();
        
			Console.WriteLine($"Суммарная площадь всех фигур: {sunArea}");

            Console.ReadLine();
        }
    }
}

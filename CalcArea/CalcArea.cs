using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcArea
{
	/// <summary>
	/// Фигура (базовый)
	/// </summary>
    public abstract class Figure
    {
        /// <summary>
		/// Расчет площади фигуры
		/// </summary>
		/// <returns>Возвращает площадь</returns>
        public abstract double Area();
    }
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double A { private get; set; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { private get; set; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { private get; set; }

        /// <summary>
        /// Треугольник
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        /// <summary>
        /// Проверка - является ли треугольник прямоугольным
        /// </summary>
        /// <returns>True or False</returns>
        public bool Check()
        {
            return A * A == B * B + C * C || B * B == A * A + C * C || C * C == A * A + B * B;
        }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double Area()
        {
            double P = (A + B + C) / 2;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }
    /// <summary>
    /// Круг
    /// </summary>
    public class Around : Figure
    {
		/// <summary>
		/// Радиус
		/// </summary>
        public double R { private get; set; }

		/// <summary>
		/// Круг
		/// </summary>
		/// <param name="r">Радиус</param>
		public Around(double r)
        {
            R = r;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double Area()
        {
            return Math.PI * R * R;
        }
    }
}

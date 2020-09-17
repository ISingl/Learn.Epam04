using System;

namespace TaskTriangle
{
    public class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        /// <summary>
        /// The perimeter of a triangle is the sum of all three of the sides.
        /// </summary>
        public double Perimeter
        {
            get
            {
                return SideA + SideB + SideC;
            }
        }

        /// <summary>
        /// Constructor for creating a class instance.
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        public Triangle(double a, double b, double c)
        {
            if (ExistenceTriangle(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
            else
                throw new Exception("With the current arguments, the triangle cannot exist!");
        }

        /// <summary>
        /// The area of the triangle calculated using the Heron formula.
        /// </summary>
        /// <returns>AreaTreangle</returns>
        public double AreaTreangle()
        {
            double halfPrm = Perimeter / 2.0;
            return Math.Sqrt(halfPrm * (halfPrm - SideA) * (halfPrm - SideB) * (halfPrm - SideC));
        }

        /// <summary>
        /// The sum of two sides must add up to be greater than the length of the remaining third side.
        /// </summary>
        /// <param name="a">Side A</param>
        /// <param name="b">Side B</param>
        /// <param name="c">Side C</param>
        /// <returns></returns>
        public static bool ExistenceTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Arguments must be greater then zero.");

            if (a + b > c && a + c > b && b + c > a)
                return true;
            else
                return false;
        }
    }
}

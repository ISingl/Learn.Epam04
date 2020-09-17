using System;
using TaskTriangle;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Library for working with a triangle.\n" +
                "Enter the sides of the triangle a, b, c using by space and press enter: ");

            var input = Console.ReadLine().Split(' ');
            if (input.Length == 3 && 
                Double.TryParse(input[0], out double a) &&
                Double.TryParse(input[1], out double b) &&
                Double.TryParse(input[2], out double c))
            {
                if (Triangle.ExistenceTriangle(a, b, c))
                {
                    var triangle = new Triangle(a, b, c);
                    Console.WriteLine($"\nThe triangle exists.\n" +
                        $"The perimeter is equal to: {triangle.Perimeter}\n" +
                        $"The area is equal to: {triangle.AreaTreangle()}");
                }
                else
                {
                    Console.WriteLine("With the current arguments, the triangle cannot exist!");
                }
            }
            else
                Console.WriteLine("Incorrect data!");

            Console.ReadLine();
        }
    }
}

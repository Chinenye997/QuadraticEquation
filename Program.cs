using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Quadratic Equation Solver");

                // Ask the user for input
                Console.Write("Enter coefficient a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coefficient b: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter coefficient c: ");
                double c = Convert.ToDouble(Console.ReadLine());

                // Create a new QuadraticEquation object
                QuadraticEquation equation = new QuadraticEquation(a, b, c);

                // Calculate and display the roots
                double root1 = equation.CalculateRoot1();
                double root2 = equation.CalculateRoot2();

                Console.WriteLine($"Root 1: {root1}");
                Console.WriteLine($"Root 2: {root2}");
                Console.ReadLine();
        }
    }
}

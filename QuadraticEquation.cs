using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    class QuadraticEquation
    {
            public double A { get; set; }
            public double B { get; set; }
            public double C { get; set; }

            public QuadraticEquation(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public double CalculateDiscriminant()
            {
                return Math.Pow(B, 2) - 4 * A * C;
            }

            public double CalculateRoot1()
            {
                double discriminant = CalculateDiscriminant();
                return (-B + Math.Sqrt(discriminant)) / (2 * A);
            }

            public double CalculateRoot2()
            {
                double discriminant = CalculateDiscriminant();
                return (-B - Math.Sqrt(discriminant)) / (2 * A);
            }
        
    }
}

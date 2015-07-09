using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace QuadraticFormula
namespace QuadraticFormula
{
    /// <summary> 
    /// This program will take the values from the user for points a, b and c to solve the Quadric Formula.
    /// If there is no solution program will print "The equation has no solution" otherwise it will print the two values for x.
    /// </summary>

    //start class Program
    class Program
    {
        //start main function
        static void Main(string[] args)
        {
            //declare varibales
            double a = 0;
            double b = 0;
            double c = 0;
            double x1 = 0;
            double x2 = 0;

            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //Prompt user to enter the values for points a, b and c
            Console.Write("Enter value of a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Enter value of b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Enter value of c: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            //algorithm to calculate inside sqrt
            double insideSquareRoot = (b * b) - 4 * a * c;
            
            //Loop to check if the equation has a solution
            if (insideSquareRoot < 0)
            {
                //There is no solution
                x1 = double.NaN;
                x2 = double.NaN;
                Console.WriteLine("The equation has no solution." + "\n");
                Console.ReadLine();
            }
            else
            {
                //Compute the value of each x
                //if there is only one solution, both x's will be the same
                double sqrt = Math.Sqrt(insideSquareRoot);
                x1 = (-b + sqrt) / (2 * a);
                x2 = (-b - sqrt) / (2 * a);
                Console.WriteLine("First value of X is: " + x1 + "\n");
                Console.WriteLine("Second Value of X is: " + x2 + "\n");
                Console.ReadLine();

            }//end if loop
        }//end main method
    }//end class Program
}//end namespace QuadraticFormula
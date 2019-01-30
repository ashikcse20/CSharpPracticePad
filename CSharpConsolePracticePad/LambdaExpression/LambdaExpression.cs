using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePracticePad.LambdaExpression
{
    public delegate int Incr(int x);
    public delegate bool Iseven(int x);
    public delegate bool Inrange(int lowerBound, int upperBound, int providedValue);
    public class LambdaExpressionPractice
    {
        public static void SimpleExpressionLambdaDemo()
        {
            Incr incr = count => count + 2; // here compler infer the type of count from delegate signature type
           
            int x = -10;

            Console.WriteLine("Practicing Increment With Expression Lambda ");
            do
            {
                Console.WriteLine("Current value of X :" + x);
                x = incr(x);

            } while (x <= 0);

            Console.WriteLine("\n\n");
            Console.WriteLine("Practicing if provided number is Even with Expression Lambda ");
           Iseven iseven = value => value % 2 == 0;
            Incr incr2 = (int count) => count + 2;
            do
            {
                Console.WriteLine("Current value of X :" + x);
                if (iseven(x))
                {
                    Console.WriteLine(x + " is even");
                }

                x = incr2(x);
            } while (x <= 10);


            Console.WriteLine("Practicing cheking if value is in range with Expression Lambda ");
            Inrange inrange = (l, h, v) => v >= l && v <= h;

            if (inrange(2, 5, 3))
            {
                Console.WriteLine("3  is between 2 and 5");
            }
            else
                Console.WriteLine("3  isn't between 2 and 5");

        }



    }

}


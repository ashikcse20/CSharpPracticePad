using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePracticePad.Anonymous_Method
{
    //Anonymous Methods;
    //delegate void CountitNoparameterNoReturned();
    public delegate void CountItWithOutParamAndArg();

    //Pass Arguments to an Anonymous Method; Return a Value from an Anonymous Method; Use Outer Variables with Anonymous Methods All in 
    // This delegate returns int and takes an int argument.
   public delegate int CountItWithParamAndArg(int end);
    public class Anonymousmethod
    {
        public static void AnonymousMethodsWithOutParameterArgument()
        {

            CountItWithOutParamAndArg countWithoutPA = delegate
            {
                Console.WriteLine("This is a Default Delegate with No returned or passed arguent");
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);

            };
            countWithoutPA();
        }
        public static void AnonymousMethodsWithParameterArgument()
        {

            CountItWithParamAndArg countWithPA = delegate (int endedited)
            {

                int sum = 0;
                Console.WriteLine("This is a Default Delegate with No returned or passed arguent");
                for (int i = 0; i <= endedited; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };
            int Summation = countWithPA(6);
            Console.WriteLine("sum = " + Summation);
        }



        public static CountItWithParamAndArg AnonymousMethodsWithOuterVariables()
        {

            int sum = 0;
            CountItWithParamAndArg CountItWithParamAndArgobj = delegate (int End)
            {
                for(int i =0; i<=End; i++)
                {
                    sum += i;
                    Console.WriteLine(i);

                }
                return sum;
            };

            return CountItWithParamAndArgobj;

         
       }
}
}

using CSharpConsolePracticePad.Anonymous_Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePracticePad
{


   public  partial class Program
    {

        public void AnonymousMethodsWithOutParameterArgument()
        {
            Anonymousmethod.AnonymousMethodsWithOutParameterArgument();
        }
        public void AnonymousMethodsWithParameterArgument()
        {
            Anonymousmethod.AnonymousMethodsWithParameterArgument();
        }

        public void AnonymousMethodsWithOuterVariables()
        {

             
            //CountItWithParamAndArg countIt = new CountItWithParamAndArg(Anonymousmethod.AnonymousMethodsWithOuterVariables());
            CountItWithParamAndArg countIt =  Anonymousmethod.AnonymousMethodsWithOuterVariables();
            int Result = countIt(3);
            Console.WriteLine("Summation of 3 is : " + Result);

             Result = countIt(5);
            Console.WriteLine("Summation of 5 is : " + Result);
            Console.WriteLine("As you can see, the count still proceeds normally. However, notice the summation value for 5.It shows 21 instead of 15!");
        }

    }
}

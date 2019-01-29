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
            //int Result = countIt(10);
           // Console.WriteLine("Summation of 10 is : " + Result);
        }

    }
}

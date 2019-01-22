using CSharpConsolePracticePad.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePracticePad
{

    //public  delegate string StrMod(string str);
    public class Program
    {
        static void Main(string[] args)
        {
            Program pOb = new Program();
            //  pOb.DelegatePractice1();
            pOb.DelegatePractice1MethodGroupConversion();

        }

        public void DelegatePractice1()
        {
            // Construct a delegate.
            StrMod strOp = new StrMod(DelegateTest.ReplaceSpaces);
            string str;

            // Call methods through the delegate.
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();

            strOp = new StrMod(DelegateTest.RemoveSpaces);
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
            strOp = new StrMod(DelegateTest.Reverse);
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);

            // Calling Intance Class 
            Console.WriteLine("Calling Intance Class");
            DelegateTest DlgOb = new DelegateTest();
            strOp = new StrMod(DlgOb.ReplaceSpacesInsTanceMethod);
            str = strOp("My name is Muhammad Adshikuzzaman");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorSize = 10;
            Console.WriteLine("My space replaced name is : " + str);
            Console.WriteLine();

        }
        public void DelegatePractice1MethodGroupConversion()
        {
            // Construct a delegate using method group conversion.
            StrMod strOp = DelegateTest.ReplaceSpaces; // use method group conversion
            string str;
            // Call methods through the delegate.
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
            strOp = DelegateTest.RemoveSpaces; // use method group conversion
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
            strOp = DelegateTest.Reverse; // use method group conversion
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            // Calling Intance Class 
            Console.WriteLine("Calling Intance Class");
            DelegateTest DlgOb = new DelegateTest();
            strOp = DlgOb.ReplaceSpacesInsTanceMethod;
            str = strOp("My name is Muhammad Adshikuzzaman");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorSize = 10;
            Console.WriteLine("My space replaced name is : " + str);
            Console.WriteLine();
        } 

    }
}

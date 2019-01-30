using CSharpConsolePracticePad.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePracticePad
{

    //public  delegate string StrMod(string str);
    public partial class Program
    {
        static void Main(string[] args)
        {
            Program pOb = new Program();


            pOb.ColorfulColor();
            Console.WriteLine("Enter 1 Practicing Delegate");
            Console.WriteLine("Enter 2 Practicing Anonymous Method");
            Console.WriteLine("Enter 3 Practicing Lambda Expression");
            int inputValue = Convert.ToInt32(Console.ReadLine());

            pOb.DefaultColor();
            #region delegate Practice
            if (inputValue == 1)
            {
                {
                    pOb.ColorfulColor();
                    Console.WriteLine("Enter 1 for Practicing Delegate with  Static Method");
                    Console.WriteLine("Enter 2 for Practicing Delegate with  Instance Method");
                    Console.WriteLine("Enter 3 for Practicing Delegate with  Method Group Conversion");
                    Console.WriteLine("Enter 4 for Practicing Delegate with Multicasting");
                    pOb.DefaultColor();
                    inputValue = Convert.ToInt32(Console.ReadLine());
                    if (inputValue == 1)
                    {
                        pOb.ColorfulColor();
                        Console.WriteLine("Delegate with  Static Method");
                        pOb.DefaultColor();
                        pOb.DelegatePracticeWithStaticMethod();
                    }
                    // inputValue = Convert.ToInt32(Console.ReadLine());
                    if (inputValue == 2)
                    {
                        pOb.ColorfulColor();
                        Console.WriteLine("Delegate with Intance Method");
                        pOb.DefaultColor();
                        pOb.DelegatePracticeWithInstanceMthod();
                    }
                    // inputValue = Convert.ToInt32(Console.ReadLine());
                    if (inputValue == 3)
                    {
                        pOb.ColorfulColor();
                        Console.WriteLine("Delegate with  Method Group Conversion");
                        pOb.DefaultColor();
                        pOb.DelegatePracticeMethodGroupConversion();
                    }

                    // inputValue = Convert.ToInt32(Console.ReadLine());
                    if (inputValue == 4)
                    {
                        pOb.ColorfulColor();
                        Console.WriteLine("Delegate Practice Multicasting ");
                        pOb.DefaultColor();
                        pOb.DelegatePracticeMulticasting();
                    }
                }
            }
            #endregion delegate Practice  
            #region AnonymousMethods 
            else if (inputValue == 2)
            {
                pOb.ColorfulColor();
                Console.WriteLine("Enter 1 for Practicing Anonymous Method WithOut Parameter/Argument");
                Console.WriteLine("Enter 2 for Practicing Anonymou Method With Parameter/Argument And Return Valu");
                Console.WriteLine("Enter 3 for Practicing Anonymou Method With Use Outer Variables");
                inputValue = Convert.ToInt32(Console.ReadLine());
                pOb.DefaultColor();
                if (inputValue == 1)
                    pOb.AnonymousMethodsWithOutParameterArgument();
                else if (inputValue == 2)
                    pOb.AnonymousMethodsWithParameterArgument();
                else if (inputValue == 3)
                {//C# 4.0:  The Complete Reference Page 424 //Use Outer Variables with Anonymous Methods
                    pOb.AnonymousMethodsWithOuterVariables();
                }
            }
            #endregion AnonymousMethods 
            #region LambdaExpression 
            else if (inputValue == 3)
            {
                pOb.ColorfulColor();
                Console.WriteLine("Enter 1 for Practicing Simple Expression Lambda ");
                Console.WriteLine("Enter 2 for Practicing Lambda Expression");
                Console.WriteLine("Enter 3 for Practicing Lambda Expression");
                inputValue = Convert.ToInt32(Console.ReadLine());
                pOb.DefaultColor();
                if (inputValue == 1)
                    pOb.SimpleExpressionLambdaDemo();
                else if (inputValue == 2)
                    pOb.AnonymousMethodsWithParameterArgument();
                else if (inputValue == 3)
                {//C# 4.0:  The Complete Reference Page 424 //Use Outer Variables with Anonymous Methods
                    pOb.AnonymousMethodsWithOuterVariables();
                }
            }
            #endregion AnonymousMethods 
        }

        public void DefaultColor()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void ColorfulColor()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;

        }

    }
}

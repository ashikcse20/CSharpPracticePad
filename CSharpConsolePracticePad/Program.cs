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


            Console.WriteLine("Enter 1 Practicing Delegate");
            int inputValue = Convert.ToInt32(Console.ReadLine());
            if (inputValue == 1)
            {
                {
                    pOb.ColorfulColor();
                    Console.WriteLine("Delegate with  Static Method");
                    pOb.DefaultColor();
                    pOb.DelegatePracticeWithStaticMethod();
                    pOb.ColorfulColor();
                    Console.WriteLine("Delegate with Intance Method");
                    pOb.DefaultColor();
                    pOb.DelegatePracticeWithInstanceMthod();
                    pOb.ColorfulColor();
                    Console.WriteLine("Delegate with  Method Group Conversion");
                    pOb.DefaultColor();
                    pOb.DelegatePractice1MethodGroupConversion();
                }
            }

        }

        public void DefaultColor() {

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

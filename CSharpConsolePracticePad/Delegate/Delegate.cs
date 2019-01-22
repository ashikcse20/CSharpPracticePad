using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsolePracticePad.Delegate
{
    //// A simple delegate example.
    //using System;
    //// Declare a delegate type.
    public delegate string StrMod(string str);
    class DelegateTest
    {
        // Replaces spaces with hyphens.
      internal  static string ReplaceSpaces(string s)
        {
            Console.WriteLine("Replacing spaces with hyphens.");
            return s.Replace(' ', '-');
        }

        public string ReplaceSpacesInsTanceMethod(string str)
        {
            Console.WriteLine("Replacing spaces with Blank.");
            return str.Replace(" ", ""); 
        }

        // Remove spaces.
       internal static string RemoveSpaces(string s)
        {
            string temp = "";
            int i;
            Console.WriteLine("Removing spaces. sdsd");
            for (i = 0; i < s.Length; i++)
                if (s[i] != ' ') temp += s[i];
            return temp;
        }
        // Reverse a string.
       public static string Reverse(string s)
        {
            string temp = "";
            int i, j;
            Console.WriteLine("Reversing string.");
            for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
                temp += s[i];
            return temp;
        }
     /*   static void Main()
        {
            // Construct a delegate.
            StrMod strOp = new StrMod(ReplaceSpaces);
            string str;
           
        // Call methods through the delegate.
 str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
            strOp = new StrMod(RemoveSpaces);
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
            Console.WriteLine();
            strOp = new StrMod(Reverse);
            str = strOp("This is a test.");
            Console.WriteLine("Resulting string: " + str);
        }*/
    }


}

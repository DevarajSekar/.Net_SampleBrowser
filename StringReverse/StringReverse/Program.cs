using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            //Method 1 - Using For loop
            Console.WriteLine("Actual String =" +" Hello world!!");
            string revStr1 = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr1 += str[i];
            }
            Console.WriteLine("Reverse String = " + revStr1);

            //Metod 2 - Using Char Array
            Console.WriteLine("Actual String =" + " Hello world!!");
            char[] strArray = str.ToCharArray();
            string revStrArray = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStrArray += str[i];
            }
            Console.WriteLine("Reverse String = " + revStrArray);

            //Method 3 - Using Linq
            var resultstring = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Using Linq method = " + resultstring);

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

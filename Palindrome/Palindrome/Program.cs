using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Sample");
            Console.WriteLine("------------------");
            Console.WriteLine("Enter Some Sample Text");
            string str = Console.ReadLine();
            var revStr = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revStr += str[i];
            }

            //2nd method
            //char[] charArray = s.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);

            if (revStr.ToLower() == str.ToLower())
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEachCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count Each Character");
            Console.WriteLine("---------------------");
            string str = Console.ReadLine();
            Dictionary<char, int> CountDictionary = new Dictionary<char, int>();

            foreach (var characterStr in str)
            {
                if (characterStr != ' ')
                {
                    if (!CountDictionary.ContainsKey(characterStr))
                    {
                        CountDictionary.Add(characterStr, 1);
                    }
                    else
                    {
                        CountDictionary[characterStr]++;
                    }
                }
            }

            foreach (var count in CountDictionary)
            {
                Console.WriteLine("{0}-{1}", count.Key, count.Value);
            }
            Console.ReadKey();
        }
    }
}

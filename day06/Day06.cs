using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace day04
{
    class Day04
    {
        static int FindIndex(string input, int windowSize)
        {

            var i = 0;
            while (i < input.Length - windowSize && input.Skip(i).Take(windowSize).ToHashSet().Count != windowSize)
            {
                i++;
            }
            return i + windowSize;
        }

        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"input.txt");
            Console.WriteLine(FindIndex(input, 4));
            Console.WriteLine(FindIndex(input, 14));
        }
    }
}
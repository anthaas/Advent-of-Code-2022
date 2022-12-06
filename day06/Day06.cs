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
            for (int i = 0; i < input.Count() - windowSize; i++)
            {
                if (input.Skip(i).Take(windowSize).ToHashSet().Count == windowSize)
                {
                    return i + windowSize;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            var input = File.ReadLines(@"input.txt").ElementAt(0);
            Console.WriteLine(FindIndex(input, 4));
            Console.WriteLine(FindIndex(input, 14));
        }
    }
}
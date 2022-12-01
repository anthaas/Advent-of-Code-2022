using System;
using System.Linq;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = System.IO.File.ReadAllText(@"input.txt");
            var elves = text.Split("\n\n");
            var calories = elves.Select(
                    elf => elf.Split("\n")
                                .Select(x => Int32.Parse(x))
                                .Sum()
                ).ToList();
            calories.Sort((a, b) => b.CompareTo(a));
            var part1 = calories[0];
            var part2 = calories.Take(3).Sum();

            Console.WriteLine(part1);
            Console.WriteLine(part2);
        }
    }
}

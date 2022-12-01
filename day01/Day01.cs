using System;
using System.Linq;

namespace day1
{
    class Day01
    {
        static void Main(string[] args)
        {
            var text = System.IO.File.ReadAllText(@"input.txt");
            var elves = text.Split(Environment.NewLine + Environment.NewLine);
            var calories = elves.Select(
                    elf => elf.Split(Environment.NewLine)
                                .Select(long.Parse)
                                .Sum()
                ).OrderByDescending(x => x)
                .ToList();
            var part1 = calories[0];
            var part2 = calories.Take(3).Sum();

            Console.WriteLine(part1);
            Console.WriteLine(part2);
        }
    }
}

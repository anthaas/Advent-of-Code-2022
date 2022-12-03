using System;
using System.IO;
using System.Linq;

namespace day03
{
    class Day03
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"input.txt");
            var result = 0;
            foreach (var line in lines)
            {
                var half = line.Length / 2;
                var first = line[..half];
                var second = line[half..];
                var shared = first.Intersect(second).First();
                var score = 0;
                if (shared is >= 'a' and <= 'z')
                    score = shared - 'a' + 1;
                else
                    score = shared - 'A' + 27;

                result += score;
            }

            Console.WriteLine(result);

            result = 0;
            foreach (var items in lines.Chunk(3))
            {
                var shared = items.Select(x => x.AsEnumerable()).Aggregate((a, b) => a.Intersect(b)).First();
                var score = 0;
                if (shared is >= 'a' and <= 'z')
                    score = shared - 'a' + 1;
                else
                    score = shared - 'A' + 27;

                result += score;
            }

            Console.WriteLine(result);
        }
    }
}
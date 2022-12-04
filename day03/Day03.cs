using System;
using System.IO;
using System.Linq;

namespace day03
{
    class Day03
    {
        static int GetScore(char element)
        {
            if (element is >= 'a' and <= 'z')
                return element - 'a' + 1;
            else
                return element - 'A' + 27;

        }
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"input.txt");
            var result = lines.Select(line => { return line.Substring(0, line.Length / 2).Intersect(line.Substring(line.Length / 2)).Select(GetScore).Sum(); }).Sum();
            Console.WriteLine(result);

            result = lines.Chunk(3).Select(items => { return items.Select(x => x.AsEnumerable()).Aggregate((a, b) => a.Intersect(b)).Select(GetScore).Sum(); }).Sum();
            Console.WriteLine(result);
        }
    }
}
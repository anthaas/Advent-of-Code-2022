using System;
using System.IO;
using System.Linq;

namespace day04
{
    class Day04
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines(@"input.txt");
            var sectionsRange = lines.Select(x => x.Split(',', '-').Select(long.Parse)).ToArray();
            var containsIntervalCount = sectionsRange.Select(sections =>
            {
                return (sections.ElementAt(0) <= sections.ElementAt(2) && sections.ElementAt(1) >= sections.ElementAt(3))
                || (sections.ElementAt(2) <= sections.ElementAt(0) && sections.ElementAt(3) >= sections.ElementAt(1)) ? 1 : 0;
            }).Sum();
            Console.WriteLine(containsIntervalCount);

            var overlapsIntervalCount = sectionsRange.Select(sections =>
            {
                return (sections.ElementAt(2) <= sections.ElementAt(1) && sections.ElementAt(2) >= sections.ElementAt(0))
                || (sections.ElementAt(0) <= sections.ElementAt(3) && sections.ElementAt(0) >= sections.ElementAt(2)) ? 1 : 0;
            }).Sum();
            Console.WriteLine(overlapsIntervalCount);
        }
    }
}
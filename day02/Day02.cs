using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace day02
{
    enum Move
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    enum BattleResult
    {
        Win = 6,
        Draw = 3,
        Lose = 0
    }
    class Day02
    {
        static Move ParseMove(string input)
        {
            switch (input)
            {
                case "X":
                case "A":
                    return Move.Rock;
                case "Y":
                case "B":
                    return Move.Paper;
                case "Z":
                case "C":
                    return Move.Scissors;
                default:
                    throw new ArgumentException();
            }
        }

        static BattleResult ParseResult(string input)
        {
            switch (input)
            {
                case "X":
                    return BattleResult.Lose;
                case "Y":
                    return BattleResult.Draw;
                case "Z":
                    return BattleResult.Win;
                default:
                    throw new ArgumentException();
            }
        }

        static BattleResult GetResult(Move player1, Move player2)
        {
            switch (player1, player2)
            {
                case (Move.Rock, Move.Rock):
                case (Move.Paper, Move.Paper):
                case (Move.Scissors, Move.Scissors):
                    return BattleResult.Draw;
                case (Move.Rock, Move.Scissors):
                case (Move.Paper, Move.Rock):
                case (Move.Scissors, Move.Paper):
                    return BattleResult.Win;
                case (Move.Rock, Move.Paper):
                case (Move.Paper, Move.Scissors):
                case (Move.Scissors, Move.Rock):
                    return BattleResult.Lose;
                default:
                    throw new ArgumentException();
            }
        }
        static void Main(string[] args)
        {

            var lines = File.ReadLines(@"input.txt");

            int score = 0;
            foreach (var line in lines)
            {
                var elf = ParseMove(line.Split(" ")[0]);
                var me = ParseMove(line.Split(" ")[1]);
                var result = GetResult(me, elf);
                score += (int)result;
                score += (int)me;
            }
            Console.WriteLine(score);


            score = 0;
            foreach (var line in lines)
            {
                var elf = ParseMove(line.Split(" ")[0]);
                var result = ParseResult(line.Split(" ")[1]);
                var me = Enum.GetValues<Move>().Where(me => GetResult(me, elf) == result).First();
                score += (int)result;
                score += (int)me;
            }
            Console.WriteLine(score);
        }
    }
}

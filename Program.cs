using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Please enter the number of players:");
                int NumPlayersRow = int.Parse(ValidatePlayerInput(Console.ReadLine()));
                int[][] PlayerStats = new int[NumPlayersRow][];

                for (int Row = 0; Row < NumPlayersRow; Row++)
                {
                    Console.WriteLine($"Player #{Row + 1}: Enter times at bat:");
                    int TimesAtBatColumn = int.Parse(ValidateAtBatInput(Console.ReadLine()));
                    PlayerStats[Row] = new int[TimesAtBatColumn]; //***Remember to create new array
                    int AtBat = TimesAtBatColumn;
                    int SluggingScoreCount = 0;
                    int NonZeroCount = 0;
                    for (int Column = 0; Column < TimesAtBatColumn; Column++)
                    {
                        Console.WriteLine($"Player #{Row + 1}: Result for at-bat #{Column + 1} (0-4):");
                        int SluggingScore = int.Parse(ValidateScores(Console.ReadLine()));
                        PlayerStats[Row][Column] = SluggingScore;
                        SluggingScoreCount += SluggingScore;
                        if (SluggingScore > 0)
                        {
                            NonZeroCount++;
                        }
                    }
                    Console.WriteLine($"Player #{Row + 1} Batting average is:{BaseballMath.CalculateBattingAverage(NonZeroCount, AtBat)}");
                    Console.WriteLine($"Player #{Row + 1} Slugging Percentage is:{BaseballMath.CalculateSluggingPercentage(SluggingScoreCount, AtBat)}");
                }
                Console.WriteLine("Run program again? (Y/N)");
                repeat = RepeatProgram(Console.ReadLine().ToUpper());
            }
            }
            catch (Exception e)
            {
                Console.WriteLine("Whoops! Something went wrong! Let's try again");
            }
        }
        public static bool RepeatProgram(string Input)
        {
            if (Input != "Y")
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
        public static string ValidateScores(string Input)
        {
            while (!Regex.IsMatch(Input, @"(0|1|2|3|4)"))
            {
                Console.WriteLine("Please enter a valid At-Bat number!");
                Input = Console.ReadLine();
            }
            return Input;
        }
        public static string ValidateAtBatInput(string Input)
        {
            while (!Regex.IsMatch(Input,(@"(\d)")))
            {
                Console.WriteLine("Please enter a valid number of times at bat!");
                Input = Console.ReadLine();
            }
            if (int.Parse(Input) <= 0)
            {
                Console.WriteLine("Please enter a valid number of times at bat!");
            }
            return Input;
        }
        public static string ValidatePlayerInput(string Input)
        {
            while (!Regex.IsMatch(Input, @"(\d)"))
            {
                Console.WriteLine("Please enter a vaild number of players!");
                Input = Console.ReadLine();
            }
            return Input;
        }

        // ***I moved the following Methods to their own Class- BaseballMath
        //public static double CalculateBattingAverage(int NonZeros, int AtBats)
        //{
        //    double BattingAverage = NonZeros / (double)AtBats;

        //    return BattingAverage;
        //}
        //public static double CalculateSluggingPercentage(int SluggingScoreCount, int AtBats)
        //{
        //    double SluggingPercentage = SluggingScoreCount / (double)AtBats;
        //    return SluggingPercentage;
        //}
    }
}

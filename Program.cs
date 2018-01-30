using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //How many players
           Console.WriteLine("Please enter the number of players:");
           int NumPlayersRow = int.Parse(Console.ReadLine());
           int[][] PlayerStats = new int [NumPlayersRow][];

            for (int Row = 0; Row < NumPlayersRow; Row++)
            {
                Console.WriteLine($"Enter Player #{Row + 1} times at bat:");
                int TimesAtBatColumn = int.Parse(Console.ReadLine());
                PlayerStats[Row] = new int[TimesAtBatColumn];
                int AtBat = TimesAtBatColumn;
                int SluggingScoreCount = 0;
                int NonZeroCount = 0;
                for (int Column = 0; Column < TimesAtBatColumn; Column++)
                {
                    Console.WriteLine($"Player #{Row +1} result for at-bat #{Column +1} (0-4):");
                    int SluggingScore = int.Parse(Console.ReadLine());
                    PlayerStats[Row][Column] = SluggingScore;
                    SluggingScoreCount += SluggingScore;
                    if (SluggingScore > 0)
                    {
                        NonZeroCount++;
                    }
                }
                Console.WriteLine($"Player #{Row} batting average is:{CalculateBattingAverage(NonZeroCount,AtBat)}");
                Console.WriteLine($"Player # {Row} Slugging Percentage is:{CalculateSluggingPercentage(SluggingScoreCount, AtBat)}");
            }

            //How many at bats
            //What were the scores?
            //calculate slugging percentage
            //calculate batting average
        }
        public static double CalculateBattingAverage(int NonZeros, int AtBats)
        {
            double BattingAverage = NonZeros / (double)AtBats;

            return BattingAverage;
        }

        public static double CalculateSluggingPercentage(int SluggingScoreCount, int AtBats)
        {
            double SluggingPercentage = SluggingScoreCount / (double)AtBats;
            return SluggingPercentage;
        }
    }
}

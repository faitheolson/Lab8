using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class BaseballMath
    {
        public static double CalculateSluggingPercentage(int SluggingScoreCount, int AtBats)
        {
            double SluggingPercentage = SluggingScoreCount / (double)AtBats;
            return SluggingPercentage;
        }
        public static double CalculateBattingAverage(int NonZeros, int AtBats)
        {
            double BattingAverage = NonZeros / (double)AtBats;

            return BattingAverage;
        }

    }

}

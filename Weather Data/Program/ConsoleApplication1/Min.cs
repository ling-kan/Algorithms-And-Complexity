using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class MinimumValue
    {

        public static int MinInt(int[] numbers)
        {
            int MinI = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < MinI)
                {
                    MinI = numbers[i];
                }
            }

            return MinI;
        }
        public static int MinDo(double[] numbers)
        {
            double MinD = 2500;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < MinD)
                {
                    MinD = numbers[i];
                    index = i;
                }
            }
            return index;
        }

    }
}

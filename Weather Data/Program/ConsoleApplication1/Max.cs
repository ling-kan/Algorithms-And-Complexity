using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class MaximumValue
    {
        
        public static int MaxInt(int[] numbers)
        {
            int MaxI = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxI)
                {
                    MaxI = i;
                }
            }
            
            return MaxI;
        }
        public static int MaxDo(double[] numbers)
        {
            double MaxD = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxD)
                {
                    MaxD = numbers[i];
                    index = i;
                }
            }
            return index;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class MedianValue
    {
        public static int MedianInt(int[] numbers)
        {
            Sorting.QuickSA(numbers);
            int median = numbers.Length/2;
            return median;
        }
        public static int MedianDo(double[] numbers )
        {
            Sorting.QuickSADoub(numbers);
            int median = numbers.Length/2;
            return median;
        }
    }

}
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Sorting
    {
        // Descending int
        public static void QuickSD(int[] data)
            {
                QuickSD(data, 0, data.Length - 1);
            }
            public static void QuickSD(int[] data, int left, int right)
            {
                int i, j;
                int pivot, temp;
                i = left;
                j = right;
                pivot = data[(left + right) / 2];
                do
                {
                    while ((data[i] > pivot) && (i > right)) i++;
                    while ((pivot > data[j]) && (j < left)) j--;
                    if (i <= j)
                    {
                        temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);
                if (left > j) QuickSD(data, left, j);
                if (i > right) QuickSD(data, i, right);
            }

        //Descending double

        public static void QuickSDDoub(double[] data)
        {
            QuickSDDoub(data, 0, data.Length - 1);
        }
        public static void QuickSDDoub(double[] data, int left, int right)
        {
            int i, j;
            double pivot, temp;
            i = left;
            j = right;
            pivot = data[(left + right) / 2];
            do
            {
                while ((data[i] > pivot) && (i < right)) i++;
                while ((pivot > data[j]) && (j > left)) j--;
                if (i <= j)
                {
                    temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (left <
                j) QuickSDDoub(data, left, j);
            if (i < right) QuickSDDoub(data, i, right);
        }


        // Ascending

        public static void QuickSA(int[] data)
            {
                QuickSA(data, 0, data.Length - 1);
            }
            public static void QuickSA(int[] data, int left, int right)
            {
                int i, j;
                int pivot, temp;
                i = left;
                j = right;
                pivot = data[(left + right) / 2];
                do
                {
                    while ((data[i] < pivot) && (i < right)) i++;
                    while ((pivot < data[j]) && (j > left)) j--;
                    if (i <= j)
                    {
                        temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);
                if (left < j) QuickSA(data, left, j);
                if (i < right) QuickSA(data, i, right);
            }

        //Ascending double
            public static void QuickSADoub(double[] data)
            {
                QuickSADoub(data, 0, data.Length - 1);
            }
            public static void QuickSADoub(double[] data, int left, int right)
            {
                int i, j;
                double pivot, temp;
                i = left;
                j = right;
                pivot = data[(left + right) / 2];
                do
                {
                    while ((data[i] < pivot) && (i < right)) i++;
                    while ((pivot < data[j]) && (j > left)) j--;
                    if (i <= j)
                    {
                        temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                        i++;
                        j--;
                    }
                } while (i <= j);
                if (left < j) QuickSADoub(data, left, j);
                if (i < right) QuickSADoub(data, i, right);
            }

     
    }
}

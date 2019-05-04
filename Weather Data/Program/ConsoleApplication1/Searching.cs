using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Searching
    {
       
        public static int LinearSearch(int[] x, int Find)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (Find == x[i])
                {
                    return i;
                }
                i++;

            }
            return -1;

        }
        public static int SearchString(string[] x, string Find)
    {
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == Find)
            {
                return i;
            }
              
        }
        return -1;
    }

        }
    }

using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application
{
    class RossOnWye
    {
        public void RossOnWyeWS()
        {
            string[] Month = File.ReadAllLines(@"Weather_Data\Month.txt");
            string[] Year = File.ReadAllLines(@"Weather_Data\Year.txt");
            string[] Rain_2 = File.ReadAllLines(@"Weather_Data\WS2_Rain.txt");
            string[] AF_2 = File.ReadAllLines(@"Weather_Data\WS2_AF.txt");
            string[] Sun_2 = File.ReadAllLines(@"Weather_Data\WS2_Sun.txt");
            string[] TMax_2 = File.ReadAllLines(@"Weather_Data\WS2_TMax.txt");
            string[] TMin_2 = File.ReadAllLines(@"Weather_Data\WS2_TMin.txt");

            int[] Year2 = Array.ConvertAll(Year, int.Parse);
            int[] AF2 = Array.ConvertAll(AF_2, int.Parse);
            double[] Rain2 = Array.ConvertAll(Rain_2, double.Parse);
            double[] Sun2 = Array.ConvertAll(Sun_2, double.Parse);
            double[] TMax2 = Array.ConvertAll(TMax_2, double.Parse);
            double[] TMin2 = Array.ConvertAll(TMin_2, double.Parse);

            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("V - View Data");
            Console.WriteLine("A - Sort in ascending array");
            Console.WriteLine("D - Sort in descending array");
            Console.WriteLine("M - Find the Min, Max and Median of an array.");
            Console.WriteLine("F - Find Data");

            Sorting sort = new Sorting();
            string input = Convert.ToString(Console.ReadLine()).ToUpper();

            switch (input)
            {
                // View RossOnWye Weather Station Data
                case "V":
                    Console.WriteLine("   Year\t\tMonth\t  AF\t   Rain\t\tSun\tTMax\t Tmin");
                    for (int i = 0; i < Rain_2.Length; i++)
                    {
                        Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", Year[i], Month[i], AF2[i], Rain_2[i], Sun_2[i], TMax_2[i], TMin_2[i]);
                    }
                    Console.ReadLine();
                    break;
                case "A":

                    // Sorting RossOnWye Weather Station in ascending order
                    Console.WriteLine("Please select an array you would like to sort:");
                    Console.WriteLine("1 - Year\n2 - Month\n3 - AF\n4 - Rain\n5 - Sun\n6 - TMax\n7 - Tmin");
                    int AorD = Convert.ToInt32(Console.ReadLine());
                    // Sorting 'Year' Array in ascending order
                    if (AorD == 1)
                    {
                        Sorting.QuickSA(Year2);
                        for (int i = 0; i <= 1022; i++)
                        {
                            Console.WriteLine(Year2[i]);
                        }
                    }

                    // Sorting 'Month' Array in ascending order
                    if (AorD == 2)
                    {
                        DateTime now = DateTime.Now;
                        for (int i = 0; i < 12; i++)
                        {
                            Console.WriteLine(now.ToString("MMMM"));
                            now = now.AddMonths(1);
                        }


                    }
                    // Sorting 'AF' Array in ascending order
                    if (AorD == 3)
                    {
                        Sorting.QuickSA(AF2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(AF2[i]);
                        }
                    }

                    //-- Sorting 'Rain' Array in ascending order --
                    if (AorD == 4)
                    {
                        Sorting.QuickSADoub(Rain2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Rain2[i]);
                        }
                    }

                    // Sorting 'Sun' Array in ascending order
                    if (AorD == 5)
                    {
                        Sorting.QuickSADoub(Sun2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Sun2[i]);
                        }
                    }

                    // Sorting 'TMax' Array in ascending order
                    if (AorD == 6)
                    {
                        Sorting.QuickSADoub(TMax2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMax2[i]);
                        }
                    }

                    // Sorting 'TMin' Array in ascending order
                    if (AorD == 7)
                    {
                        Sorting.QuickSADoub(TMin2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMin2[i]);
                        }
                    }
                    Console.ReadLine();
                    break;

                // Finding RossOnWye Weather Station
                case "D":

                    // Sorting RossOnWye Weather Station in descending order
                    Console.WriteLine("Please select an array you would like to sort:");
                    Console.WriteLine("1 - Year\n2 - Month\n3 - AF\n4 - Rain\n5 - Sun\n6 - TMax\n7 - Tmin");
                    int DorA = Convert.ToInt32(Console.ReadLine());

                    // Sorting 'Year' Array in descending order
                    if (DorA == 1)
                    {
                        Sorting.QuickSD(Year2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Year2[i]);
                        }
                    }

                    // Sorting 'Month' Array in descending order
                    if (DorA == 2)
                    {

                        Console.WriteLine("Unable to sort");
                    }

                    // Sorting 'AF2' Array in descending order
                    if (DorA == 3)
                    {
                        Sorting.QuickSD(AF2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(AF2[i]);
                        }
                    }

                    //-- Sorting 'Rain' Array in descending order --
                    if (DorA == 4)
                    {
                        Sorting.QuickSDDoub(Rain2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Rain2[i]);
                        }
                    }

                    // Sorting 'Sun' Array in descending order
                    if (DorA == 5)
                    {
                        Sorting.QuickSDDoub(Sun2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Sun2[i]);
                        }
                    }

                    // Sorting 'TMax' Array in descending order
                    if (DorA == 6)
                    {
                        Sorting.QuickSADoub(TMax2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMax2[i]);
                        }
                    }

                    // Sorting 'TMin' Array in descending order
                    if (DorA == 7)
                    {
                        Sorting.QuickSADoub(TMin2);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMin2[i]);
                        }
                    }

                    Console.ReadLine();
                    break;
                case "M":
                    {
                        Console.WriteLine("Select which array you would like to view for the min, max and median:");
                        Console.WriteLine("1 - Year\n2 - AF\n3 - Rain\n4 - Sun\n5 - TMax\n6 - Tmin");

                        int i = Convert.ToInt32(Console.ReadLine());
                        switch (i)
                        {
                            //Min,Max,Median for Year
                            case 1:
                                {

                                    int min = MinimumValue.MinInt(Year2);
                                    Console.WriteLine("The minimum value: {0}", (Year2[min]));
                                    int max = MaximumValue.MaxInt(Year2);
                                    Console.WriteLine("The maximum value: {0}", (Year2[max]));
                                    int med = MedianValue.MedianInt(Year2);
                                    Console.WriteLine("The median value: {0}", (Year2[med]));
                                    break;
                                }

                            //Min,Max,Median for AF
                            case 2:
                                {
                                    int min = MinimumValue.MinInt(AF2);
                                    Console.WriteLine("The minimum value: {0}", (AF2[min]));
                                    int max = MaximumValue.MaxInt(AF2);
                                    Console.WriteLine("The maximum value: {0}", (AF2[max]));
                                    int med = MedianValue.MedianInt(AF2);
                                    Console.WriteLine("The median value: {0}", (AF2[med]));
                                    break;
                                }
                            //Min,Max,Median for Rain
                            case 3:
                                {
                                    int min = MinimumValue.MinDo(Rain2);
                                    Console.WriteLine("The minimum value: {0}", (Rain2[min]));
                                    int max = MaximumValue.MaxDo(Rain2);
                                    Console.WriteLine("The maximum value: {0}", (Rain2[max]));
                                    int med = MedianValue.MedianDo(Rain2);
                                    Console.WriteLine("The median value: {0}", (Rain2[med]));
                                    break;
                                }
                            //Min,Max,Median for Sun
                            case 4:
                                {
                                    int min = MinimumValue.MinDo(Sun2);
                                    Console.WriteLine("The minimum value: {0}", (Sun2[min]));
                                    int max = MaximumValue.MaxDo(Sun2);
                                    Console.WriteLine("The maximum value: {0}", (Sun2[max]));
                                    int med = MedianValue.MedianDo(Sun2);
                                    Console.WriteLine("The median value: {0}", (Sun2[med]));
                                    break;
                                }
                            //Min,Max,Median for TMax
                            case 5:
                                {
                                    int min = MinimumValue.MinDo(TMax2);
                                    Console.WriteLine("The minimum value: {0}", (TMax2[min]));
                                    int max = MaximumValue.MaxDo(TMax2);
                                    Console.WriteLine("The maximum value: {0}", (TMax2[max]));
                                    int med = MedianValue.MedianDo(TMax2);
                                    Console.WriteLine("The median value: {0}", (TMax2[med]));
                                    break;
                                }
                            //Min,Max,Median for TMin
                            case 6:
                                {
                                    int min = MinimumValue.MinDo(TMin2);
                                    Console.WriteLine("The minimum value: {0}", (TMin2[min]));
                                    int max = MaximumValue.MaxDo(TMin2);
                                    Console.WriteLine("The maximum value: {0}", (TMin2[max]));
                                    int med = MedianValue.MedianDo(TMin2);
                                    Console.WriteLine("The median value: {0}", (TMin2[med]));
                                    break;
                                }
                            default:
                                Console.WriteLine("Error");
                                break;
                        }

                        break;
                    }
                case "F":
                    {
                        Console.WriteLine("Which array would you like to search?");
                        Console.WriteLine("Type number:");
                        Console.WriteLine("1 - Year");
                        Console.WriteLine("2 - Month");

                        int i = Convert.ToInt32(Console.ReadLine());
                        //Search Year in RossOnWye
                        switch (i)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Please enter a year you would like to search.");
                                    //Loop statment, incase of incorrect value enterd.
                                    bool condition = true;
                                    while (condition)
                                    {
                                        int Rvalue = Convert.ToInt32(Console.ReadLine());
                                        int value = Searching.LinearSearch(Year2, Rvalue);
                                        if (value == -1)
                                        {
                                            //Error message if value is not found
                                            Console.WriteLine("Value not found. Please re-enter the value you would like to search.");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Year: {0} \nMonth: {1}\nTMax: {2}\nTMin: {3}\nSun: {4}\nRain: {5}\nAF: {6}", Year[value], Month[value], TMax2[value], TMin2[value], Sun2[value], Rain2[value], AF2[value]);
                                            condition = false;
                                        }
                                    }
                                    break;
                                }
                            //Search Month in RossOnWye
                            case 2:
                                //Loop statment, incase of incorrect value enterd.
                                bool condition2 = true;
                                while (condition2)
                                {
                                    string Rvalue = Console.ReadLine();
                                    int value = Searching.SearchString(Month, Rvalue);
                                    if (value == -1)
                                    {
                                        //Error message if value is not found
                                        Console.WriteLine("Value not found. Please re-enter the value you would like to search.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Year: {0} \nMonth: {1}\nTMax: {2}\nTMin: {3}\nSun: {4}\nRain: {5}\nAF: {6}", Year[value], Month[value], TMax2[value], TMin2[value], Sun2[value], Rain2[value], AF2[value]);
                                        condition2 = false;
                                    }
                                }
                                break;
                        }
                        break;
                    }

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }

    }
}

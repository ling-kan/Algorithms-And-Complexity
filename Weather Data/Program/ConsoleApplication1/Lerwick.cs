using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application
{
    public class LerwickOption
    {
        public void LerwickWS()
        {
            
            string[] Month = File.ReadAllLines(@"Weather_Data\Month.txt");
            string[] Year = File.ReadAllLines(@"Weather_Data\Year.txt");
            string[] Rain_1 = File.ReadAllLines(@"Weather_Data\WS1_Rain.txt");
            string[] AF_1 = File.ReadAllLines(@"Weather_Data\WS1_AF.txt");
            string[] Sun_1 = File.ReadAllLines(@"Weather_Data\WS1_Sun.txt");
            string[] TMax_1 = File.ReadAllLines(@"Weather_Data\WS1_TMax.txt");
            string[] TMin_1 = File.ReadAllLines(@"Weather_Data\WS1_TMin.txt");
           
            int[] Year1 = Array.ConvertAll(Year, int.Parse);
            int[] AF1 = Array.ConvertAll(AF_1, int.Parse);
            double[] Rain1 = Array.ConvertAll(Rain_1, double.Parse);
            double[] Sun1 = Array.ConvertAll(Sun_1, double.Parse);
            double[] TMax1 = Array.ConvertAll(TMax_1, double.Parse);
            double[] TMin1 = Array.ConvertAll(TMin_1, double.Parse);

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
                // View Lerwick Weather Station Data
                case "V":
                    Console.WriteLine("   Year\t\tMonth\t  AF\t   Rain\t\tSun\tTMax\t Tmin");
                    for (int i = 0; i < Rain_1.Length; i++)
                    {
                        Console.WriteLine("{0,10}{1,10}{2,10}{3,10}{4,10}{5,10}{6,10}", Year[i], Month[i], AF1[i], Rain_1[i], Sun_1[i], TMax_1[i], TMin_1[i]);
                    }
                    Console.ReadLine();
                    break;
                case "A":

                    // Sorting Lerwick Weather Station in ascending order
                    Console.WriteLine("Please select an array you would like to sort:");
                    Console.WriteLine("1 - Year\n2 - Month\n3 - AF\n4 - Rain\n5 - Sun\n6 - TMax\n7 - Tmin");
                    int AorD = Convert.ToInt32(Console.ReadLine());
                    // Sorting 'Year' Array in ascending order
                    if (AorD == 1)
                    {
                        Sorting.QuickSA(Year1);
                        for (int i = 0; i <= 1022; i++)
                        {
                            Console.WriteLine(Year1[i]);
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
                        Sorting.QuickSA(AF1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(AF1[i]);
                        }
                    }

                    //-- Sorting 'Rain' Array in ascending order --
                    if (AorD == 4)
                    {
                        Sorting.QuickSADoub(Rain1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Rain1[i]);
                        }
                    }

                    // Sorting 'Sun' Array in ascending order
                    if (AorD == 5)
                    {
                        Sorting.QuickSADoub(Sun1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Sun1[i]);
                        }
                    }

                    // Sorting 'TMax' Array in ascending order
                    if (AorD == 6)
                    {
                        Sorting.QuickSADoub(TMax1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMax1[i]);
                        }
                    }

                    // Sorting 'TMin' Array in ascending order
                    if (AorD == 7)
                    {
                        Sorting.QuickSADoub(TMin1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMin1[i]);
                        }
                    }
                    Console.ReadLine();
                    break;

                // Finding Lerwick Weather Station
                case "D":

                    // Sorting Lerwick Weather Station in descending order
                    Console.WriteLine("Please select an array you would like to sort:");
                    Console.WriteLine("1 - Year\n2 - Month\n3 - AF\n4 - Rain\n5 - Sun\n6 - TMax\n7 - Tmin");
                    int DorA = Convert.ToInt32(Console.ReadLine());

                    // Sorting 'Year' Array in descending order
                    if (DorA == 1)
                    {
                        Sorting.QuickSD(Year1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Year1[i]);
                        }
                    }

                    // Sorting 'Month' Array in descending order
                    if (DorA == 2)
                    {

                        Console.WriteLine("Unable to sort");
                    }

                    // Sorting 'AF1' Array in descending order
                    if (DorA == 3)
                    {
                        Sorting.QuickSD(AF1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(AF1[i]);
                        }
                    }

                    //-- Sorting 'Rain' Array in descending order --
                    if (DorA == 4)
                    {
                        Sorting.QuickSDDoub(Rain1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Rain1[i]);
                        }
                    }

                    // Sorting 'Sun' Array in descending order
                    if (DorA == 5)
                    {
                        Sorting.QuickSDDoub(Sun1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(Sun1[i]);
                        }
                    }

                    // Sorting 'TMax' Array in descending order
                    if (DorA == 6)
                    {
                        Sorting.QuickSADoub(TMax1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMax1[i]);
                        }
                    }

                    // Sorting 'TMin' Array in descending order
                    if (DorA == 7)
                    {
                        Sorting.QuickSADoub(TMin1);
                        for (int i = 0; i < 1022; i++)
                        {
                            Console.WriteLine(TMin1[i]);
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
                                 
                                    int min = MinimumValue.MinInt(Year1);
                                  Console.WriteLine("The minimum value: {0}", (Year1 [min]));
                                    int max = MaximumValue.MaxInt(Year1);
                                    Console.WriteLine("The maximum value: {0}", (Year1 [max]));
                                    int med = MedianValue.MedianInt(Year1);
                                    Console.WriteLine("The median value: {0}", (Year1 [med]));
                                    break;
                                }

                            //Min,Max,Median for AF
                            case 2:
                                {
                                    int min = MinimumValue.MinInt(AF1);
                                    Console.WriteLine("The minimum value: {0}", (AF1[min]));
                                    int max = MaximumValue.MaxInt(AF1);
                                    Console.WriteLine("The maximum value: {0}", (AF1[max]));
                                    int med = MedianValue.MedianInt(AF1);
                                    Console.WriteLine("The median value: {0}", (AF1[med]));
                                    break;
                                  }
                            //Min,Max,Median for Rain
                            case 3:
                                {
                                    int min = MinimumValue.MinDo(Rain1);
                                    Console.WriteLine("The minimum value: {0}", (Rain1[min]));
                                    int max = MaximumValue.MaxDo(Rain1);
                                    Console.WriteLine("The maximum value: {0}", (Rain1[max]));
                                    int med = MedianValue.MedianDo(Rain1);
                                   Console.WriteLine("The median value: {0}", (Rain1[med]));
                                    break;
                                }
                            case 4:
                                {
                                    int min = MinimumValue.MinDo(Sun1);
                                    Console.WriteLine("The minimum value: {0}", (Sun1[min]));
                                    int max = MaximumValue.MaxDo(Sun1);
                                    Console.WriteLine("The maximum value: {0}", (Sun1[max]));
                                    int med = MedianValue.MedianDo(Sun1);
                                    Console.WriteLine("The median value: {0}", (Sun1[med]));
                                    break;
                                }
                            case 5:
                                {
                                    int min = MinimumValue.MinDo(TMax1);
                                    Console.WriteLine("The minimum value: {0}", (TMax1[min]));
                                    int max = MaximumValue.MaxDo(TMax1);
                                    Console.WriteLine("The maximum value: {0}", (TMax1[max]));
                                    int med = MedianValue.MedianDo(TMax1);
                                    Console.WriteLine("The median value: {0}", (TMax1[med]));
                                    break;
                                }
                            case 6:
                                {
                                    int min = MinimumValue.MinDo(TMin1);
                                    Console.WriteLine("The minimum value: {0}", (TMin1[min]));
                                    int max = MaximumValue.MaxDo(TMin1);
                                    Console.WriteLine("The maximum value: {0}", (TMin1[max]));
                                    int med = MedianValue.MedianDo(TMin1);
                                    Console.WriteLine("The median value: {0}", (TMin1[med]));
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
                        switch (i)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Please enter a year you would like to search.");
                                    
                                    bool condition = true;
                                    while (condition)
                                    {
                                        int Rvalue = Convert.ToInt32(Console.ReadLine());
                                        int value = Searching.LinearSearch(Year1, Rvalue);
                                        if (value == -1)
                                        {
                                            Console.WriteLine("Value not found. Please re-enter the value you would like to search.");

                                        }
                                        else
                                        {
                                            Console.WriteLine("Year: {0} \nMonth: {1}\nTMax: {2}\nTMin: {3}\nSun: {4}\nRain: {5}\nAF: {6}", Year[value], Month[value], TMax1[value], TMin1[value], Sun1[value], Rain1[value], AF1[value]);
                                            condition = false;
                                        }
                                    }
                                    break;
                                }
                            case 2:
     
                                bool condition2 = true;
                                while (condition2)
                                {
                                    string Rvalue = Console.ReadLine();
                                    int value = Searching.SearchString(Month, Rvalue);
                                    if (value == -1)
                                    {
                                        Console.WriteLine("Value not found. Please re-enter the value you would like to search.");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Year: {0} \nMonth: {1}\nTMax: {2}\nTMin: {3}\nSun: {4}\nRain: {5}\nAF: {6}", Year[value], Month[value], TMax1[value], TMin1[value], Sun1[value], Rain1[value], AF1[value]);
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

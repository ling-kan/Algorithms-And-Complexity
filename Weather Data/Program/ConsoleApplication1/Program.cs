using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Application
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose a Weather Station for the data would you like to view:");
            Console.WriteLine("L - Lerwick");
            Console.WriteLine("RW - Ross on Wye");
            Console.WriteLine("E - Exit Application");
            
            string option = Convert.ToString(Console.ReadLine()).ToUpper();

                switch (option)
                    {
                        // View Lerwick Option
                        case "L":
                            Application.LerwickOption lerw = new Application.LerwickOption();
                            lerw.LerwickWS();
                            Console.ReadLine();
                            break;

                        // View Ross on Wye Option
                        case "RW":

                            Application.RossOnWye row = new Application.RossOnWye();
                            row.RossOnWyeWS();
                            Console.ReadLine();
                            break;

                        // Type 'E' to exit application
                        case "E":
                            Environment.Exit(0);
                            break;

                        // Error Message if unkown case is entered
                        default:
                            Console.WriteLine("Please enter the correct character");
                      break;
                    }
                    Console.ReadLine();
                }
            }

        }
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
        {
            static void Main(string[] args)
            {
                bool run = true;
                //Main do while loop to allow user to continue to use program
                do
                {
                    int batter;
                    //Prompt that welcomes user
                    Console.WriteLine("Welcome to the Batting Average Calculator");
                    Console.WriteLine("-----------------------------------------");
                    //Method call used to determine how many batters will be calcuated
                    batter = BatterCount();
                    //establish jagged array based of number of batters in rows
                    int[][] batArray = new int[batter][];
                    //Method call used to determine how many times each batter will be at bat
                    AtBat(batArray, batter);
                    
                    Console.WriteLine("\n0=Out, 1=single, 2=double, 3=triple, 4=home run");
                    //Method that prompts the user to enter values and populates arrays
                    newArray(batArray);
                    //Method that calcuates statistics and prints to the console
                    Calculations(batArray);
                    //Prompts user to continue
                    run = Cont();

                 }while (run) ;
              }
        public static int BatterCount()
            {
                int batter;

                Console.Write("\nPlease enter the number of batters: ");
                //validation that ensures user is entering an integer
                while (!Int32.TryParse(Console.ReadLine(), out batter))
                {
                    {
                        Console.WriteLine("\n");
                        Console.Write("Try again! Please enter an integer: ");
                    }
                //returns that value the main method and populate array
                }return batter;
            }

        public static void AtBat(int[][] batArray, int batter)
            {   //for loop used based on the number of batters entered in previous step
                for (int t = 0; t <= batter - 1; t++)
                {
                    int bats;
                    //Verifys integer is entered
                    Console.Write("\nPlease enter the number of at-bats for batter {0}: ", (t+1));
                    while (!Int32.TryParse(Console.ReadLine(), out bats))
                    {
                        {
                            Console.WriteLine("\n");
                            Console.Write("Try again! Please enter an integer: ");
                        }
                    }
                //Populates columns in the jagged array
                batArray[t] = new int[bats];
                }
            }

        public static void newArray(int[][] batArray)
        {       //for loop used to populate rows with data
                for (int r = 0; r < batArray.Length; r++)
                {   //Pompts user to enter data for each batter 
                    Console.WriteLine($"\nBatter {r + 1} ");
                    Console.WriteLine("*********");
                    for (int c = 0; c < batArray[r].Length; c++)
                {       //Pompts user to enter data for each at-bat
                        Console.Write($"Enter result for at-bat: ");
                        while (true)
                        {   //verification used to ensure correct data is entered
                            if (!Int32.TryParse(Console.ReadLine(), out batArray[r][c]))
                            {
                                {
                                    Console.Write("Please enter a valid input:");
                                }
                            }
                            else if (batArray[r][c] < 0 || batArray[r][c] > 4)
                            {
                                {
                                    Console.Write("Please enter a value between 0 and 4: ");
                                    continue;
                                }
                            }
                            else
                            {   //once correct data is entered, loop breaks and next step continues in process
                                break;
                            }
                        }
                    }
               }
        }

        public static void Calculations(int[][] batArray)
        {   //declare and initialize variables
            double success = 0;
            double sum = 0;
            //for loop used to start calucations on row
            for (int f = 0; f < batArray.Length; f++)
            {   //another for loop used to start calucations on columun
                for (int q = 0; q < batArray[f].Length; q++)
                {
                    if (batArray[f][q] > 0)
                    {   //establishing values used in baseball statistics
                        success++;
                        sum = sum + batArray[f][q];
                    }
                }
                //completing the batting average and sluggung percentage to be returned to user
                double BA = success / batArray[f].Length;
                double SP = sum / batArray[f].Length;
                //printing values for each individual batter
                Console.WriteLine("\n\nBatter " + (f + 1) + " average: " + BA.ToString("#.000") + " \t\tslugging percentage: " + SP.ToString("#.000"));
            }
        }

        public static bool Cont()
        {
            bool run = true;
            //simple prompt asking user to continue
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("\nDo you want to continue?(y/n)");
                string input = Console.ReadLine();

                if (input == "n")
                {
                    Console.WriteLine("\nThank you!");
                    run = false;
                }
            //returning run value to the main method
            return run;
        }
    }
}

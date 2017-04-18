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
            do
            {
                int result;
                double success = 0;
                double sum = 0;
                int c;
                int numberOfSuccess;
                int r;
                int bats = 0;

                Console.WriteLine("Welcome to the Batting Average Calculator");

                Console.Write("\nPlease enter the number of batters: ");
                int batter = Convert.ToInt32(Console.ReadLine());

                int[][] batArray = new int[batter][];

                for (int num = 0; num <= batter-1; num++)
                {
                    Console.Write("\nPlease enter the number of at bat for batter {0}: ", num);
                    bats = Convert.ToInt32(Console.ReadLine());
                    batArray[num] = new int[bats];
                }

                Console.WriteLine("\n0=Out, 1=single, 2=double, 3=triple, 4=home run ");

                for(int t = 0; t < bats; t++)
                { 
                for (int b = 0; b < batter; b++)
                {
                    // read the value of elements from the user 
                    for (r = 0; r < batArray.Length; r++)// rows 
                    {
                        Console.Write($"Batter.{r + 1}");
                        for (c = 0; c < batArray[r].Length; c++)// columns 
                        {
                            Console.Write($"Enter result: {c + 1}");
                            batArray[r][c] = int.Parse(Console.ReadLine());

                            if (batArray[r][c] > 0)
                            {
                                success++;
                                sum = sum + batArray[r][c];
                            }
                        }
                    }

                    
                }
                    Console.WriteLine("BAT ARRAY{0}", batArray[0][t]);
                }


                //double BA = success / batArray[r][c];
                //double SP = sum / batArray[r][c];
                //Console.WriteLine($"Batting Average:{BA} ");
                //Console.WriteLine($"Slugging Percentage:{SP} ");



                //for (int i = 0; i < batArray[]; i++)
                //{

                //    result = Convert.ToInt32(Console.ReadLine());







                run = Cont();

            } while (run);
        }

        //public static void Calc(double bats)
        //{
            
        //}
        public static bool Cont()
        {
            bool run = true;
            
                Console.WriteLine("Do you want to continue?(y/n)");
                string input = Console.ReadLine();

                if (input == "n")
                {
                    Console.WriteLine("\nThank you!");
                    run = false;
                }
            
            return run;
        }
    }
}

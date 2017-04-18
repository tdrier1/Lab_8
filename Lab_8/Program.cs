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
                Console.WriteLine("Welcome to the Batting Average Calculator");

                Console.Write("\nPlease enter the number of batters: ");
                int batter = Convert.ToInt32(Console.ReadLine());

                int[][] batArray = new int[batter][];

                for (int num = 0; num <= batter-1; num++)
                {
                    Console.Write("\nPlease enter the number of at bat for batter {0}: ", num);
                    int bats = Convert.ToInt32(Console.ReadLine());
                    batArray[num] = new int[bats];
                }
                Console.WriteLine("\n0=Out, 1=single, 2=double, 3=triple, 4=home run ");

                    // read the value of elements from the user 
                    for (int r = 0; r < batArray.Length; r++)// rows 
                    {
                        Console.WriteLine($"Batter.{r + 1}");
                        for (int c = 0; c < batArray[r].Length; c++)// columns 
                        {
                            Console.WriteLine($"Enter result: {c + 1}");
                            batArray[r][c] = int.Parse(Console.ReadLine());
                        }
                    }
                   


                run = Cont();


            } while (run);
        }
     
        //public static void Calc(double bats)
        //{
        //    int result;
        //    double success = 0;
        //    double sum = 0;

        //    for (int i = 0; i < bats; i++)
        //    {
        //        Console.Write("Result for at-bat" + i + ": ");
        //        result = Convert.ToInt32(Console.ReadLine());

        //        if (result > 0)
        //        {
        //            success++;
        //            sum = sum + result;
        //        }
        //    }

        //    double BA = success / bats;
        //    double SP = sum / bats;

        //    Console.WriteLine($"Batting Average:{BA} ");
        //    Console.WriteLine($"Slugging Percentage:{SP} ");
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

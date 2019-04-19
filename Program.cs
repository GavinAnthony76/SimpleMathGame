using System;

namespace SimpleMathGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello and welcome to simple math.\n Press ENTER to continue. ");
          
            Console.ReadKey();


            var numberGenerator = new Random();
            var repeat = true;

            while (repeat)
            {
             
                var choice = numberGenerator.Next(1, 4);

                if (choice == 1)
                   Calculator.subtraction();
                else if (choice == 2)
                   Calculator.addition();
                else if (choice == 3)
                   Calculator.multiplication();
                Console.Write("Do you wish to continue? Enter Y for yes or N for no, then press ENTER ");
               
                string selection;
                selection = Console.ReadLine();

                if (selection == "Y" || selection == "y")
                {
                    repeat = true;
                }
                else if (selection == "N" || selection == "n")
                {
                    repeat = false;
                    Console.WriteLine("Thanks for playing");
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
namespace SimpleMathGame
{
    public class Calculator
    {
        public static void addition()
        {
            var numberGenerator = new Random(); var number1 = numberGenerator.Next(1, 11); var number2 = numberGenerator.Next(1, 11); Console.WriteLine("What is the first number plus the second number? " + number1 + " + " + number2 + " ="); var answer = int.Parse(Console.ReadLine()); if (answer == number1 + number2)
            { Console.WriteLine("That is Correct! Press ENTER"); Console.ReadKey(); }
            else
            { Console.WriteLine("That is not correct! Press ENTER"); Console.ReadKey(); }
        }
        public static void subtraction()
        {
            var numberGenerator = new Random(); var number1 = numberGenerator.Next(1, 11); var number2 = numberGenerator.Next(1, 11); Console.WriteLine("What is the first number minus the second number? " + number1 + " - " + number2 + " ="); var answer = int.Parse(Console.ReadLine()); if (answer == number1 - number2)
            { Console.WriteLine("That is Correct! Press ENTER "); Console.ReadKey(); }
            else
            { Console.WriteLine("That is not correct! Press ENTER"); Console.ReadKey(); }
        }
        public static void multiplication()
        {
            var numberGenerator = new Random(); var number1 = numberGenerator.Next(1, 11); var number2 = numberGenerator.Next(1, 11); Console.WriteLine("What is the first number times the second number? " + number1 + " * " + number2 + " ="); var answer = int.Parse(Console.ReadLine()); if (answer == number1 * number2)
            { Console.WriteLine("That is Correct! Press ENTER"); Console.ReadKey(); }
            else
            { Console.WriteLine("That is not correct! Press ENTER"); Console.ReadKey(); }
        }
        
    }
}
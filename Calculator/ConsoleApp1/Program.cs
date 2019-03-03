using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Users First Value
            Console.WriteLine("Enter your first number: ");
            double firstNumber;
            if (!double.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.WriteLine("Enter a valid input for the first number");
            }
                    
            //Operation
            Console.WriteLine("Enter opperation (+,-,*,/)");
            string stringOperation = Console.ReadLine();

            //Users second value
            Console.WriteLine("Enter your second number: ");
            double secondNumber;
            if (!double.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.WriteLine("Enter a valid input for the second number.");
            }

            //Operation logic
            int operation = 0;
            if (stringOperation == "+")
            {
                operation = 1;
            }
            else if (stringOperation == "-")
            {
                operation = 2;
            }
            else if (stringOperation == "*")
            {
                operation = 3;

            }
            else if (stringOperation == "/")
            {
                operation = 4;
            }
            else
            {
                Console.WriteLine("Enter a valid operation");
            }
            //Calculations 
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    break;
            }
            Console.WriteLine("Result of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result);
            Console.ReadLine();
        }
    }
}

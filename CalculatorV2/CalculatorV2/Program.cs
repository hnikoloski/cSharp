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
            
            while (true)
            {


                //Users First Value
               
                double firstNumber;
                double secondNumber;
                string stringOperation;


                do
                {
                    Console.WriteLine("Enter Value for the first number, Must be a number!!");

                }
                while (!double.TryParse(Console.ReadLine(), out firstNumber));
                do
                {
                    Console.WriteLine("Enter opperation (+,-,*,/)");
                    stringOperation = Console.ReadLine();


                } 
                
                while (stringOperation != "+" && stringOperation != "-" && stringOperation != "*" && stringOperation != "/"  );

                do
                {
                    Console.WriteLine("Enter Value for the second number, Must be a number!!");

                }
                while (!double.TryParse(Console.ReadLine(), out secondNumber));


                //Operation
                
                //Operation logic
                //int operation = 0;
                //if (stringOperation == "+")
                //{
                //    operation = 1;
                //}
                //else if (stringOperation == "-")
                //{
                //    operation = 2;
                //}
                //else if (stringOperation == "*")
                //{
                //    operation = 3;
                //}
                //else if (stringOperation == "/")
                //{
                //    operation = 4;
                //}
                //else
                //{
                //    Console.WriteLine("Enter a valid operation");
                //}

                //Calculations 
                double result = 0;
                switch (stringOperation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        break;
                }
                Console.WriteLine("Result of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result);
                
                Console.WriteLine("Do you want to exit? Y/N? ");
                string exit = Console.ReadLine().ToUpper();
                if (exit == "N")
                {
                    continue;
                }
                else if (exit == "Y")
                {
                    break;
                }
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static DateTime AgeCalc()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                Console.WriteLine("Enter your birthdate in the following format: MM/DD/YYYY  ");
                DateTime birthDate;
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    TimeSpan age = now - birthDate;


                    if (birthDate.Month - 1 == 0 && birthDate.Day - 1 == 0)
                    {
                        Console.WriteLine($"Today is your Birthday. \n" +
                            $"You are {birthDate.Year} years old.");
                    }
                    if (birthDate.Month - 1 == 11 && birthDate.Day - 1 == 30)
                    {
                        Console.WriteLine($"Tomorrow is your Birthday\n " +
                            $"Your age will be {birthDate.Year} years.");
                    }
                    if (birthDate.Month - 1 == 0 && birthDate.Day - 1 == 1)
                    {
                        Console.WriteLine("Yesterday was your Birthday \n");
                    }
                    Console.WriteLine($"Your age is {age.Days / 365} years and {age.Days % 365} days");

                }
                else Console.WriteLine("invalid date.");

                
            }
        }

        static void AgeCalcVersion2(DateTime birthDate)
        {
            DateTime now = DateTime.Now;
            TimeSpan temp = now.Subtract(birthDate);
            DateTime age = DateTime.MinValue + temp;
            string ageDetail = string.Format("{0} Years {1} months {2} days", age.Year - 1, age.Month - 1, age.Day - 1);
            Console.WriteLine(ageDetail);

           
        }
      
        static void Main(string[] args)
        {


            AgeCalc();


            Console.ReadLine();
           
        }
    }
}

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
                    Console.WriteLine($"Your age is {age.Days / 365} years and {age.Days % 365} days");


                    Console.WriteLine("Do you want to exit? Y/N ?  \n\n\n");
                    string exit = Console.ReadLine().ToUpper();
              

                }
                else Console.WriteLine("invalid date.");


                
              
                            
                
            }
        }
      
        static void Main(string[] args)
        {
            AgeCalc();
        }
    }
}

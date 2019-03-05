using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] studentsG1 = new string[5] { "Zdravko", "Zdravko", "Zdravko", "Zdravko", "Zdravko" };
            string[] studentsG2 = new string[5] { "Zdravko2", "Zdravko", "Zdravko", "Zdravko", "Zdravko" };
            string[] studentsG3 = new string[5] { "Zdravko3", "Zdravko", "Zdravko", "Zdravko", "Zdravko" };

            Console.WriteLine("enter student group: (There are 1,2 and 3 ) ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine(string.Join(",", studentsG1)); 
                    break;
                case "2":
                    Console.WriteLine(string.Join(",", studentsG2));

                    break;
                case "3":
                    Console.WriteLine(string.Join(",", studentsG3));

                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again");
                    break;
            }



            Console.ReadLine();
        }
    }
}

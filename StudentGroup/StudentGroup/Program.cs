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
            while (true)
            {


                string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
                string[] studentsG2 = new string[5] { "Anastasija", "Andrej", "Damjan", "David", "Jovan" };
                string[] studentsG3 = new string[5] { "Marko", "Petar", "Stefan", "Angela", "Dimitar" };


                Console.WriteLine("enter student group: (There are 1,2 and 3 if you want to exit enter E) ");
                string userInput = Console.ReadLine().ToUpper();

                if (userInput == "1")
                {
                    Console.WriteLine(string.Join(",", studentsG1));
                    Console.WriteLine("-----------------------------------------------------------------");

                }
                else if (userInput == "2")
                {
                    Console.WriteLine(string.Join(",", studentsG2));
                    Console.WriteLine("-----------------------------------------------------------------");
                }
                else if (userInput == "3")
                {
                    Console.WriteLine(string.Join(",", studentsG3));
                    Console.WriteLine("-----------------------------------------------------------------");
                }

                else if (userInput == "E")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter a valid input");
                }
            }
 
        } 
    }
}

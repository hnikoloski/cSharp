using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i = 2;
            string[] names = new string[3] { "Petko", "Trajko", "Branko" };
                //Console.WriteLine(string.Join(",", names));
                Console.WriteLine("********************************************");
                Console.WriteLine("Do you want to enter another name? Y/N");
                string userChoice = Console.ReadLine().ToUpper();
                if (userChoice == "Y")
                {                    
                    i++;
                    Console.WriteLine("********************************************");
                    Console.WriteLine("Enter the name you want to add");

                    string newName = Console.ReadLine();
                    Array.Resize<string>(ref names, i + 1);
                    names[i] = newName;
                    Console.WriteLine(string.Join(",", names));  

                }
                else if(userChoice == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                

            }

        }
    }
}

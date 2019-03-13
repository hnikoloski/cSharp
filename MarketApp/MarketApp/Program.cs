using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("Enter your first  name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name :");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter date of birth :");
            person.dateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter your social security number");
            person.setSSN(Console.ReadLine());
            Console.WriteLine("Do you have loyality card? : Y/N ?");
            string isLoyal = Console.ReadLine().ToUpper();
            while (isLoyal != "Y" &&  isLoyal != "N")
            {
                Console.WriteLine("Do you have a lyoal card ? Y/N ??");
                isLoyal = Console.ReadLine().ToUpper();
            }
            // IF logika 
            if (isLoyal == "Y")
            {
                person.isLoyal = true;

            }
            else person.isLoyal = false;

            Console.WriteLine(person.isLoyal);
            Console.ReadLine();

            List<Product> Products = new List<Product>();
            Products.Add(new Product
            {
                productName = "Milk",
                declaration = "Liquid",
                serialNumber = 5,
                description = "It's milk"
            });
            Products.Add(new Product
            {
                productName = "Water",
                declaration = "Liquid",
                serialNumber = 5,
                description = "It's water"
            });
            Products.Add(new Product
            {
                productName = "Melty Chicken",
                declaration = "Food",
                serialNumber = 5,
                description = "It's food"
            });
        }
    }
}

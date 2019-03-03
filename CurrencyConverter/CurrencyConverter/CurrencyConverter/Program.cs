using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Wanabe database start ↓
            double usdRate = 54.02;
            double eurRate = 61.51;
            double gbpRate = 71.60;
            // Wanabe database end ↑

            // Users First Value
            Console.WriteLine("Enter how many denars you have ");
            double userDenars;
            if (!double.TryParse(Console.ReadLine(), out userDenars))
            {
                Console.WriteLine("Enter a valid amount and just numbers..");
            }
            else
            {
                Console.WriteLine("Enter to what currency do you want to convert to: USD, EUR or GBP");
                string currencyWanted = Console.ReadLine().ToUpper();
                double result = 0;
                if (currencyWanted == "USD")
                {
                    result = Math.Round(userDenars / usdRate, 2);
                    Console.WriteLine(userDenars + " denars is equal to " + result + "USD");
                }
                else if (currencyWanted == "EUR")
                {
                    result = Math.Round(userDenars / eurRate, 2);
                    Console.WriteLine(userDenars + " denars is equal to " + result + "EUR");
                }
                else if (currencyWanted == "GBP")
                {
                    result = Math.Round(userDenars / gbpRate, 2);
                    Console.WriteLine(userDenars + " denars is equal to " + result + "GBP");
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            char userEntry = 'a';
            bool pleaseContinue = true;
            int danielleSales = 0;
            int edwardSales = 0;
            int francisSales = 0;
            int grandTotal = 0;
            do
            {
                Console.WriteLine("There are three salespeople : Danielle, Edward, and" +
                    " Francis");
                    Console.WriteLine("Choose D, E, or F for their sales. Enter Z to quit.");
                userEntry = Convert.ToChar(Console.ReadLine());
                if (userEntry == 'D' || userEntry == 'd')
                {
                    danielleSales = danielleSales + Convert.ToInt32(Console.ReadLine());
                }
                else if (userEntry == 'E' || userEntry == 'e')
                {
                    edwardSales = edwardSales + Convert.ToInt32(Console.ReadLine());
                }
                else if (userEntry == 'F' || userEntry == 'f')
                {
                    francisSales = francisSales + Convert.ToInt32(Console.ReadLine());
                }
                else if (userEntry == 'Z' || userEntry == 'z')
                {
                    pleaseContinue = false; 
                }
                else
                    Console.WriteLine("INVALID INITIAL ENTERED");
            } while (pleaseContinue);
            grandTotal = danielleSales + edwardSales + francisSales;
            Console.WriteLine();
        }
    }
}

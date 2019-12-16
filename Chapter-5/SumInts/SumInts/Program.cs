using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            int sum = 0;
            bool again = true;
            while(again)
            {
                Console.WriteLine("Enter an integer for me!");
                userInput = Convert.ToInt32(Console.ReadLine());
                sum = sum + userInput;
                
                if (userInput == 999)
                {
                    sum = sum - userInput;
                    Console.WriteLine("Goodbye!");
                    again = false;
                }
                else
                    Console.WriteLine("Current sum is {0}.", sum);
                    
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            int count = 0;
            int sum = 0;
            double average = 0;
            do
            {
                Console.WriteLine("Enter a test score between 0 and 100 : (935 to exit)");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < 0 && userInput > 100 && userInput != 935)
                {
                    Console.WriteLine("ERROR. Invalid score entered.");
                }
                else if (0 < userInput && userInput < 100 || userInput == 935)
                {
                    Console.WriteLine("Valid score entered.");
                    sum = sum + userInput;
                    count++;
                }


            } while (userInput != 935);
            sum = sum - 935;
            count--;
            average = sum / count;
            Console.WriteLine("{0} is your sum.", sum);
            Console.WriteLine("{0} is your count.", count);
            Console.WriteLine("{0} is your average.", average);
            Console.WriteLine("Goodbye!");
            
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            bool again = true;
            int userAttempts = 0;
            while (again)
            {
                Console.WriteLine("Please enter a number between 1 and 100 >>> ");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry > r)
                {
                    Console.WriteLine("Hey, that's too high! >:(");
                    userAttempts++;
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("Hey, that's too low! >:(");
                    userAttempts++;
                }
                else
                {
                    Console.WriteLine("Hey, that's just right! You win! :)");
                    again = false;
                }
                if (userAttempts == 6)
                {
                    Console.WriteLine("That's it, I'm kicking you out. " +
                        "You've had a whole {0} tries, pal. The answer was " +
                        "{1}. >:(", userAttempts, r);
                    again = false;
                }
            }
           
        }
    }
}

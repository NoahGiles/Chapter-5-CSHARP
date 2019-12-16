using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueInput;
            int sum = 0;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Enter a value!");
                valueInput = Convert.ToInt32(Console.ReadLine());
                sum = sum + valueInput;
            }
            Console.WriteLine("Your total is " + sum + "!");
        }
    }
}

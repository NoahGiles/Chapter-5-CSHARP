using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letterInput = 'a';

            while (letterInput != '!')
            {
                if (char.IsLower(letterInput))
                {
                    Console.WriteLine("Enter a lowercase letter.");
                    letterInput = Convert.ToChar(Console.ReadLine());
                }
                else if (char.IsUpper(letterInput))
                {
                    Console.WriteLine("Error. Please enter a LOWERCASE letter.");
                    letterInput = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Error. Please enter a lowercase LETTER.");
                    letterInput = Convert.ToChar(Console.ReadLine());
                }
                if (char.IsLower(letterInput))
                {
                    Console.WriteLine("OK");
                }
                }
                Console.WriteLine("Goodbye!");
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_or_not_numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a palindrome:");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int reversedNumber = 0;
            while (temp > 0)
            {
                int remainder = temp % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                temp /= 10;
            }
            if (number == reversedNumber)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
    }

}
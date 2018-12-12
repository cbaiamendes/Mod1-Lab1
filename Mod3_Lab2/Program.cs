using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 9;
            int second = 0;

            Console.WriteLine("Enter your first number: ");
            try
            {
                first = System.Int32.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number");
            }
            
            Console.WriteLine("Enter your second number: ");
            try
            {
                second = System.Int32.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number");
            }

            int result = Divide(first, second);
            Console.WriteLine($"The result of dividing {first} by {second} is {result}");
        }
        static int Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value. ");
            }
            return result;
        }
    }
}

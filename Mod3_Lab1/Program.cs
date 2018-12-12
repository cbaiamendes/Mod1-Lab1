using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

            int result3 = Sum(10, 50, 80); 
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

            double dblResult = Sum(10, 50);
            Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
        }

        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method

        static int Sum(int first, int second)
        {
            int sum = first + second;
            //Console.WriteLine($"The sum of the {first} and {second} is: {sum}");
            return sum;
        }

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            //Console.WriteLine($"The sum of the {first} and {second} is: {sum}");
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}

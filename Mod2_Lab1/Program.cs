﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////create an if decision block
            ////use this if block to check for an even number

            ////Request user input ReadLine()
            //Console.WriteLine("Please enter an integer value and press Enter.");

            ////Assign the entered value to the varieble input
            ////convert input to integer before using
            //int input = Int32.Parse(Console.ReadLine());

            ////check to see if the number is even
            ////Here we use the simple task of checking for a remainder when dividing by 2
            ////The (%) o modulus operator returns the remainder of the integer division.
            ////If the remainder is 0, then the value is able to be divided by 2 with
            ////no remainder, which means it is an even number.
            //if (input % 2 == 0)
            //{
            //    Console.WriteLine("The entered number was an even number.");
            //}
            //else
            //{
            //    Console.WriteLine("The entered number was not an even number");
            //}

            //Create a switch block
            Console.WriteLine("Coffee sizes: 1=small 2=medium 3-large");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please inseart {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssLab
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();

        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the Student first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Student last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Student BirthDate (yyyy,mm,dd)");
            DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the Student Address information");
            Console.WriteLine("Enter streat");
            string street = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State/Province");
            string stateProvince = Console.ReadLine();
            Console.WriteLine("Enter Zip/Postal");
            string zipPostal = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Country");
            string country = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthDay, street, city, stateProvince, zipPostal, country);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the Teacher first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher last name ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher BirthDate (yyyy,mm,dd) ");
            DateTime birthDay = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the Teacher Address information");
            Console.WriteLine("Enter streat");
            string street = Console.ReadLine();
            Console.WriteLine("Enter city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State/Province");
            string stateProvince = Console.ReadLine();
            Console.WriteLine("Enter Zip/Postal");
            string zipPostal = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Country");
            string country = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, birthDay, street, city, stateProvince, zipPostal, country);
        }

        static void PrintStudentDetails(string first, string last, DateTime bDay, string street1, string cty, string state, string zip, string ctry)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, bDay);
            Console.WriteLine("Lives in {0}, {1}, {2}", street1, cty, state);
            Console.WriteLine("{0}, {1}", zip, ctry);
            Console.WriteLine();
        }

        static void PrintTeacherDetails(string first, string last, DateTime bDay, string street1, string cty, string state, string zip, string ctry)
        {
            Console.WriteLine("The Teacher: {0} {1} was born on: {2}", first, last, bDay);
            Console.WriteLine("Lives in {0}, {1}, {2}", street1, cty, state);
            Console.WriteLine("{0}, {1}", zip, ctry);
        }

        class Square
        {
            private string x;
        }
    }
}

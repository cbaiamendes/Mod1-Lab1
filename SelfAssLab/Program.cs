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
            //Student and Teacher info
            String fisrtName = "";
            String lastName = "";

            DateTime birthDate;

            String addressLine1 = "";
            String addressLine2 = "";

            String city = "";
            String stateProvince = "";
            String zipPostal = "";
            String country = "";

            //UProgram Info
            String programName = "";
            String departmentHead = "";
            String degrees = "";


            //Degree info
            String degreeName = "";
            int creditsRequirement;

            //Course Info
            String courseName = "";
            int credits;
            int durationInWeeks;
            String teacher = "";

            //Assign Values to Student
            Console.WriteLine("Enter the Student Information");
            Console.Write("FisrtName: ");
            fisrtName = Console.ReadLine();
            Console.Write("LastName: ");
            lastName = Console.ReadLine();
            Console.Write("BirthDate (yyyy,mm,dd): ");
            birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Street: ");
            addressLine1 = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State/Province: ");
            stateProvince = Console.ReadLine();
            Console.Write("Zip/Postal: ");
            zipPostal = Convert.ToString(Console.ReadLine());
            Console.Write("Country: ");
            country = Console.ReadLine();
            Console.WriteLine("==============================");
            Console.WriteLine("======== Student Info ========");
            Console.WriteLine("Name: " + fisrtName + " " + lastName);
            Console.WriteLine("BirthDate: " + birthDate);
            Console.WriteLine(addressLine1 + ", "+ city + ", "+ stateProvince +", "+ zipPostal + " "+ country);

            //Assign Value to Teacher
            Console.WriteLine("==============================");
            Console.WriteLine("Enter the Teacher Information");
            Console.Write("FisrtName: ");
            fisrtName = Console.ReadLine();
            Console.Write("LastName: ");
            lastName = Console.ReadLine();
            Console.Write("BirthDate (yyyy,mm,dd): ");
            birthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Street: ");
            addressLine1 = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State/Province: ");
            stateProvince = Console.ReadLine();
            Console.Write("Zip/Postal: ");
            zipPostal = Convert.ToString(Console.ReadLine());
            Console.Write("Country: ");
            country = Console.ReadLine();
            Console.WriteLine("==============================");
            Console.WriteLine("======== Teacher Info ========");
            Console.WriteLine("Name: " + fisrtName + " " + lastName);
            Console.WriteLine("BirthDate: " + birthDate);
            Console.WriteLine(addressLine1 + ", " + city + ", " + stateProvince + ", " + zipPostal + " " + country);

            //Assign Vlaue to UProgram Info


        }
    }
}

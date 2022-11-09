using System.Collections;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine(@"
Choose a book from the Library:
Option C: C# Books
Option O: .Net Books
Option D: Clean Code Books
Option E: EFCore Books
");
            string? choice = Console.ReadLine();
            string[] options =  new string[] {"C", "O", "D", "E"};

                if (choice == "C" || choice == "c")
                    Console.WriteLine("C# 8.0 and .NET Core 3.0\r\nHead First C#\r\nC# 8.0 Pocket Reference\r\nMurach’s C# 2015");
                else if (choice == "O" || choice == "o")
                    Console.WriteLine("Software Architecture with C# 10 and .NET 6\r\nPro ASP.NET Core 6\r\nProfessional C# and .NET\r\nBuilding Modern Serverless Web APIs");
                else if (choice == "D" || choice == "d")
                    Console.WriteLine("Clean Code: A Handbook of Agile Software Craftsmanship\r\nCode Complete\r\nThe Pragmatic Programmer: From Journeyman to Master");
                else if (choice == "E" || choice == "e")
                    Console.WriteLine("Kick start: Introduction to Entity Framework Core.\r\nThe other way around : Database First Approach.\r\nRelationships: Terminology & Conventions.\r\nBuilding Relationships: Understanding Mapping.\r\nKnow the validation: Explore inbuilt validation.\r\nSave Yourself : Hack Proof your Entities.");
            else
            {
                Console.WriteLine("Wrong Choice, Kindly try again later");
            }

        
        }
    }
}
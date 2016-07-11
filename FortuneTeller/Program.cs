using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your birth month?");
            string birthMonth = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            Console.WriteLine(Retirement(age));
        }

        //Method to calculate the number of years until retirement
        static int Retirement(int age)
        {
            int years;
            if(age % 2 == 0)
            {
                years = 15;
            }
            else
            {
                years = 25;
            }
            return years;
        }
        //TEST
        //Method to figure out where the user will retire
        static string Location(int sibs)
        {
            string location;
            switch (sibs)
            {
                case 0:
                    location = "Trash Can Heights, Oklahoma";
                    break;
                case 1:
                    location = "Maui";
                    break;
                case 2:
                    location = "c";
                    break;
                case 3:
                    location = "d";
                    break;
                default:
                    location = "e";
                    break;
            }
            return location;
        }

    }
}

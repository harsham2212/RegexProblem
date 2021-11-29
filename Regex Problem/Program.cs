using System;

namespace Regex_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Regex Program Press-\n 1.Validate First Name\n 2.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("User Registration Validating using Regular Expression!");
                        Sample regexSample = new Sample();
                        Console.WriteLine("Enter the First Name to Validate:");
                        string input = Console.ReadLine();
                        regexSample.ValidatingFirstName(input);
                        regexSample.Validating();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}


